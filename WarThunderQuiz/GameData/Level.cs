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
}