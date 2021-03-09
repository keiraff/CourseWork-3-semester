using CourseWork.ViewModels;
using CourseWork.Views;
using CourseWork.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork
{

    public interface IMainWindowsCodeBehind
    {
        /// <summary>
        /// Показ сообщения для пользователя
        /// </summary>
        /// <param name="message">текст сообщения</param>
        //void ShowMessage(string message);

        /// <summary>
        /// Загрузка нужной View
        /// </summary>
        /// <param name="view">экземпляр UserControl</param>
        void LoadView(ViewType typeView);
    }

    /// <summary>
    /// Типы вьюшек для загрузки
    /// </summary>
    public enum ViewType
    {
        Main,
        TestContent,
        TestCreation,
        First
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        DataBase baseTest = new DataBase("test.xml");
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            MainWindowViewModel vm = new MainWindowViewModel(this, baseTest);
            //даем доступ к этому кодбихайнд
            vm.CodeBehind = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;
            //загрузка стартовой View
            //LoadView(ViewType.TestContent);
        }
        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.TestContent:
                    //загружаем вьюшку, ее вьюмодель
                    TestUserControl view = new TestUserControl ();
                    TestViewModel vm = new TestViewModel(this, baseTest);
                    //связываем их м/собой
                    view.DataContext = vm;
                    //отображаем
                    this.OutputView.Content = view;
                    break;
                case ViewType.First:
                    //загружаем вьюшку, ее вьюмодель
                    FirstUserControl view1 = new FirstUserControl();
                    //FirstViewModel vm1 = new FirstViewModel(this, new DataBase("test.xml"));
                    MainWindowViewModel vm1 = new MainWindowViewModel(this, new DataBase("test.xml"));
                    //связываем их м/собой
                    view1.DataContext = vm1;
                    //отображаем
                    this.OutputView.Content = view1;
                    break;
                case ViewType.TestCreation:
                    //загружаем вьюшку, ее вьюмодель
                    TestCreationUserControl view2 = new TestCreationUserControl();
                    TestCreationViewModel vm2 = new TestCreationViewModel(this, baseTest);
                    //связываем их м/собой
                    view2.DataContext = vm2;
                    //отображаем
                    this.OutputView.Content = view2;
                    break;
            }
        }
    }
}
