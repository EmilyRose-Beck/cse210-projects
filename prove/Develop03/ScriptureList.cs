using System;
using System.Collections.Generic;

    public class ScriptureList
        {
        private List<Reference> _allScriptures = new List<Reference>();
        private Random _random = new Random();

    public ScriptureList()
    {
        // ==============================================================
        //                      OLD TESTAMENT
        // ==============================================================

        // Moses 1:39 — God's work and glory.
        _allScriptures.Add(new Reference("Moses", 1, 39, 0, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man"));
        // Moses 7:18 — The people of Zion are of one heart and one mind.
        _allScriptures.Add(new Reference("Moses", 7, 18, 0, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them"));
        // Abraham 3:22–23 — The noble and great ones in the pre-earth life.
        _allScriptures.Add(new Reference("Abraham", 3, 22, 23, "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born."));
        // Genesis 1:26–27 — God creates man in His image.
        _allScriptures.Add(new Reference("Genesis", 1, 26, 27, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them."));
        // Genesis 39:9 — Joseph resists temptation.
        _allScriptures.Add(new Reference("Genesis", 39, 9, 0, "Joseph resists temptation."));
        // Exodus 20:3–17 — The Ten Commandments.
        _allScriptures.Add(new Reference("Exodus", 20, 3, 17, "he Ten Commandments."));
        // Exodus 33:11 — The Lord speaks to Moses face to face.
        _allScriptures.Add(new Reference("Exodus", 33, 11, 0, "The Lord speaks to Moses face to face."));
        // Leviticus 19:18 — Love thy neighbour as thyself.
        _allScriptures.Add(new Reference("Leviticus", 19, 18, 0, "Love thy neighbour as thyself."));
        // Deuteronomy 7:3–4 — Counsel against intermarriage with idolaters.
        _allScriptures.Add(new Reference("Deuteronomy", 7, 3, 4, "Counsel against intermarriage with idolaters."));
        // Joshua 1:8 — Meditate on the law day and night.
        _allScriptures.Add(new Reference("Joshua", 1, 8, 0, "Meditate on the law day and night."));
        // Joshua 24:15 — Choose whom ye will serve.
        _allScriptures.Add(new Reference("Joshua", 24, 15, 0, "Choose whom ye will serve."));
        // 1 Samuel 16:7 — The Lord looks on the heart.
        _allScriptures.Add(new Reference("1 Samuel", 16, 7, 0, "The Lord looks on the heart."));
        // Job 19:25–26 — Job’s testimony of the Redeemer.
        _allScriptures.Add(new Reference("Job", 19, 25, 26, "Job’s testimony of the Redeemer."));
        // Psalm 24:3–4 — Who shall ascend the hill of the Lord?
        _allScriptures.Add(new Reference("Psalm", 24, 3, 4, "Who shall ascend the hill of the Lord?"));
        // Proverbs 3:5–6 — Trust in the Lord with all thine heart.
        _allScriptures.Add(new Reference("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart."));
        // Isaiah 1:18 — Though your sins be as scarlet, they shall be white as snow.
        _allScriptures.Add(new Reference("Isaiah", 1, 18, 0, "Though your sins be as scarlet, they shall be white as snow."));
        // Isaiah 29:13–14 — A marvelous work and a wonder.
        _allScriptures.Add(new Reference("Isaiah", 29, 13, 14, "A marvelous work and a wonder."));
        // Isaiah 53:3–5 — The suffering servant prophecy.
        _allScriptures.Add(new Reference("Isaiah", 53, 3, 5, "The suffering servant prophecy."));
        // Isaiah 55:8–9 — My thoughts are not your thoughts.
        _allScriptures.Add(new Reference("Isaiah", 55, 8, 9, "My thoughts are not your thoughts."));
        // Jeremiah 16:16 — The Lord sends fishers and hunters.
        _allScriptures.Add(new Reference("Jeremiah", 16, 16, 0, "The Lord sends fishers and hunters."));
        // Ezekiel 37:15–17 — The two sticks become one.
        _allScriptures.Add(new Reference("Ezekiel", 37, 15, 17, "The two sticks become one."));
        // Daniel 2:44–45 — The kingdom of God will stand forever.
        _allScriptures.Add(new Reference("Daniel", 2, 44, 45, "The kingdom of God will stand forever."));
        // Amos 3:7 — The Lord reveals secrets to His prophets.
        _allScriptures.Add(new Reference("Amos", 3, 7, 0, "The Lord reveals secrets to His prophets."));
        // Malachi 3:8–10 — Bring all tithes into the storehouse.
        _allScriptures.Add(new Reference("Malachi", 3, 8, 10, "Bring all tithes into the storehouse."));
        // Malachi 4:5–6 — Elijah will return before the great day.
        _allScriptures.Add(new Reference("Malachi", 4, 5, 6, "Elijah will return before the great day."));

        // ==============================================================
        //                      NEW TESTAMENT
        // ==============================================================

        // Matthew 5:14–16 — Ye are the light of the world.
        _allScriptures.Add(new Reference("Matthew", 5, 14, 16, "Ye are the light of the world."));
        // Matthew 6:24 — No man can serve two masters.
        _allScriptures.Add(new Reference("Matthew", 6, 24, 0, "No man can serve two masters."));
        // Matthew 16:15–19 — Peter’s confession and the keys.
        _allScriptures.Add(new Reference("Matthew", 16, 15, 19, "Peter’s confession and the keys."));
        // Matthew 25:40 — Inasmuch as ye have done it unto one of the least of these.
        _allScriptures.Add(new Reference("Matthew", 25, 40, 0, "Inasmuch as ye have done it unto one of the least of these."));
        // Luke 24:36–39 — The resurrected Christ appears to His disciples.
        _allScriptures.Add(new Reference("Luke", 24, 36, 39, "The resurrected Christ appears to His disciples."));
        // John 3:5 — Born of water and of the Spirit.
        _allScriptures.Add(new Reference("John", 3, 5, 0, "Born of water and of the Spirit."));
        // John 7:17 — If any man will do His will, he shall know the doctrine.
        _allScriptures.Add(new Reference("John", 7, 17, 0, "f any man will do His will, he shall know the doctrine."));
        // John 10:16 — Other sheep not of this fold.
        _allScriptures.Add(new Reference("John", 10, 16, 0, "Other sheep not of this fold."));
        // John 14:15 — If ye love me, keep my commandments.
        _allScriptures.Add(new Reference("John", 14, 15, 0, "If ye love me, keep my commandments"));
        // John 17:3 — Eternal life is to know God and Jesus Christ.
        _allScriptures.Add(new Reference("John", 17, 3, 0, "Eternal life is to know God and Jesus Christ."));
        // Acts 7:55–56 — Stephen sees Jesus on the right hand of God.
        _allScriptures.Add(new Reference("Acts", 7, 55, 56, "Stephen sees Jesus on the right hand of God."));
        // Romans 1:16 — I am not ashamed of the gospel of Christ.
        _allScriptures.Add(new Reference("Romans", 1, 16, 0, "I am not ashamed of the gospel of Christ."));
        // 1 Corinthians 10:13 — God provides a way to escape temptation.
        _allScriptures.Add(new Reference("1 Corinthians", 10, 13, 0, "God provides a way to escape temptation."));
        // 1 Corinthians 15:20–22 — Christ’s resurrection as the firstfruits.
        _allScriptures.Add(new Reference("1 Corinthians", 15, 20, 22, "Christ’s resurrection as the firstfruits."));
        // 1 Corinthians 15:29 — Baptism for the dead.
        _allScriptures.Add(new Reference("1 Corinthians", 15, 29, 0, "aptism for the dead."));
        // 1 Corinthians 15:40–42 — Celestial, terrestrial, and telestial bodies.
        _allScriptures.Add(new Reference("1 Corinthians", 15, 40, 42, "Celestial, terrestrial, and telestial bodies."));
        // Ephesians 4:11–14 — Apostles and prophets perfect the saints.
        _allScriptures.Add(new Reference("Ephesians", 4, 11, 14, "Apostles and prophets perfect the saints."));
        // 2 Thessalonians 2:1–3 — Apostasy before Christ’s coming.
        _allScriptures.Add(new Reference("2 Thessalonians", 2, 1, 3, "Apostasy before Christ’s coming."));
        // 2 Timothy 3:1–5 — Perilous times in the last days.
        _allScriptures.Add(new Reference("2 Timothy", 3, 1, 5, "Perilous times in the last days."));
        // 2 Timothy 3:16–17 — All scripture is inspired of God.
        _allScriptures.Add(new Reference("2 Timothy", 3, 16, 17, "All scripture is inspired of God."));
        // Hebrews 5:4 — No man takes this honor unto himself.
        _allScriptures.Add(new Reference("Hebrews", 5, 4, 0, "No man takes this honor unto himself."));
        // James 1:5–6 — Ask of God for wisdom.
        _allScriptures.Add(new Reference("James", 1, 5, 6, "Ask of God for wisdom."));
        // James 2:17–18 — Faith without works is dead.
        _allScriptures.Add(new Reference("James", 2, 17, 18, "Faith without works is dead."));
        // Revelation 14:6–7 — The angel proclaims the everlasting gospel.
        _allScriptures.Add(new Reference("Revelation", 14, 6, 7, "The angel proclaims the everlasting gospel."));
        // Revelation 20:12–13 — The dead are judged according to their works.
        _allScriptures.Add(new Reference("Revelation", 20, 12, 13, "The dead are judged according to their works."));

        // ==============================================================
        //                      BOOK OF MORMON
        // ==============================================================

        // 1 Nephi 3:7 — The Lord gives no commandment without a way.
        _allScriptures.Add(new Reference("1 Nephi", 3, 7, 0, "The Lord gives no commandment without a way."));
        // 1 Nephi 19:23 — Liken the scriptures unto ourselves.
        _allScriptures.Add(new Reference("1 Nephi", 19, 23, 0, "Liken the scriptures unto ourselves."));
        // 2 Nephi 2:25 — Adam fell that men might have joy.
        _allScriptures.Add(new Reference("2 Nephi", 2, 25, 0, "Adam fell that men might have joy."));
        // 2 Nephi 2:27 — Men are free to choose liberty or captivity.
        _allScriptures.Add(new Reference("2 Nephi", 2, 27, 0, "Men are free to choose liberty or captivity."));
        // 2 Nephi 9:28–29 — Woe unto the learned who think they are wise.
        _allScriptures.Add(new Reference("2 Nephi", 9, 28, 29, "Woe unto the learned who think they are wise."));
        // 2 Nephi 28:7–9 — Woe unto those at ease in Zion.
        _allScriptures.Add(new Reference("2 Nephi", 28, 7, 9, " Woe unto those at ease in Zion."));
        // 2 Nephi 32:3 — Feast upon the words of Christ.
        _allScriptures.Add(new Reference("2 Nephi", 32, 3, 0, "Feast upon the words of Christ."));
        // 2 Nephi 32:8–9 — Pray always.
        _allScriptures.Add(new Reference("2 Nephi", 32, 8, 9, "Pray always."));
        // Jacob 2:18–19 — Seek first the kingdom of God.
        _allScriptures.Add(new Reference("Jacob", 2, 18, 19, "Seek first the kingdom of God."));
        // Mosiah 2:17 — Service of your fellow beings is service to God.
        _allScriptures.Add(new Reference("Mosiah", 2, 17, 0, "Service of your fellow beings is service to God."));
        // Mosiah 3:19 — The natural man is an enemy to God.
        _allScriptures.Add(new Reference("Mosiah", 3, 19, 0, "The natural man is an enemy to God."));
        // Mosiah 4:30 — Watch your thoughts, words, and deeds.
        _allScriptures.Add(new Reference("Mosiah", 4, 30, 0, "Watch your thoughts, words, and deeds."));
        // Alma 32:21 — Faith is things hoped for, not seen.
        _allScriptures.Add(new Reference("Alma", 32, 21, 0, "Faith is things hoped for, not seen."));
        // Alma 34:32–34 — This life is the time to prepare to meet God.
        _allScriptures.Add(new Reference("Alma", 34, 32, 34, "This life is the time to prepare to meet God."));
        // Alma 37:6–7 — By small and simple things are great things brought to pass.
        _allScriptures.Add(new Reference("Alma", 37, 6, 7, "By small and simple things are great things brought to pass."));
        // Alma 37:35 — Remember the words of truth.
        _allScriptures.Add(new Reference("Alma", 37, 35, 0, "Remember the words of truth."));
        // Alma 41:10 — Wickedness never was happiness.
        _allScriptures.Add(new Reference("Alma", 41, 10, 0, "Wickedness never was happiness."));
        // Helaman 5:12 — Build your foundation on Christ.
        _allScriptures.Add(new Reference("Helaman", 5, 12, 0, "Build your foundation on Christ."));
        // 3 Nephi 11:29 — The spirit of contention is not of Christ.
        _allScriptures.Add(new Reference("3 Nephi", 11, 29, 0, "The spirit of contention is not of Christ."));
        // 3 Nephi 27:27 — Be even as I am.
        _allScriptures.Add(new Reference("3 Nephi", 27, 27, 0, "Be even as I am."));
        // Ether 12:6 — Faith is things hoped for and not seen.
        _allScriptures.Add(new Reference("Ether", 12, 6, 0, "Faith is things hoped for and not seen."));
        // Ether 12:27 — Weak things become strong.
        _allScriptures.Add(new Reference("Ether", 12, 27, 0, "Weak things become strong."));
        // Moroni 7:16–17 — The Spirit of Christ helps judge good from evil.
        _allScriptures.Add(new Reference("Moroni", 7, 16, 17, "The Spirit of Christ helps judge good from evil."));
        // Moroni 7:45 — Charity suffereth long and is kind.
        _allScriptures.Add(new Reference("Moroni", 7, 45, 0, "Charity suffereth long and is kind."));
        // Moroni 10:4–5 — Pray to know the truth by the Holy Ghost.
        _allScriptures.Add(new Reference("Moroni", 10, 4, 5, "Pray to know the truth by the Holy Ghost."));

        // ==============================================================
        //                  DOCTRINE AND COVENANTS / JSH
        // ==============================================================

        // Joseph Smith—History 1:15–20 — The First Vision.
        _allScriptures.Add(new Reference("Joseph Smith—History", 1, 15, 20, "The First Vision."));
        // D&C 1:37–38 — The word of the Lord shall be fulfilled.
        _allScriptures.Add(new Reference("D&C", 1, 37, 38, "The word of the Lord shall be fulfilled."));
        // D&C 8:2–3 — The Spirit of revelation.
        _allScriptures.Add(new Reference("D&C", 8, 2, 3, "The Spirit of revelation."));
        // D&C 10:5 — Pray always, that ye may conquer Satan.
        _allScriptures.Add(new Reference("D&C", 10, 5, 0, "Pray always, that ye may conquer Satan."));
        // D&C 14:7 — Eternal life is the greatest gift.
        _allScriptures.Add(new Reference("D&C", 14, 7, 0, "Eternal life is the greatest gift."));
        // D&C 18:10–16 — The worth of souls is great.
        _allScriptures.Add(new Reference("D&C", 18, 10, 16, "The worth of souls is great."));
        // D&C 19:16–19 — Christ’s suffering for mankind.
        _allScriptures.Add(new Reference("D&C", 19, 16, 19, "Christ’s suffering for mankind."));
        // D&C 25:12 — The song of the righteous is a prayer unto me.
        _allScriptures.Add(new Reference("D&C", 25, 12, 0, "The song of the righteous is a prayer unto me."));
        // D&C 58:26–27 — Be anxiously engaged in a good cause.
        _allScriptures.Add(new Reference("D&C", 58, 26, 27, "Be anxiously engaged in a good cause."));
        // D&C 58:42–43 — Repentance brings forgiveness.
        _allScriptures.Add(new Reference("D&C", 58, 42, 43, "Repentance brings forgiveness."));
        // D&C 59:9–10 — Keep the Sabbath day holy.
        _allScriptures.Add(new Reference("D&C", 59, 9, 10, "Keep the Sabbath day holy."));
        // D&C 64:9–11 — Forgive all men.
        _allScriptures.Add(new Reference("D&C", 64, 9, 11, "Forgive all men."));
        // D&C 64:23 — Pay tithing and keep commandments.
        _allScriptures.Add(new Reference("D&C", 64, 23, 0, "Pay tithing and keep commandments."));
        // D&C 76:22–24 — Jesus Christ lives and is the Savior.
        _allScriptures.Add(new Reference("D&C", 76, 22, 24, "Jesus Christ lives and is the Savior."));
        // D&C 82:3 — Greater obedience brings greater blessings.
        _allScriptures.Add(new Reference("D&C", 82, 3, 0, "Greater obedience brings greater blessings."));
        // D&C 82:10 — The Lord is bound when we do what He says.
        _allScriptures.Add(new Reference("D&C", 82, 10, 0, "The Lord is bound when we do what He says."));
        // D&C 84:33–39 — The priesthood is the power of God.
        _allScriptures.Add(new Reference("D&C", 84, 33, 39, "The priesthood is the power of God."));
        // D&C 88:123–124 — Teach one another.
        _allScriptures.Add(new Reference("D&C", 88, 123, 124, "Teach one another."));
        // D&C 89:18–21 — The Word of Wisdom.
        _allScriptures.Add(new Reference("D&C", 89, 18, 21, "The Word of Wisdom."));
        // D&C 121:34–36 — Power or authority by persuasion, long-suffering, and love.
        _allScriptures.Add(new Reference("D&C", 121, 34, 36, "Power or authority by persuasion, long-suffering, and love."));
        // D&C 130:18–19 — Knowledge and intelligence are eternal.
        _allScriptures.Add(new Reference("D&C", 130, 18, 19, "Knowledge and intelligence are eternal."));
        // D&C 130:20–21 — There is a law decreed in heaven.

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
