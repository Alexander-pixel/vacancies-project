using ModelEmployee;
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
using System.Windows.Shapes;
using VacanciesProject.ViewModel;

namespace VacanciesProject.View
{
    /// <summary>
    /// Interaction logic for ChangePositionWindow.xaml
    /// </summary>
    public partial class ChangePositionWindow : Window
    {

        public ChangePositionWindow()
        {
            InitializeComponent();
            DataContext = new ChangePositionViewModel();
        }

        public ChangePositionWindow(Employee employee)
        {
            InitializeComponent();
            DataContext = new ChangePositionViewModel(employee);
        }
    }
}
