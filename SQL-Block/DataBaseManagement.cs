using Microsoft.VisualBasic;
using NAudio.Wave;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public class DataBaseManagement
{
    static string connectionString = "Server=localhost\\HEHEHEHA;Database=Wintris_Data;Trusted_Connection=True";
    static string query;
    static object[] data;
    static string[] parametername;
    public DataBaseManagement()
    {

    }
    static public void NewUser(string username)
    {
        AddData(
    "INSERT INTO username (username) VALUES (@username);",
    new string[] { "username" },
    new object[] { username }
    );
    }
    static public void NewScore(int score)
    {
        AddData(
        "INSERT INTO score (score) VALUES (@score);",
        new string[] { "score" },
        new object[] { score }
        );
    }
    static public void User2Score(int score, string username)
    {
        AddData(
        $"INSERT INTO username2score(usernameID,scoreID) VALUES ((SELECT usernameID FROM username WHERE username = @username), (SELECT scoreID FROM score WHERE score = @score));",
        new string[] { "username", "score" },
        new object[] { username, score }
        );
    }
    static void AddData(string query, string[] parametername, object[] data)
    {
    } 
}
