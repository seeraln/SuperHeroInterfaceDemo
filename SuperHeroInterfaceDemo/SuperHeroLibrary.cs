using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroInterfaceDemo
{
    public abstract class SuperHero
    {
       
    }
    public abstract class Alien : SuperHero
    {

    }
    public abstract class Human : SuperHero
    {

    }
    interface IFlyable
    {
        void Fly();
    }
    interface ISeeThroughThings
    {
        void LookThroughObjects();
    }
    public class Batman : Human, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("I defy gravity with my special powers");
        }
        public void LookThroughObjects()
        {
            //throw new NotImplementedException();
            Console.WriteLine("I have X Ray vision");
        }
    }
    public class SuperMan : Alien, IFlyable , ISeeThroughThings
    {
        public void Fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("I defy gravity with my special powers");
        }
        public void LookThroughObjects()
        {
            //throw new NotImplementedException();
            Console.WriteLine("I have X Ray vision");
        }
    }
}
