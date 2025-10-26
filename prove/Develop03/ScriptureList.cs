
/*
old
Book,Reference
Moses,1:39
Moses,7:18
Abraham,3:22–23
Genesis,1:26–27
Genesis,39:9
Exodus,20:3–17
Exodus,33:11
Leviticus,19:18
Deuteronomy,7:3–4
Joshua,1:8
Joshua,24:15
1 Samuel,16:7
Job,19:25–26
Psalm,24:3–4
Proverbs,3:5–6
Isaiah,1:18
Isaiah,29:13–14
Isaiah,53:3–5
Isaiah,55:8–9
Jeremiah,16:16
Ezekiel,37:15–17
Daniel,2:44–45
Amos,3:7
Malachi,3:8–10
Malachi,4:5–6

new
Book,Reference
Matthew,5:14–16
Matthew,6:24
Matthew,16:15–19
Matthew,25:40
Luke,24:36–39
John,3:5
John,7:17
John,10:16
John,14:15
John,17:3
Acts,7:55–56
Romans,1:16
1 Corinthians,10:13
1 Corinthians,15:20–22
1 Corinthians,15:29
1 Corinthians,15:40–42
Ephesians,4:11–14
2 Thessalonians,2:1–3
2 Timothy,3:1–5
2 Timothy,3:16–17
Hebrews,5:4
James,1:5–6
James,2:17–18
Revelation,14:6–7
Revelation,20:12–13

bom
Book,Reference
1 Nephi,3:7
1 Nephi,19:23
2 Nephi,2:25
2 Nephi,2:27
2 Nephi,9:28–29
2 Nephi,28:7–9
2 Nephi,32:3
2 Nephi,32:8–9
Jacob,2:18–19
Mosiah,2:17
Mosiah,3:19
Mosiah,4:30
Alma,32:21
Alma,34:32–34
Alma,37:6–7
Alma,37:35
Alma,41:10
Helaman,5:12
3 Nephi,11:29
3 Nephi,27:27
Ether,12:6
Ether,12:27
Moroni,7:16–17
Moroni,7:45
Moroni,10:4–5

D&C
Book,Reference
Joseph Smith—History,1:15–20
D&C,1:37–38
D&C,8:2–3
D&C,10:5
D&C,14:7
D&C,"18:10, 15–16"
D&C,19:16–19
D&C,25:12
D&C,58:26–27
D&C,58:42–43
D&C,59:9–10
D&C,64:9–11
D&C,64:23
D&C,76:22–24
D&C,82:3
D&C,82:10
D&C,84:33–39
D&C,88:123–24
D&C,89:18–21
D&C,121:34–36
D&C,130:18–19
D&C,130:20–21
D&C,130:22–23
D&C,131:1–4
D&C,137:7–10
*/

using System;
using System.Collections.Generic;

public class ScriptureList
{


    private List<Reference> _allScriptures = new List<Reference>();
    private Random _random = new Random();

