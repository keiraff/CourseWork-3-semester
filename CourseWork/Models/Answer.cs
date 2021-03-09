using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseWork.Models
{
    [Serializable]
    public class Answer
    {
        private bool isCorrect;
        private string answerValue;
        [XmlAttribute]
        public bool IsCorrect { get { return isCorrect; } set { isCorrect = value; } }
        public string AnswerValue { get { return answerValue; } set { answerValue = value; } }

        private Answer(string value, bool mark)
        {
            AnswerValue = value;
            IsCorrect = mark;
        }
        public Answer()
        { }
        
    }
}

