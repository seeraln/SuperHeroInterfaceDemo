using System;

namespace SuperHeroInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan sm = new SuperMan();

            sm.Fly();
            sm.LookThroughObjects();

            Batman bm = new Batman();

            bm.Fly();
            bm.LookThroughObjects();
        }
    }
}
