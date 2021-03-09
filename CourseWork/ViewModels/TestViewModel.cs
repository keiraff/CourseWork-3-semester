using CourseWork.Models;
using CourseWork.Data;
using CourseWork.ViewModels.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    internal class TestViewModel:BaseViewModel
    {
        private IMainWindowsCodeBehind codeBehind;
        private readonly Test Test;
        private DataBase dataBase;
        public TestContentViewModel TestView { get; private set; }
        private BaseContent content;
        public BaseContent Content
        { 
            get => content; 
            set
            { 
                content = value;
                OnPropertyChanged();
            } 
        }
        public TestViewModel(IMainWindowsCodeBehind codeBehind, DataBase dataBase)
        {
            Test = dataBase.SelectedTest;
            this.codeBehind = codeBehind;
            this.dataBase = dataBase;
            TotalMetod(null);
        }
        private void TitleMetod(object parameter)
        {
            Content = new TestContent(QuestionsMetod) { Questions = TestView.Questions };
        }
        private void QuestionsMetod(object parameter)
        {
            Content = new TotalContent(TotalMetod)
            {
                CountRight = TestView.CountRight(),
                CountTotal = TestView.Questions.Length
            };
        }
        private void TotalMetod(object parameter)
        {
            TestView = new TestContentViewModel(dataBase.SelectedTest);
            Content = new TitleContent(TitleMetod) { Name = TestView.Name, Description=TestView.Description, DateOfCreation=TestView.DateOfCreation};
        }
    }
}
