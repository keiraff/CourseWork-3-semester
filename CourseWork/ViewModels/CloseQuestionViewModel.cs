using CourseWork.Models;
using CourseWork.ViewModels.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    internal class CloseQuestionViewModel : BaseViewModel
    {
        /// <summary>Статический ГСЧ</summary>
        protected static readonly Random rand = new Random();
        protected readonly CloseTask TestQuestion;
        public CloseQuestionViewModel(CloseTask testQuestion)
        {
            TestQuestion = testQuestion;
            Answers = TestQuestion.AllAnswers.Select(ans => new AnswerViewModel(ans))
                .OrderBy(x => rand.Next()).ToArray();
        }

        public bool IsOnlyOne => TestQuestion.IsOnlyOneRightAnswer;
        public string Text => TestQuestion.QuestionValue;
        public AnswerViewModel[] Answers { get; }
        public bool IsRightValue => Answers.All(ans => ans.IsRight);
        public static CloseQuestionViewModel Create(CloseTask testQuestion)
        {
           
                if (testQuestion.IsOnlyOneRightAnswer)
                    return new QuestionRadioButtonViewModel(testQuestion);
                return new QuestionCheckBoxViewModel(testQuestion);
            
        }
    }
}
