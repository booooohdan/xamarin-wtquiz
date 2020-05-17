using System.Linq;
using Android.Content;
using Android.Preferences;
using Android.Views;
using WarThunderQuiz.GameData;

namespace WarThunderQuiz
{
    public partial class ClassicGameMode
    {
        private void LevelDataForUnlocked()
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();
            lifeCount = 100;

            switch (ChoosedGameModeIndex)
            {
                case 1:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked2", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel1", correctAnswer); }
                    editor.Apply();
                    break;

                case 2:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked3", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel2", correctAnswer); }
                    editor.Apply();
                    break;

                case 3:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked4", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel3", correctAnswer); }
                    editor.Apply();
                    break;

                case 4:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked5", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel4", correctAnswer); }
                    editor.Apply();
                    break;

                case 5:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked6", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel5", correctAnswer); }
                    editor.Apply();
                    break;

                case 6:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked7", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel6", correctAnswer); }
                    editor.Apply();
                    break;

                case 7:
                    _linearHeart.Visibility = ViewStates.Invisible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked8", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel7", correctAnswer); }
                    editor.Apply();
                    break;

                case 8:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked9", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel8", correctAnswer); }
                    editor.Apply();
                    break;

                case 9:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked10", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel9", correctAnswer); }
                    editor.Apply();
                    break;

                case 10:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked11", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel10", correctAnswer); }
                    editor.Apply();
                    break;

                case 11:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked12", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel11", correctAnswer); }
                    editor.Apply();
                    break;

                case 12:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked13", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel12", correctAnswer); }
                    editor.Apply();
                    break;

                case 13:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked14", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel13", correctAnswer); }
                    editor.Apply();
                    break;

                case 14:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked15", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel14", correctAnswer); }
                    editor.Apply();
                    break;

                case 15:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked16", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel15", correctAnswer); }
                    editor.Apply();
                    break;

                case 16:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked17", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel16", correctAnswer); }
                    editor.Apply();
                    break;

                case 17:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked18", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel17", correctAnswer); }
                    editor.Apply();
                    break;

                case 18:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked19", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel18", correctAnswer); }
                    editor.Apply();
                    break;

                case 19:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked20", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel19", correctAnswer); }
                    editor.Apply();
                    break;

                case 20:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked21", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel20", correctAnswer); }
                    editor.Apply();
                    break;

                case 21:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked22", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel21", correctAnswer); }
                    editor.Apply();
                    break;

                case 22:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked23", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel22", correctAnswer); }
                    editor.Apply();
                    break;

                case 23:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked24", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel23", correctAnswer); }
                    editor.Apply();
                    break;

                case 24:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked25", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel24", correctAnswer); }
                    editor.Apply();
                    break;

                case 25:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked26", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel25", correctAnswer); }
                    editor.Apply();
                    break;

                case 26:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked27", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel26", correctAnswer); }
                    editor.Apply();
                    break;

                case 27:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked28", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel27", correctAnswer); }
                    editor.Apply();
                    break;

                case 28:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked29", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel28", correctAnswer); }
                    editor.Apply();
                    break;

                case 29:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked30", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel29", correctAnswer); }
                    editor.Apply();
                    break;

                case 30:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked31", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel30", correctAnswer); }
                    editor.Apply();
                    break;

                case 31:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked32", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel31", correctAnswer); }
                    editor.Apply();
                    break;

                case 32:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked33", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel32", correctAnswer); }
                    editor.Apply();
                    break;


                case 33:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked34", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel33", correctAnswer); }
                    editor.Apply();
                    break;

                case 34:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked35", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel34", correctAnswer); }
                    editor.Apply();
                    break;

                case 35:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked36", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel35", correctAnswer); }
                    editor.Apply();
                    break;

                case 36:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked37", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel36", correctAnswer); }
                    editor.Apply();
                    break;

                case 37:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked38", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel37", correctAnswer); }
                    editor.Apply();
                    break;

                case 38:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked39", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel38", correctAnswer); }
                    editor.Apply();
                    break;

                case 39:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked40", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel39", correctAnswer); }
                    editor.Apply();
                    break;

                case 40:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked41", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel40", correctAnswer); }
                    editor.Apply();
                    break;




                case 100:
                    lifeCount = 1;
                    _linearHeart.Visibility = ViewStates.Visible;
                    var planes = PlaneCollection.GetPlanes();
                    var tanks = TankCollection.GetTanks();
                    var ships = ShipCollection.GetShips();
                    planes.AddRange(tanks);
                    planes.AddRange(ships);
                    vehicles = planes;
                    break;


                case 101:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked102", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel101", correctAnswer); }
                    editor.Apply();
                    break;

                case 102:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked103", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel102", correctAnswer); }
                    editor.Apply();
                    break;

                case 103:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndShips();
                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked104", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel103", correctAnswer); }
                    editor.Apply();
                    break;

                case 104:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked105", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel104", correctAnswer); }
                    editor.Apply();
                    break;

                case 105:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked106", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel105", correctAnswer); }
                    editor.Apply();
                    break;

                case 106:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked107", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel106", correctAnswer); }
                    editor.Apply();
                    break;

                case 107:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked108", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel107", correctAnswer); }
                    editor.Apply();
                    break;

                case 108:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked109", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel108", correctAnswer); }
                    editor.Apply();
                    break;

                case 109:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked110", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel109", correctAnswer); }
                    editor.Apply();
                    break;

                case 110:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked111", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel110", correctAnswer); }
                    editor.Apply();
                    break;

                case 111:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked112", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel111", correctAnswer); }
                    editor.Apply();
                    break;


                case 112:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked113", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel112", correctAnswer); }
                    editor.Apply();
                    break;

                case 113:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked114", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel113", correctAnswer); }
                    editor.Apply();
                    break;

                case 114:
                    lifeCount = 3;
                    _linearHeart.Visibility = ViewStates.Visible;
                    LoadListPlanesAndTanks();

                    if (correctAnswer >= ChoosedTotalScore - 1)
                    { editor.PutBoolean("LevelUnlocked115", true); }
                    if (correctAnswer > ChoosedLevelScoreEarned)
                    { editor.PutInt("SScoreLevel114", correctAnswer); }
                    editor.Apply();
                    break;

            }

        }

        private void LevelFilteredViaLinq()
        {
            switch (ChoosedGameModeIndex)
            {
                case 1:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 2:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 3:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 4:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Germany" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 5:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 6:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 7:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Plane" && s.PeriodOfTime == 1 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "USSR" || s.Character == "Tank" && s.PeriodOfTime == 1 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 8:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Italy" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 9:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 10:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 11:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 12:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 13:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "USSR" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 1 && s.Nation == "Germany" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 14:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 15:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 16:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 17:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 18:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 19:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 20:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 21:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 22:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 23:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 24:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 25:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 26:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 27:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 28:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 29:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 30:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 31:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 32:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 33:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 34:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 35:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "Japan" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Ship" && s.PeriodOfTime == 2 && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 36:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "France" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 37:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 38:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 39:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 40:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Plane" && s.PeriodOfTime == 2 && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.PeriodOfTime == 2 && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;



                case 100:
                    break;

                case 101:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 102:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Tank"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 103:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Ship"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 104:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "USA" ||
                                               s.Character == "Tank" && s.Nation == "USA"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 105:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Germany" ||
                                               s.Character == "Tank" && s.Nation == "Germany"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 106:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "USSR" ||
                                               s.Character == "Tank" && s.Nation == "USSR"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 107:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "GB" ||
                                               s.Character == "Tank" && s.Nation == "GB"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 108:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Japan" ||
                                               s.Character == "Tank" && s.Nation == "Japan"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 109:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Italy" ||
                                               s.Character == "Tank" && s.Nation == "Italy"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 110:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "France" ||
                                               s.Character == "Tank" && s.Nation == "France"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;

                case 111:
                    linqCharacter = from s in vehicles
                                    where s.Character == "Plane" && s.Nation == "Sweden" ||
                                               s.Character == "Tank" && s.Nation == "Sweden"
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;


                case 112:
                    linqCharacter = from s in vehicles
                                    where s.PeriodOfTime == 1
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;



                case 113:
                    linqCharacter = from s in vehicles
                                    where s.PeriodOfTime == 2
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;



                case 114:
                    linqCharacter = from s in vehicles
                                    where s.PeriodOfTime == 3
                                    select s; //лінкю запит
                    vehicles = linqCharacter.ToList();
                    break;
            }
        }
    }
}