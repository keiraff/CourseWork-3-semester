using CourseWork.Commands;
using CourseWork.Data;
using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourseWork.ViewModels
{
    internal class TestCreationViewModel:BaseViewModel
    {
        //private Test test = new Test();
        private string description;
        private string title;
        private string questionValue;
        private string answerValue;
        private List<Question> questions = new List<Question>();
        private List<Answer> answers = new List<Answer>();
        private bool onlyOne;
        private bool isCorrect;
        private IMainWindowsCodeBehind codeBehind;
        private DataBase dataBase;
        private RelayCommand saveCommand;
        private RelayCommand saveQuestionCommand;
        private RelayCommand saveAnswerCommand;
        private RelayCommand backCommand;
        public TestCreationViewModel(IMainWindowsCodeBehind codeBehind, DataBase database)
        {
            this.codeBehind = codeBehind;
            this.dataBase = database;
        }
        public string QuestionValue
        {
            get => questionValue;
            set
            {
                Set(ref questionValue, value);
            }
        }
        public string AnswerValue
        {
            get => answerValue;
            set
            {
                Set(ref answerValue, value);
            }
        }
        public bool OnlyOne
        {
            get => onlyOne;
            set
            {
                Set(ref onlyOne, value);
            }

        }
        public bool IsCorrect
        {
            get => isCorrect;
            set
            {
                Set(ref isCorrect, value);
            }

        }
        public List<Question> Questions
        {
            get => questions;
            set
            {
                Set(ref questions, value);
            }
        }
        public List<Answer> Answers
        {
            get => answers;
            set
            {
                Set(ref answers, value);
            }
        }
        public string Title
        {
            get => title;
            set
            {
                Set(ref title, value);
            }
        }
        public string Description
        {
            get => description;
            set
            {
                Set(ref description, value);
            }
        }
        private bool CanSaveCommandExecute(object p) => Questions.Count>0&&!string.IsNullOrEmpty(Title);
        private bool CanBackCommandExecute(object p) => true;
        private bool CanSaveQuestionCommandExecute(object p) => Answers.Count > 0 && !string.IsNullOrEmpty(QuestionValue);
        private bool CanSaveAnswerCommandExecute(object p) => !string.IsNullOrEmpty(AnswerValue);
        private void OnBackCommandExecute(object p)
        {
            codeBehind.LoadView(ViewType.First);
        }
        private void OnSaveAnswerCommandExecute(object p)
        {
            Answer answer = new Answer();
            answer.AnswerValue = answerValue;
            answer.IsCorrect = isCorrect;
            Answers.Add(answer);

        }
        private void OnSaveQuestionCommandExecute(object p)
        {
            CloseTask question = new CloseTask();
            question.QuestionValue = questionValue;
            question.IsOnlyOneRightAnswer = onlyOne;
            question.AllAnswers = answers;
            Questions.Add(question);
            answers = new List<Answer>();
        }
        private void OnSaveCommandExecute(object p)
        {
            Test test = new Test();
            test.Name = title;
            test.Description = description;
            test.Questions = questions;
            test.DateOfLastEditing = DateTime.Now;
            dataBase.Tests.Add(test);
            questions=new List<Question>();
            DataBase.Serialization("test.xml", dataBase.Tests);
            dataBase.Tests=DataBase.Deserialization("test.xml");
        }
        public RelayCommand SaveCommand
        {
            get { return saveCommand = new RelayCommand(OnSaveCommandExecute, CanSaveCommandExecute); }
        }
        public RelayCommand SaveQuestionCommand
        {
            get { return saveQuestionCommand = new RelayCommand(OnSaveQuestionCommandExecute, CanSaveQuestionCommandExecute); }
        }
        public RelayCommand SaveAnswerCommand
        {
            get { return saveAnswerCommand = new RelayCommand(OnSaveAnswerCommandExecute, CanSaveAnswerCommandExecute); }
        }
        public RelayCommand BackCommand
        {
            get { return backCommand = new RelayCommand(OnBackCommandExecute, CanBackCommandExecute); }
        }
    }
}
