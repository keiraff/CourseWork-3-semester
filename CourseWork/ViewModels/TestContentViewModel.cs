using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    internal class TestContentViewModel:BaseViewModel
    {
        private static readonly Random rand = new Random();
        private readonly Test Test;
        public TestContentViewModel(Test test)
        {
            Test = test;
            Questions = Test.Questions.Select(qu => CloseQuestionViewModel.Create((CloseTask)qu))
                .OrderBy(x => rand.Next()).ToArray();
        }
        public string Name => Test.Name;
        public string Description => Test.Description;
        public DateTime DateOfCreation => Test.DateOfCreation;
        public CloseQuestionViewModel[] Questions { get; }
        public int CountRight() => Questions.Count(qu => qu.IsRightValue);
    }
}
