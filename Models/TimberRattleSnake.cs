using System;


namespace interfacePractice {
    public class TimberRattleSnake : Iwalking, Iswimming
    {
        public int Speed { get; set; }
        public int Legs { get; set; }
        public int Fins { get; set; }
    }
}