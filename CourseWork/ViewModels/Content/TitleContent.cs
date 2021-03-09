using CourseWork.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels.Content
{
    internal class TitleContent:BaseContent
    {
        private string name;
        private string descrirtion;
        private DateTime dateOfCreation;
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public DateTime DateOfCreation { get => dateOfCreation; set { dateOfCreation = value; OnPropertyChanged(); } }
        public string Description { get => descrirtion; set { descrirtion = value; OnPropertyChanged(); } }
        public TitleContent(ExecuteHandler execute, CanExecuteHandler canExecute = null)
            : base(execute, canExecute)
        {
        }
    }
}
