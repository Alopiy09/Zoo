using System;

namespace interfacePractice {
    public class Terrapins : Iwalking, Iswimming
    {
        public int Speed { get; set; }
        public int Legs { get; set; }
        public int Fins { get; set; }
    }
}