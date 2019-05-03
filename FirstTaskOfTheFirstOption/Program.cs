using System;

namespace FirstTaskOfTheFirstOption
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            
        }
    }
    [Flags]
    public enum DreamProperties
    {
        Умный = 1,        //0001
        Добрый = 2,       //0010
        Богатый = 4       //0100
    }
    public class Person
    {
        public DreamProperties Properties;
        string fam = "";
        public string Fam
        {
            set { if (fam == "") fam = value; }
            get { return (fam); }
        }
        public Person() { }
        public Person(string fam)
        {
            this.fam = fam;
        }
    }
}