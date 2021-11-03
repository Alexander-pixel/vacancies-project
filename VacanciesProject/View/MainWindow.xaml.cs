using System.Windows;
using VacanciesProject.ViewModel;

namespace VacanciesProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VacanciesViewModel();
        }
    }
}
