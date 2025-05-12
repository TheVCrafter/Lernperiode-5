# Lernperiode 5

2.5 bis 23.5

## Grob-Planung
Ich habe vor mein Tetris Spiel um die Funktionen zu erweitern, Spieler Namen angeben zu können und die erreichten Punktzahlen zu speichern. Ausserdem soll es eine Bestenliste mit den 10 besten Scores geben.

## 2.5

- [x] Textbox zum angeben eines Benutzernamens hinzufügen
- [X] Knopf zum anzeigen der Bestenliste hinzufügen
- [X] Erstellen einer Datenbank für das Spiel
- [X] Implementation des Datenspeicherns

Heute fügte ich zunächst eine Textbox ein, welche beim Starten des Spiels angezeigt wird und es ermöglicht einen Benutzernamen anzugeben. Ich kümmerte mich ausserdem darum, dass solange das Spiel nicht komplett neu gestartet wird immer der gleiche Benutzername benutzt wird. Als ich damit fertig war, fügte ich noch einen Knopf hinzu welchen ich in Zukunft dazu verwenden werde die Bestenliste einzublenden. Ich schrieb jedoch noch keinen Code dazu. Um das Speichern von Daten zu ermöglichen erstellte ich dann eine SQL-Datenbank mit dem namen Wintris_Data. Dort fügte ich anschliessend 3 Tabellen ein. Eine für scores, eine für usernames und eine zwischentabelle username2score da es sich um eine n:m beziehung handelt. Anschliessend begann ich damit den Code für das Speichern der Daten zu schreiben. Dazu musste ich das NuGet-Packet "System.Data.SqlClient" installieren. Beim Coden versuchte ich dann anschliessend, anders als in der letzten Lernperiode, auch auf das DRY-Prinzip zu achten.

## 9.5 Kernfunktionalität

- [x] **Bugfixes** (fehlerhafte Daten-Speicherung)
- [x] **Einfügen einer funktionierenden Bestenliste** (10 beste Ergebnisse werden angezeigt)
- [x] **Einfügen eines Menüs für Settings**

Heute habe ich mich zunächst damit beschäftigt, einige **Fehler zu beheben**. Denn als ich nochmals prüfte, ob die **Daten richtig in der Datenbank gespeichert** werden, fiel mir auf, dass statt nur einem neuen Eintrag **komischerweise 34** erstellt wurden. Nachdem ich diesen **Fehler** ausgebessert hatte, begann ich damit, eine **Highscore-Liste** zu erstellen, welche alle erreichten Punktzahlen aller User zeigt.

Dazu kreierte ich zunächst ein neues **Form** namens `Highscores` und darin eine `ListView`, um die verschiedenen Einträge anzuzeigen. Die Daten werden mithilfe einer **SQL-Abfrage** geladen:

```sql
SELECT u.username, s.score
FROM username u
INNER JOIN username2score us ON u.usernameID = us.usernameID
INNER JOIN score s ON us.scoreID = s.scoreID
ORDER BY s.score DESC;
````
## 16.5 Kernfunktionalität und Ausbau

- [ ] ...
- [ ] ...
- [ ] ...
- [ ] ...

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 23.5 Abschluss

- [ ] ...
- [ ] ... (falls Ihnen nichts einfällt: Können Sie mit einem PowerShell-Skript von Ihrer Datenbank regelmäßig ein *backup* erstellen?)
- [ ] Reflexion über Ihre Arbeitsweise
- [ ] Beschreibung des fertigen Projekts mit .gif etc.

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## Fertiges Projekt

✍️ Beschreiben Sie hier, wie Ihr Projekt am Ende aussieht, und fügen Sie mindestens ein .gif ein.

## Reflexion

✍️ Was ging gut, was ging weniger gut? Was haben Sie gelernt, und was würden Sie bei der nächsten Lernperiode versuchen besser zu machen? Fassen Sie auch einen übergeordneten Vorsatz für Ihr nächstes Jahr im Lernatelier (100 bis 200 Wörter).
