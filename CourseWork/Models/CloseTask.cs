using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseWork.Models
{
    [Serializable]
    public class CloseTask : Question
    {
        private List<Answer> allAnswers;
        private bool isOnlyOneRightAnswer;
        public List<Answer> AllAnswers { get { return allAnswers; } set { allAnswers = value; } }
        [XmlAttribute]
        public bool IsOnlyOneRightAnswer { get { return isOnlyOneRightAnswer; } set { isOnlyOneRightAnswer = value; } }
        protected CloseTask(string value, List<Answer> allAnswers, bool isOnlyOne)
        : base(value)
        {
            
            QuestionValue = value;
            AllAnswers = allAnswers;
            IsOnlyOneRightAnswer = isOnlyOne;
        }
        public CloseTask() { }

        
    }
}
