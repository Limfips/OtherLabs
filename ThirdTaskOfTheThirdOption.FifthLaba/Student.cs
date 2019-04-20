using System;

namespace ThirdTaskOfTheThirdOption.FifthLaba
{
    public class Student
    {
        private readonly string _firstName;
        private readonly string _lastNameStudent;
        private readonly int _mathScore;
        private readonly int _physicsScore;
        private readonly int _informaticsScore;

        public Student(string firstName, string lastNameStudent, 
                        int mathScore, int physicsScore, int informaticsScore)
        {
            _firstName = firstName;
            _lastNameStudent = lastNameStudent;
            _mathScore = mathScore;
            _physicsScore = physicsScore;
            _informaticsScore = informaticsScore;
        }

        public  void PrintDetails()
        {
            Console.WriteLine("{0} {1}\nОценки:{2},{3},{4}",_lastNameStudent,
                    _firstName,_mathScore,_physicsScore,_informaticsScore);
        }
        public double GetAverageScore()
        {
           return Math.Round((_mathScore+_physicsScore+_informaticsScore)/3.0,2);
        }
        
        public string GetName()
        {
            return _lastNameStudent+" "+_firstName;
        }
    }
}