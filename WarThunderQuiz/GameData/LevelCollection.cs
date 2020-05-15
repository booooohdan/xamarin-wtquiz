using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;

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
            Context context = Application.Context;
            List<Level> levels = new List<Level>();
            Level level;
            levels.Clear();


            ///////////////////////////////////////////   Перша світова війна   ///////////////////////////////////////////
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();


            level = new Level();
            level.Number = 1;
            level.LevelName = "Annexation of Manchuria";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel1", 0);
            level.LevelTotalScore = 5;
            level.LevelUnlocked = true;
            level.Map = Resource.Drawable._JapanChinaMap;
            level.LeftFlag1 = Resource.Drawable._flagJapan;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagChina;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 2;
            level.LevelName = "Battle of Brunete";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel2", 0);
            level.LevelTotalScore = 5;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked2", false);
            level.Map = Resource.Drawable._SpainMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 3;
            level.LevelName = "Battle of Teruel";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel3", 0);
            level.LevelTotalScore = 10;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked3", false);
            level.Map = Resource.Drawable._SpainMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 4;
            level.LevelName = "Battle of the Ebro";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel4", 0);
            level.LevelTotalScore = 10;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked4", false);
            level.Map = Resource.Drawable._SpainMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 5;
            level.LevelName = "Battle of Lake Khasan";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel5", 0);
            level.LevelTotalScore = 10;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked5", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagJapan;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 6;
            level.LevelName = "Battle of Nanking";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel6", 0);
            level.LevelTotalScore = 10;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked6", false);
            level.Map = Resource.Drawable._JapanChinaMap;
            level.LeftFlag1 = Resource.Drawable._flagJapan;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagChina;
            level.RightFlag2 = Resource.Drawable._flagUSSR;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 7;
            level.LevelName = "Battles of Khalkhin Gol";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel7", 0);
            level.LevelTotalScore = 10;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked7", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagJapan;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);

            level = new Level();
            level.Number = 8;
            level.LevelName = "Battle of the Atlantic";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel8", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked8", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagFrance;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 9;
            level.LevelName = "Battle of Dunkirk";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel9", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked9", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagBritain;
            level.LeftFlag2 = Resource.Drawable._flagFrance;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 10;
            level.LevelName = "Battle of Britain";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel10", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked10", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagBritain;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._vehicleEmpty;
            levels.Add(level);


            level = new Level();
            level.Number = 11;
            level.LevelName = "Battle of Crete";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel11", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked11", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagBritain;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 12;
            level.LevelName = "Operation Barbarossa";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel12", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked12", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 13;
            level.LevelName = "Arctic convoys";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel13", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked13", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagUSA;
            level.LeftFlag3 = Resource.Drawable._flagBritain;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 14;
            level.LevelName = "Siege of Leningrad";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel14", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked14", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 15;
            level.LevelName = "Battle of Moscow";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel15", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked15", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 16;
            level.LevelName = "Attack on Pearl Harbor";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel16", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked16", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._vehicleEmpty;
            levels.Add(level);


            level = new Level();
            level.Number = 17;
            level.LevelName = "Second Battle of Kharkov";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel17", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked17", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 18;
            level.LevelName = "Battle of the Coral Sea";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel18", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked18", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 19;
            level.LevelName = "Battle of Midway";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel19", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked19", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 20;
            level.LevelName = "Battle of Stalingrad";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel20", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked20", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 21;
            level.LevelName = "Second Battle of El Alamein";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel21", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked21", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagBritain;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 22;
            level.LevelName = "Operation Torch";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel22", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked22", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 23;
            level.LevelName = "Battle of Kursk";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel23", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked23", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 24;
            level.LevelName = "Battle of Anzio";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel24", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked24", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagFrance;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 25;
            level.LevelName = "Battle of Monte Cassino";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel25", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked25", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagFrance;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagItaly;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 26;
            level.LevelName = "Battle of the Bulge";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel26", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked26", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagFrance;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 27;
            level.LevelName = "Battle of the Philippine Sea";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel27", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked27", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 28;
            level.LevelName = "D-Day";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel28", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked28", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagFrance;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);
            
            
            
            level = new Level();
            level.Number = 29;
            level.LevelName = "Battle of Leyte Gulf";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel29", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked29", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 30;
            level.LevelName = "Battle of Luzon";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel30", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked30", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 31;
            level.LevelName = "Battle of Berlin";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel31", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked31", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagGermany;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 32;
            level.LevelName = "Battle of Iwo Jima";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel32", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked32", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 33;
            level.LevelName = "Battle of Okinawa";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel33", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked33", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._ship;
            levels.Add(level);


            level = new Level();
            level.Number = 34;
            level.LevelName = "Soviet Japanese War";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel34", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked34", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 35;
            level.LevelName = "Battle of Balikpapan";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel35", 0);
            level.LevelTotalScore = 15;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked35", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSSR;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagJapan;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 36;
            level.LevelName = "Korean War";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel36", 0);
            level.LevelTotalScore = 20;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked36", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagBritain;
            level.LeftFlag3 = Resource.Drawable._flagFrance;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 37;
            level.LevelName = "Vietnam War";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel37", 0);
            level.LevelTotalScore = 20;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked37", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 38;
            level.LevelName = "Laotian Civil War";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel38", 0);
            level.LevelTotalScore = 20;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked38", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 39;
            level.LevelName = "Cambodian Civil War";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel39", 0);
            level.LevelTotalScore = 20;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked39", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            level = new Level();
            level.Number = 40;
            level.LevelName = "Yom Kippur War";
            level.LevelScoreEarned = prefs.GetInt("SScoreLevel40", 0);
            level.LevelTotalScore = 20;
            level.LevelUnlocked = prefs.GetBoolean("LevelUnlocked40", false);
            level.Map = Resource.Drawable._HalhinGolMap;
            level.LeftFlag1 = Resource.Drawable._flagUSA;
            level.LeftFlag2 = Resource.Drawable._flagEmpty;
            level.LeftFlag3 = Resource.Drawable._flagEmpty;
            level.RightFlag1 = Resource.Drawable._flagUSSR;
            level.RightFlag2 = Resource.Drawable._flagEmpty;
            level.RightFlag3 = Resource.Drawable._flagEmpty;
            level.VehicleType1 = Resource.Drawable._plane;
            level.VehicleType2 = Resource.Drawable._tank;
            levels.Add(level);


            return levels;
        }
    }
}