using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class OpenTask : Question
    {
        private List<string> acceptableAnswers;
        private string inputedAnswer;
        public List<string> AcceptableAnswers { get { return acceptableAnswers; } set { acceptableAnswers = value; } }
        public string InputedAnswer { get { return inputedAnswer; } set { inputedAnswer = value; } }
        protected OpenTask(string value, List<string> acceptableAnswers)
        : base(value)
        {
            //Number = number;
            QuestionValue = value;
            AcceptableAnswers = acceptableAnswers;
        }
        protected void InputAnswer(string input)
        {
            inputedAnswer = input;
        }
    }
}
