using CourseWork.Commands;
using CourseWork.Data;
using CourseWork.Views;
using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;

namespace CourseWork.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private DataBase dataBase;
        private string temp;
        private Test selectedTest;
        private CollectionViewSource testsCollection;
        private string synchronizedText;
        private ObservableCollection<Test> tests;
        private RelayCommand startCommand;
        private RelayCommand createCommand;
        private RelayCommand deleteCommand;
        public IMainWindowsCodeBehind CodeBehind { get; set; }
        public string Temp { get => temp; set => Set(ref temp, value); }
        public Test SelectedTest
        {
            get => selectedTest;
            set
            {
                selectedTest = value;
                OnPropertyChanged(nameof(SelectedTest));
            }
        }
        public ICollectionView TestsCollection
        { 
            get => this.testsCollection.View; 
            set
            {
                testsCollection.Source = value;
                OnPropertyChanged(nameof(TestsCollection));
                //OnPropertyChanged(nameof(testsCollection.Source));
            }
        }
        public string SynchronizedText
        {
            get => synchronizedText;
            set
            {
                Set(ref synchronizedText, value);
                this.testsCollection.View.Refresh();
            }
        }
        public ObservableCollection<Test> Tests
        {
            get
            {
                return tests;
            }
            set
            {
                Set(ref tests, value);
            }
        }
        public RelayCommand StartCommand
        {
            get { return startCommand = new RelayCommand(OnStartCommandExecute, CanStartCommandExecute); }
        }
        public RelayCommand CreateCommand
        {
            get { return createCommand = new RelayCommand(OnCreateCommandExecute, CanCreateCommandExecute); }
        }
        public RelayCommand DeleteCommand
        {
            get { return deleteCommand = new RelayCommand(OnDeleteCommandExecute, CanDeleteCommandExecute); }
        }
        private bool CanStartCommandExecute(object p) => p is Test;
        private void OnStartCommandExecute(object p)
        {
            dataBase.SelectedTest = SelectedTest;
            CodeBehind.LoadView(ViewType.TestContent);
        }
        private bool CanCreateCommandExecute(object p) =>true;
        private void OnCreateCommandExecute(object p)
        {
            //dataBase.NewTest = new Test();
            CodeBehind.LoadView(ViewType.TestCreation);
        }
        private bool CanDeleteCommandExecute(object p) => p is Test;
        private void OnDeleteCommandExecute(object p)
        {
            //dataBase.SelectedTest = SelectedTest;
            int temp = dataBase.Tests.Count;
            for (int i = 0; i < temp; i++)
            {
                if (dataBase.Tests[i].Name == SelectedTest.Name)
                {
                    dataBase.Tests.Remove(dataBase.Tests[i]);
                    temp--;
                    i--;
                }
            }
            //dataBase.Tests.Remove(SelectedTest);
            tests.Remove(SelectedTest);
            DataBase.Serialization("test.xml",dataBase.Tests);
            dataBase.Tests = DataBase.Deserialization("test.xml");
                }
        public MainWindowViewModel(MainWindow view, DataBase dataBase)
        {
            Tests = new ObservableCollection<Test>(dataBase.Tests);
            Temp = "Testing program";
            this.dataBase = dataBase;
            CodeBehind = view;
            testsCollection = new CollectionViewSource();
            testsCollection.Source = tests;
            testsCollection.Filter += testsCollection_Filter;
        }
        void testsCollection_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(SynchronizedText))
            {
                e.Accepted = true;
                return;
            }

            Test test = e.Item as Test;
                if (test.Name.ToLower().Contains(SynchronizedText.ToLower()))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            
        }
    }
}
