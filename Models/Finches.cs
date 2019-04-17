using System;


namespace interfacePractice{
    public class Finches : Iflying, Iwalking
    {
        public int Speed { get; set; }
        public int Legs { get; set; }
        public int Wings { get; set; }
    }
}