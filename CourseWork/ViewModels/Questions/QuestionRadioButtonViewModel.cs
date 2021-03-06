using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseWork.Models.Test;

namespace CourseWork.ViewModels.Questions
{
    internal class QuestionRadioButtonViewModel : CloseQuestionViewModel
    {
         ///<summary>Конструтор из базового вопроса типа Модели</summary>
        public  QuestionRadioButtonViewModel(CloseTask testQuestion)
            : base(testQuestion)
        {
            if (!IsOnlyOne)
                throw new TestException("Неверное значение свойства IsOnlyOne!", testQuestion, TestExceptionEnum.InvalidIsOnlyOne);
        }
    }
}
