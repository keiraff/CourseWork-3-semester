using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    internal class AnswerViewModel:BaseViewModel
    {
        private readonly Answer TestAnswer;

        /// <summary>Поле для хранения значения свойства</summary>
        private bool isRightView;

        /// <summary>Конструтор из ответа типа Модели</summary>
        public AnswerViewModel(Answer testAnswer) => TestAnswer = testAnswer;
        public string AnswerValue => TestAnswer.AnswerValue;

        /// <summary>Свойство для выбора ответа</summary>
        public bool IsRightView
        {
            get => isRightView; 
            set 
            {
                isRightView = value;
                OnPropertyChanged();
            } 
        }
        public bool IsRight => IsRightView == TestAnswer.IsCorrect;
    }
}
