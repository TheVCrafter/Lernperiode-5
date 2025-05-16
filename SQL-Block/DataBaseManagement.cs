using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DataBaseManagement
{
    static string connectionString = "Server=localhost\\HEHEHEHA;Database=Wintris_Data;Trusted_Connection=True";

    public DataBaseManagement()
    {
    }

    static public void NewUser(string username)
    {
        AddData(
            "IF NOT EXISTS (SELECT 1 FROM username WHERE username = @username) " +
            "INSERT INTO username (username) VALUES (@username);",
            new string[] { "username" },
            new object[] { username }
        );
    }

    static public void NewScore(int score)
    {
        AddData(
            "IF NOT EXISTS (SELECT 1 FROM score WHERE score = @score) " +
            "INSERT INTO score (score) VALUES (@score);",
            new string[] { "score" },
            new object[] { score }
        );
    }

    static public void User2Score(int score, string username)
    {
        AddData(
            "IF NOT EXISTS (" +
                "SELECT 1 FROM username2Score " +
                "WHERE usernameID = (SELECT TOP 1 usernameID FROM username WHERE username = @username) " +
                "AND scoreID = (SELECT TOP 1 scoreID FROM score WHERE score = @score)) " +
            "INSERT INTO username2Score(usernameID, scoreID) VALUES (" +
                "(SELECT TOP 1 usernameID FROM username WHERE username = @username), " +
                "(SELECT TOP 1 scoreID FROM score WHERE score = @score));",
            new string[] { "username", "score" },
            new object[] { username, score }
        );
    }

    static void AddData(string query, string[] parametername, object[] data)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@{parametername[i]}", data[i]);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                showError(ex);
            }
        }
    }
    static public int UserHighscore(string username)
    {
                string query = $@"
        SELECT MAX(s.score)
        FROM score s
        JOIN username2Score us ON s.scoreID = us.scoreID
        JOIN username u ON us.usernameID = u.usernameID
        WHERE u.username = '{username}'";
        var data = GetData(query);
        if (data != null && data.Length > 0 && data[0][0] != DBNull.Value)
        {
            int result = Convert.ToInt32(data[0][0]);
            return result;
        }
        else
        {
            return 0;
        }

    }
    static  public object[][] AllHighscores()
    {
        string query = $@"
        SELECT u.username, s.score
        FROM username u INNER JOIN username2score us ON u.usernameID = us.usernameID
        INNER JOIN score s ON us.scoreID = s.scoreID ORDER BY s.score DESC";
        object[][] data = GetData(query);
        return data;
    }
    static public object[][] GetData(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    var resultList = new System.Collections.Generic.List<object[]>();

                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        reader.GetValues(row);
                        resultList.Add(row);
                    }

                    return resultList.ToArray();
                }
            }
            catch (Exception ex)
            {
                showError(ex);
                return null;
            }
        }
    }
    static void showError(Exception ex)
    {
        MessageBox.Show("Fehler: " + ex.Message);
    }

}