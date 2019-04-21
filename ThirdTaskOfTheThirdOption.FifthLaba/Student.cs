using System;

namespace ThirdTaskOfTheThirdOption.FifthLaba
{
    public class Student
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _mathScore;
        private readonly int _physicsScore;
        private readonly int _informaticsScore;

        public Student(string firstName, string lastName, 
                        int mathScore, int physicsScore, int informaticsScore)
        {
            _firstName = firstName;
            _lastName = lastName;
            _mathScore = mathScore;
            _physicsScore = physicsScore;
            _informaticsScore = informaticsScore;
        }

        public override string ToString()
        {
            return _lastName+_firstName+"\nОценки: "+
                   _mathScore+" "+_physicsScore+" "+_informaticsScore;
        }

        public double GetAverageScore()
        {
           return Math.Round((_mathScore+_physicsScore+_informaticsScore)/3.0,2);
        }
        
        public string GetName()
        {
            return _lastName+" "+_firstName;
        }
    }
}