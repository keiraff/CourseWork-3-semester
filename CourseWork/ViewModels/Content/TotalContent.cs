using CourseWork.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels.Content
{
    internal class TotalContent:BaseContent
    {
        private int countRight;
        private int countTotal;
        public int CountRight
        {
            get => countRight;
            set
            {
                countRight = value;
                OnPropertyChanged();
            }
        }
        public int CountTotal
        {
            get => countTotal;
            set
            {
                countTotal = value;
                OnPropertyChanged();
            } }
        public TotalContent(ExecuteHandler execute, CanExecuteHandler canExecute = null) : base(execute, canExecute) { }
    }
}
