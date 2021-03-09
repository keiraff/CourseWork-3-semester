using CourseWork.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels.Content
{
    internal class TestContent:BaseContent
    {
        private CloseQuestionViewModel[] questions;
        private CloseQuestionViewModel currentQuestion;
        private int currQuestionIndex;
        private RelayCommand jumpQuestionCommand;
        public CloseQuestionViewModel[] Questions
        { 
            get => questions; 
            set 
            { 
                questions = value; OnPropertyChanged();
                CurrQuestionIndex = -1;
                JumpQuestionMetod(1); 
            } 
        }
        public CloseQuestionViewModel CurrentQuestion
        { 
            get => currentQuestion; 
            set
            {
                currentQuestion = value; OnPropertyChanged();
            }
        }
        private int CurrQuestionIndex
        {
            get => currQuestionIndex;
            set 
            {
                currQuestionIndex = value;
                OnPropertyChanged(); 
            } 
        }
        public TestContent(ExecuteHandler execute, CanExecuteHandler canExecute = null)
            : base(execute, canExecute) { }

        public RelayCommand JumpQuestionCommand => jumpQuestionCommand ?? (jumpQuestionCommand = new RelayCommand(JumpQuestionMetod, JumpQuestionCanMetod));
        private bool JumpQuestionCanMetod(object parameter)
        => parameter != null
            && int.TryParse(parameter.ToString(), out int parInt)
            && CurrQuestionIndex + parInt >= 0 && CurrQuestionIndex + parInt < Questions.Length;
        private void JumpQuestionMetod(object parameter)
        {
            int newIndex = CurrQuestionIndex + int.Parse(parameter.ToString());
            if (newIndex != CurrQuestionIndex)
            {
                CurrQuestionIndex = newIndex;
                CurrentQuestion = Questions[CurrQuestionIndex];
            }
        }

    }
}
