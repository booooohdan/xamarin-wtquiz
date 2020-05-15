﻿using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Preferences;

namespace WarThunderQuiz.GameData
{
    class Level
    {
        public int Number { get; set; }

        public string LevelName { get; set; }
        public int LevelScoreEarned { get; set; }
        public int LevelTotalScore { get; set; }
        public bool LevelUnlocked { get; set; }

        public int Map { get; set; }
        public int LeftFlag1 { get; set; }
        public int LeftFlag2 { get; set; }
        public int LeftFlag3 { get; set; }
        public int RightFlag1 { get; set; }
        public int RightFlag2 { get; set; }
        public int RightFlag3 { get; set; }
        public int VehicleType1 { get; set; }
        public int VehicleType2 { get; set; }
    }

    class LevelCollection
    {

        public static List<Level> GetLevels()
        {
            var context = Application.Context;
            var levels = new List<Level>();
            Level level;

            ///////////////////////////////////////////   Перша світова війна   ///////////////////////////////////////////
            var prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            var editor = prefs.Edit();

            level = new Level
            {
                Number = 1,
                LevelName = "Annexation of Manchuria",
                LevelScoreEarned = prefs.GetInt("SScoreLevel1", 0),
                LevelTotalScore = 5,
                LevelUnlocked = true,
                Map = Resource.Drawable._mapHalginGol,
                LeftFlag1 = Resource.Drawable._flagJapan,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagChina,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 2,
                LevelName = "Battle of Brunete",
                LevelScoreEarned = prefs.GetInt("SScoreLevel2", 0),
                LevelTotalScore = 5,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked2", false),
                Map = Resource.Drawable._mapHurgen,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 3,
                LevelName = "Battle of Teruel",
                LevelScoreEarned = prefs.GetInt("SScoreLevel3", 0),
                LevelTotalScore = 10,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked3", false),
                Map = Resource.Drawable._mapHurgen,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 4,
                LevelName = "Battle of the Ebro",
                LevelScoreEarned = prefs.GetInt("SScoreLevel4", 0),
                LevelTotalScore = 10,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked4", false),
                Map = Resource.Drawable._mapHurgen,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 5,
                LevelName = "Battle of Lake Khasan",
                LevelScoreEarned = prefs.GetInt("SScoreLevel5", 0),
                LevelTotalScore = 10,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked5", false),
                Map = Resource.Drawable._mapHalginGol,
                LeftFlag1 = Resource.Drawable._flagJapan,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 6,
                LevelName = "Battle of Nanking",
                LevelScoreEarned = prefs.GetInt("SScoreLevel6", 0),
                LevelTotalScore = 10,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked6", false),
                Map = Resource.Drawable._mapKonihina,
                LeftFlag1 = Resource.Drawable._flagJapan,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagChina,
                RightFlag2 = Resource.Drawable._flagUSSR,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 7,
                LevelName = "Battles of Khalkhin Gol",
                LevelScoreEarned = prefs.GetInt("SScoreLevel7", 0),
                LevelTotalScore = 10,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked7", false),
                Map = Resource.Drawable._mapHalginGol,
                LeftFlag1 = Resource.Drawable._flagJapan,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            level = new Level
            {
                Number = 8,
                LevelName = "Battle of the Atlantic",
                LevelScoreEarned = prefs.GetInt("SScoreLevel8", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked8", false),
                Map = Resource.Drawable._mapAtlantic,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagFrance,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 9,
                LevelName = "Battle of Dunkirk",
                LevelScoreEarned = prefs.GetInt("SScoreLevel9", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked9", false),
                Map = Resource.Drawable._mapNormandyAvia,
                LeftFlag1 = Resource.Drawable._flagBritain,
                LeftFlag2 = Resource.Drawable._flagFrance,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 10,
                LevelName = "Battle of Britain",
                LevelScoreEarned = prefs.GetInt("SScoreLevel10", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked10", false),
                Map = Resource.Drawable._mapBritain,
                LeftFlag1 = Resource.Drawable._flagBritain,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._vehicleEmpty
            };
            levels.Add(level);


            level = new Level
            {
                Number = 11,
                LevelName = "Battle of Crete",
                LevelScoreEarned = prefs.GetInt("SScoreLevel11", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked11", false),
                Map = Resource.Drawable._mapCreete,
                LeftFlag1 = Resource.Drawable._flagBritain,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 12,
                LevelName = "Operation Barbarossa",
                LevelScoreEarned = prefs.GetInt("SScoreLevel12", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked12", false),
                Map = Resource.Drawable._mapMozdok,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 13,
                LevelName = "Arctic convoys",
                LevelScoreEarned = prefs.GetInt("SScoreLevel13", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked13", false),
                Map = Resource.Drawable._mapArcticConwoy,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagUSA,
                LeftFlag3 = Resource.Drawable._flagBritain,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 14,
                LevelName = "Siege of Leningrad",
                LevelScoreEarned = prefs.GetInt("SScoreLevel14", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked14", false),
                Map = Resource.Drawable._mapSmolensk,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 15,
                LevelName = "Battle of Moscow",
                LevelScoreEarned = prefs.GetInt("SScoreLevel15", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked15", false),
                Map = Resource.Drawable._mapEuropeanPrvince,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 16,
                LevelName = "Attack on Pearl Harbor",
                LevelScoreEarned = prefs.GetInt("SScoreLevel16", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked16", false),
                Map = Resource.Drawable._mapHokkaido,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._vehicleEmpty
            };
            levels.Add(level);


            level = new Level
            {
                Number = 17,
                LevelName = "Second Battle of Kharkov",
                LevelScoreEarned = prefs.GetInt("SScoreLevel17", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked17", false),
                Map = Resource.Drawable._mapAbandonedFactory,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 18,
                LevelName = "Battle of the Coral Sea",
                LevelScoreEarned = prefs.GetInt("SScoreLevel18", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked18", false),
                Map = Resource.Drawable._mapCoralSea,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 19,
                LevelName = "Battle of Midway",
                LevelScoreEarned = prefs.GetInt("SScoreLevel19", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked19", false),
                Map = Resource.Drawable._mapHonolulu,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 20,
                LevelName = "Battle of Stalingrad",
                LevelScoreEarned = prefs.GetInt("SScoreLevel20", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked20", false),
                Map = Resource.Drawable._mapStalingrad,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 21,
                LevelName = "Second Battle of El Alamein",
                LevelScoreEarned = prefs.GetInt("SScoreLevel21", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked21", false),
                Map = Resource.Drawable._mapElAlamein,
                LeftFlag1 = Resource.Drawable._flagBritain,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 22,
                LevelName = "Operation Torch",
                LevelScoreEarned = prefs.GetInt("SScoreLevel22", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked22", false),
                Map = Resource.Drawable._mapArden,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 23,
                LevelName = "Battle of Kursk",
                LevelScoreEarned = prefs.GetInt("SScoreLevel23", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked23", false),
                Map = Resource.Drawable._mapKursk,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 24,
                LevelName = "Battle of Anzio",
                LevelScoreEarned = prefs.GetInt("SScoreLevel24", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked24", false),
                Map = Resource.Drawable._mapFulda,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagFrance,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 25,
                LevelName = "Battle of Monte Cassino",
                LevelScoreEarned = prefs.GetInt("SScoreLevel25", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked25", false),
                Map = Resource.Drawable._mapMajinotLine,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagFrance,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagItaly,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 26,
                LevelName = "Battle of the Bulge",
                LevelScoreEarned = prefs.GetInt("SScoreLevel26", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked26", false),
                Map = Resource.Drawable._mapAviaBerlin,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagFrance,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 27,
                LevelName = "Battle of the Philippine Sea",
                LevelScoreEarned = prefs.GetInt("SScoreLevel27", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked27", false),
                Map = Resource.Drawable._mapPhilipines,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 28,
                LevelName = "D-Day",
                LevelScoreEarned = prefs.GetInt("SScoreLevel28", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked28", false),
                Map = Resource.Drawable._mapNormandyAvia,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagFrance,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);



            level = new Level
            {
                Number = 29,
                LevelName = "Battle of Leyte Gulf",
                LevelScoreEarned = prefs.GetInt("SScoreLevel29", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked29", false),
                Map = Resource.Drawable._mapLeyteGuf,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 30,
                LevelName = "Battle of Luzon",
                LevelScoreEarned = prefs.GetInt("SScoreLevel30", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked30", false),
                Map = Resource.Drawable._mapLuzon,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 31,
                LevelName = "Battle of Berlin",
                LevelScoreEarned = prefs.GetInt("SScoreLevel31", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked31", false),
                Map = Resource.Drawable._mapBerlin,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 32,
                LevelName = "Battle of Iwo Jima",
                LevelScoreEarned = prefs.GetInt("SScoreLevel32", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked32", false),
                Map = Resource.Drawable._mapIvojima,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 33,
                LevelName = "Battle of Okinawa",
                LevelScoreEarned = prefs.GetInt("SScoreLevel33", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked33", false),
                Map = Resource.Drawable._mapJapan,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._ship
            };
            levels.Add(level);


            level = new Level
            {
                Number = 34,
                LevelName = "Soviet Japanese War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel34", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked34", false),
                Map = Resource.Drawable._mapWhiteRock,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 35,
                LevelName = "Battle of Balikpapan",
                LevelScoreEarned = prefs.GetInt("SScoreLevel35", 0),
                LevelTotalScore = 15,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked35", false),
                Map = Resource.Drawable._mapJapan,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 36,
                LevelName = "Korean War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel36", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked36", false),
                Map = Resource.Drawable._mapKorea,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagFrance,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 37,
                LevelName = "Vietnam War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel37", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked37", false),
                Map = Resource.Drawable._mapVietnam,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 38,
                LevelName = "Laotian Civil War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel38", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked38", false),
                Map = Resource.Drawable._mapSeaTerminal,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 39,
                LevelName = "Cambodian Civil War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel39", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked39", false),
                Map = Resource.Drawable._mapAfganistan,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 40,
                LevelName = "Yom Kippur War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel40", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked40", false),
                Map = Resource.Drawable._map38paralel,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            return levels;
        }



        public static List<Level> GetTrainingLevels()
        {
            Context context = Application.Context;
            List<Level> levels = new List<Level>();
            Level level;
            levels.Clear();

            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();


            level = new Level
            {
                Number = 101,
                LevelName = "Only USA",
                LevelScoreEarned = prefs.GetInt("SScoreLevel101", 0),
                LevelTotalScore = 20,
                LevelUnlocked = true,
                Map = Resource.Drawable._mapAmericanDesert,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSA,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 102,
                LevelName = "Only Germany",
                LevelScoreEarned = prefs.GetInt("SScoreLevel102", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked102", false),
                Map = Resource.Drawable._mapBerlin,
                LeftFlag1 = Resource.Drawable._flagGermany,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 103,
                LevelName = "Only USSR",
                LevelScoreEarned = prefs.GetInt("SScoreLevel103", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked103", false),
                Map = Resource.Drawable._mapKursk,
                LeftFlag1 = Resource.Drawable._flagUSSR,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 104,
                LevelName = "Only UK",
                LevelScoreEarned = prefs.GetInt("SScoreLevel104", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked104", false),
                Map = Resource.Drawable._mapBritain,
                LeftFlag1 = Resource.Drawable._flagBritain,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagBritain,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 105,
                LevelName = "Only Japan",
                LevelScoreEarned = prefs.GetInt("SScoreLevel105", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked105", false),
                Map = Resource.Drawable._mapJapan,
                LeftFlag1 = Resource.Drawable._flagJapan,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagJapan,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 106,
                LevelName = "Only Italy",
                LevelScoreEarned = prefs.GetInt("SScoreLevel106", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked106", false),
                Map = Resource.Drawable._mapItalia,
                LeftFlag1 = Resource.Drawable._flagItaly,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagItaly,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 107,
                LevelName = "Only France",
                LevelScoreEarned = prefs.GetInt("SScoreLevel107", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked107", false),
                Map = Resource.Drawable._mapMajinotLine,
                LeftFlag1 = Resource.Drawable._flagFrance,
                LeftFlag2 = Resource.Drawable._flagEmpty,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagFrance,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 108,
                LevelName = "Only Aviation",
                LevelScoreEarned = prefs.GetInt("SScoreLevel108", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked108", false),
                Map = Resource.Drawable._mapLadoga,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagGermany,
                LeftFlag3 = Resource.Drawable._flagUSSR,
                RightFlag1 = Resource.Drawable._flagBritain,
                RightFlag2 = Resource.Drawable._flagJapan,
                RightFlag3 = Resource.Drawable._flagItaly,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._vehicleEmpty
            };
            levels.Add(level);


            level = new Level
            {
                Number = 109,
                LevelName = "Only Ground Forces",
                LevelScoreEarned = prefs.GetInt("SScoreLevel109", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked109", false),
                Map = Resource.Drawable._mapAshRiver,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagGermany,
                LeftFlag3 = Resource.Drawable._flagUSSR,
                RightFlag1 = Resource.Drawable._flagBritain,
                RightFlag2 = Resource.Drawable._flagJapan,
                RightFlag3 = Resource.Drawable._flagItaly,
                VehicleType1 = Resource.Drawable._tank,
                VehicleType2 = Resource.Drawable._vehicleEmpty
            };
            levels.Add(level);


            level = new Level
            {
                Number = 110,
                LevelName = "Only Naval Forces",
                LevelScoreEarned = prefs.GetInt("SScoreLevel110", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked110", false),
                Map = Resource.Drawable._mapCoralSea,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagGermany,
                LeftFlag3 = Resource.Drawable._flagUSSR,
                RightFlag1 = Resource.Drawable._flagBritain,
                RightFlag2 = Resource.Drawable._flagJapan,
                RightFlag3 = Resource.Drawable._flagItaly,
                VehicleType1 = Resource.Drawable._ship,
                VehicleType2 = Resource.Drawable._vehicleEmpty
            };
            levels.Add(level);


            level = new Level
            {
                Number = 111,
                LevelName = "Before WWII",
                LevelScoreEarned = prefs.GetInt("SScoreLevel111", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked111", false),
                Map = Resource.Drawable._mapSmolensk,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagGermany,
                LeftFlag3 = Resource.Drawable._flagUSSR,
                RightFlag1 = Resource.Drawable._flagBritain,
                RightFlag2 = Resource.Drawable._flagJapan,
                RightFlag3 = Resource.Drawable._flagItaly,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 112,
                LevelName = "WWII",
                LevelScoreEarned = prefs.GetInt("SScoreLevel112", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked112", false),
                Map = Resource.Drawable._mapBerlin,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagUSSR,
                RightFlag1 = Resource.Drawable._flagGermany,
                RightFlag2 = Resource.Drawable._flagJapan,
                RightFlag3 = Resource.Drawable._flagItaly,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);


            level = new Level
            {
                Number = 113,
                LevelName = "Cold War",
                LevelScoreEarned = prefs.GetInt("SScoreLevel113", 0),
                LevelTotalScore = 20,
                LevelUnlocked = prefs.GetBoolean("LevelUnlocked113", false),
                Map = Resource.Drawable._mapSeaTerminal,
                LeftFlag1 = Resource.Drawable._flagUSA,
                LeftFlag2 = Resource.Drawable._flagBritain,
                LeftFlag3 = Resource.Drawable._flagEmpty,
                RightFlag1 = Resource.Drawable._flagUSSR,
                RightFlag2 = Resource.Drawable._flagEmpty,
                RightFlag3 = Resource.Drawable._flagEmpty,
                VehicleType1 = Resource.Drawable._plane,
                VehicleType2 = Resource.Drawable._tank
            };
            levels.Add(level);

            return levels;
        }
    }
}