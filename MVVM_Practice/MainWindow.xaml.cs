using MVVM_Practice.MVVM;
using System.Windows;

namespace MVVM_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserViewModel VM = new UserViewModel();
            DataContext = VM;
        }
    }
}
