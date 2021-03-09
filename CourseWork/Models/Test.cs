using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    [Serializable]
    public class Test 
    {
        private string name;
        private readonly DateTime dateOfCreation;
        private DateTime dateOfLastEditing;
        private List<Question> questions;
        private string description;
        public string Name { get { return name; } set { name = value; } }
        public DateTime DateOfCreation { get { return dateOfCreation; } }
        public DateTime DateOfLastEditing { get { return dateOfLastEditing; } set { dateOfLastEditing = value; } }
        public List<Question> Questions { get { return questions; } set { questions = value; } }
        public string Description{ get { return description; } set { description = value; } }

        internal Test(string name, List<Question> questions, string description)
        {
            Name = name;
            dateOfCreation = dateOfLastEditing = DateTime.Now;
            Questions = questions;
            Description = description;

        }
        public Test()
        {
            questions = new List<Question>();
        }

        public override string ToString()
        {
            return Name;
        }
        public enum TestExceptionEnum
        {
            NoRight,
            NotOnlyOne,
            InvalidIsOnlyOne
        }
        public class TestException : Exception
        {

            public Question Question { get; }
            public TestExceptionEnum Error { get; }
            public TestException(Question question, TestExceptionEnum error)
            {
                Question = question;
                Error = error;
            }
            public TestException(string message, Question question, TestExceptionEnum error)
                : base(message)
            {
                Question = question;
                Error = error;
            }
            public TestException(string message, Exception innerException, Question question, TestExceptionEnum error)
                : base(message, innerException)
            {
                Question = question;
                Error = error;
            }

        }
    }
}
