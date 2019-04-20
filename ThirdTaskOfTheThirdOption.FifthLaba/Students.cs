using System;

namespace ThirdTaskOfTheThirdOption.FifthLaba
{
    public class Students
    {
        private Student[] _students;

        public Students() : this(new Student[0]){}
        public Students(Student[] students)
        {
            _students = students;
        }

        public void Add(Student student)
        {
            Array.Resize(ref _students, _students.Length+1);
            _students[_students.Length-1] = student;
        }
        
        public Student GetByIndex(int studentIndex)
        {
            return _students[studentIndex];
        }
        
        public int GetQuantity()
        {
            return _students.Length;
        }

        private void Swap(int firstIndex, int secondIndex)
        {
            var tmp = _students[firstIndex];
            _students[firstIndex] = _students[secondIndex];
            _students[secondIndex] = tmp;
        }
        
        public static void SortByAverageScore(Students students)
        {
            var quantity = students.GetQuantity();
            for (int elementIndex = 0; elementIndex < quantity; elementIndex++)
            {
                for (int index = 0; index < quantity-1; index++)
                {
                    if (students.GetByIndex(index).GetAverageScore()<students.GetByIndex(index+1).GetAverageScore())
                    {
                        students.Swap(index,index+1);
                    }
                }
            }
        }
    }
}
