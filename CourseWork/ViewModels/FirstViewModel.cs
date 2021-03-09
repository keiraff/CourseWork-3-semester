using CourseWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    internal class FirstViewModel:BaseViewModel
    {
       
        private IMainWindowsCodeBehind codeBehind;
        private DataBase dataBase;
        public IMainWindowsCodeBehind CodeBehind { get; set; }
        public FirstViewModel(IMainWindowsCodeBehind codeBehind, DataBase database)
        {
            this.codeBehind = codeBehind;
            this.dataBase = database;
        }
    }
}
