using CourseWork.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels.Content
{
    /// <summary>Базовый класс для контента ViewModel</summary>
    internal class BaseContent : BaseViewModel
    { 
        
        public RelayCommand JumpCommand { get; }
        public BaseContent(ExecuteHandler execute, CanExecuteHandler canExecute = null)
            => JumpCommand = new RelayCommand(execute, canExecute);
    }
}
