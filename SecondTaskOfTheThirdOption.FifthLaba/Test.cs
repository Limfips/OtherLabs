using System;

namespace SecondTaskOfTheThirdOption.FifthLaba
{
    public class Test
    {
        private Question[] _questions;

        public Test() : this(new Question[0]){}
        public Test(Question[] questions)
        {
            _questions = questions;
        }

        public void AddQuestion(Question question)
        {
            Array.Resize(ref _questions, _questions.Length+1);
            _questions[_questions.Length-1] = question;
        }
        public Question GetQuestionByIndex(int questionIndex)
        {
            return _questions[questionIndex];
        }
        
        public int GetQuantity()
        {
            return _questions.Length;
        }
    }
}