    public ScriptureList()
    {
        // === Old Testament ===
        _allScriptures.Add(new Reference("Moses", 1, 39, 0, ""));
        _allScriptures.Add(new Reference("Moses", 7, 18, 0, ""));
        _allScriptures.Add(new Reference("Abraham", 3, 22, 23, ""));
        _allScriptures.Add(new Reference("Genesis", 1, 26, 27, ""));
        _allScriptures.Add(new Reference("Genesis", 39, 9, 0, ""));
        _allScriptures.Add(new Reference("Exodus", 20, 3, 17, ""));
        _allScriptures.Add(new Reference("Exodus", 33, 11, 0, ""));
        _allScriptures.Add(new Reference("Leviticus", 19, 18, 0, ""));
        _allScriptures.Add(new Reference("Deuteronomy", 7, 3, 4, ""));
        _allScriptures.Add(new Reference("Joshua", 1, 8, 0, ""));
        _allScriptures.Add(new Reference("Joshua", 24, 15, 0, ""));
        _allScriptures.Add(new Reference("1 Samuel", 16, 7, 0, ""));
        _allScriptures.Add(new Reference("Job", 19, 25, 26, ""));
        _allScriptures.Add(new Reference("Psalm", 24, 3, 4, ""));
        _allScriptures.Add(new Reference("Proverbs", 3, 5, 6, ""));
        _allScriptures.Add(new Reference("Isaiah", 1, 18, 0, ""));
        _allScriptures.Add(new Reference("Isaiah", 29, 13, 14, ""));
        _allScriptures.Add(new Reference("Isaiah", 53, 3, 5, ""));
        _allScriptures.Add(new Reference("Isaiah", 55, 8, 9, ""));
        _allScriptures.Add(new Reference("Jeremiah", 16, 16, 0, ""));
        _allScriptures.Add(new Reference("Ezekiel", 37, 15, 17, ""));
        _allScriptures.Add(new Reference("Daniel", 2, 44, 45, ""));
        _allScriptures.Add(new Reference("Amos", 3, 7, 0, ""));
        _allScriptures.Add(new Reference("Malachi", 3, 8, 10, ""));
        _allScriptures.Add(new Reference("Malachi", 4, 5, 6, ""));

        // === New Testament ===
        _allScriptures.Add(new Reference("Matthew", 5, 14, 16, ""));
        _allScriptures.Add(new Reference("Matthew", 6, 24, 0, ""));
        _allScriptures.Add(new Reference("Matthew", 16, 15, 19, ""));
        _allScriptures.Add(new Reference("Matthew", 25, 40, 0, ""));
        _allScriptures.Add(new Reference("Luke", 24, 36, 39, ""));
        _allScriptures.Add(new Reference("John", 3, 5, 0, ""));
        _allScriptures.Add(new Reference("John", 7, 17, 0, ""));
        _allScriptures.Add(new Reference("John", 10, 16, 0, ""));
        _allScriptures.Add(new Reference("John", 14, 15, 0, ""));
        _allScriptures.Add(new Reference("John", 17, 3, 0, ""));
        _allScriptures.Add(new Reference("Acts", 7, 55, 56, ""));
        _allScriptures.Add(new Reference("Romans", 1, 16, 0, ""));
        _allScriptures.Add(new Reference("1 Corinthians", 10, 13, 0, ""));
        _allScriptures.Add(new Reference("1 Corinthians", 15, 20, 22, ""));
        _allScriptures.Add(new Reference("1 Corinthians", 15, 29, 0, ""));
        _allScriptures.Add(new Reference("1 Corinthians", 15, 40, 42, ""));
        _allScriptures.Add(new Reference("Ephesians", 4, 11, 14, ""));
        _allScriptures.Add(new Reference("2 Thessalonians", 2, 1, 3, ""));
        _allScriptures.Add(new Reference("2 Timothy", 3, 1, 5, ""));
        _allScriptures.Add(new Reference("2 Timothy", 3, 16, 17, ""));
        _allScriptures.Add(new Reference("Hebrews", 5, 4, 0, ""));
        _allScriptures.Add(new Reference("James", 1, 5, 6, ""));
        _allScriptures.Add(new Reference("James", 2, 17, 18, ""));
        _allScriptures.Add(new Reference("Revelation", 14, 6, 7, ""));
        _allScriptures.Add(new Reference("Revelation", 20, 12, 13, ""));

        // === Book of Mormon ===
        _allScriptures.Add(new Reference("1 Nephi", 3, 7, 0, ""));
        _allScriptures.Add(new Reference("1 Nephi", 19, 23, 0, ""));
        _allScriptures.Add(new Reference("2 Nephi", 2, 25, 0, ""));
        _allScriptures.Add(new Reference("2 Nephi", 2, 27, 0, ""));
        _allScriptures.Add(new Reference("2 Nephi", 9, 28, 29, ""));
        _allScriptures.Add(new Reference("2 Nephi", 28, 7, 9, ""));
        _allScriptures.Add(new Reference("2 Nephi", 32, 3, 0, ""));
        _allScriptures.Add(new Reference("2 Nephi", 32, 8, 9, ""));
        _allScriptures.Add(new Reference("Jacob", 2, 18, 19, ""));
        _allScriptures.Add(new Reference("Mosiah", 2, 17, 0, ""));
        _allScriptures.Add(new Reference("Mosiah", 3, 19, 0, ""));
        _allScriptures.Add(new Reference("Mosiah", 4, 30, 0, ""));
        _allScriptures.Add(new Reference("Alma", 32, 21, 0, ""));
        _allScriptures.Add(new Reference("Alma", 34, 32, 34, ""));
        _allScriptures.Add(new Reference("Alma", 37, 6, 7, ""));
        _allScriptures.Add(new Reference("Alma", 37, 35, 0, ""));
        _allScriptures.Add(new Reference("Alma", 41, 10, 0, ""));
        _allScriptures.Add(new Reference("Helaman", 5, 12, 0, ""));
        _allScriptures.Add(new Reference("3 Nephi", 11, 29, 0, ""));
        _allScriptures.Add(new Reference("3 Nephi", 27, 27, 0, ""));
        _allScriptures.Add(new Reference("Ether", 12, 6, 0, ""));
        _allScriptures.Add(new Reference("Ether", 12, 27, 0, ""));
        _allScriptures.Add(new Reference("Moroni", 7, 16, 17, ""));
        _allScriptures.Add(new Reference("Moroni", 7, 45, 0, ""));
        _allScriptures.Add(new Reference("Moroni", 10, 4, 5, ""));

        // === Doctrine and Covenants ===
        _allScriptures.Add(new Reference("Joseph Smith—History", 1, 15, 20, ""));
        _allScriptures.Add(new Reference("D&C", 1, 37, 38, ""));
        _allScriptures.Add(new Reference("D&C", 8, 2, 3, ""));
        _allScriptures.Add(new Reference("D&C", 10, 5, 0, ""));
        _allScriptures.Add(new Reference("D&C", 14, 7, 0, ""));
        _allScriptures.Add(new Reference("D&C", 18, 10, 16, ""));
        _allScriptures.Add(new Reference("D&C", 19, 16, 19, ""));
        _allScriptures.Add(new Reference("D&C", 25, 12, 0, ""));
        _allScriptures.Add(new Reference("D&C", 58, 26, 27, ""));
        _allScriptures.Add(new Reference("D&C", 58, 42, 43, ""));
        _allScriptures.Add(new Reference("D&C", 59, 9, 10, ""));
        _allScriptures.Add(new Reference("D&C", 64, 9, 11, ""));
        _allScriptures.Add(new Reference("D&C", 64, 23, 0, ""));
        _allScriptures.Add(new Reference("D&C", 76, 22, 24, ""));
        _allScriptures.Add(new Reference("D&C", 82, 3, 0, ""));
        _allScriptures.Add(new Reference("D&C", 82, 10, 0, ""));
        _allScriptures.Add(new Reference("D&C", 84, 33, 39, ""));
        _allScriptures.Add(new Reference("D&C", 88, 123, 124, ""));
        _allScriptures.Add(new Reference("D&C", 89, 18, 21, ""));
        _allScriptures.Add(new Reference("D&C", 121, 34, 36, ""));
        _allScriptures.Add(new Reference("D&C", 130, 18, 19, ""));
        _allScriptures.Add(new Reference("D&C", 130, 20, 21, ""));
        _allScriptures.Add(new Reference("D&C", 130, 22, 23, ""));
        _allScriptures.Add(new Reference("D&C", 131, 1, 4, ""));
        _allScriptures.Add(new Reference("D&C", 137, 7, 10, ""));
    }


    public void AddScripture(Reference reference)
    {
        _allScriptures.Add(reference);
    }

    public Reference GetRandomScripture()
    {
        int index = _random.Next(_allScriptures.Count);
        return _allScriptures[index];
    }

    public void DisplayAll()
    {
        foreach (Reference r in _allScriptures)
        {//this fixes the prevous code DON"T TOUCH IT AGAIN
            Console.WriteLine($"{r.GetBook()} {r.GetChapter()}:{r.GetStartVerse()}" +
            $"{(r.GetEndVerse() == 0 ? "" : "-" + r.GetEndVerse())}");
        }
    }
}