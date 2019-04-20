using System;

namespace SecondTaskOfTheThirdOption.FifthLaba
{
    public class Question
    {
        private readonly Theme _theme;
        private readonly string _question;
        private readonly string _optionalAnswers;
        private readonly string _correctAnswer;

        public Question(Theme theme, string question, string optionalAnswers, string correctAnswer)
        {
            _theme = theme;
            _question = question;
            _optionalAnswers = optionalAnswers;
            _correctAnswer = correctAnswer;
        }

        public enum Theme
        {
            FirstTheme,
            SecondTheme,
            ThirdTheme
        }


        public void Show()
        {
            Console.WriteLine("{0}",_theme);
            Console.WriteLine("{0}",_question);
            Console.WriteLine("{0}",_optionalAnswers);
        }

        public Theme GetTheme()
        {
            return _theme;
        }
    }
    
    
}