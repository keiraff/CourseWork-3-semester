using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseWork.Models
{
    [XmlInclude(typeof(CloseTask))]
    public abstract class Question
    {
        //private string number;
        private string questionValue;
        //private List<Answer> answers;
        //public string Number { get { return number; } set { number = value; } }
        public string QuestionValue { get { return questionValue; } set { questionValue = value; } }
        //public List<Answer> Answers { get { return answers; } set { answers = value; } }
        protected Question(/*string number,*/ string value/*, List<Answer> answers*/)
        {
            //Number = number;
            QuestionValue = value;
            //Answers = answers;
        }
        public Question()
        { }
        

    }
}
