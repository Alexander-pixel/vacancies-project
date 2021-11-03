using ModelEmployee;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using VacanciesProject.Infrastructure;

namespace VacanciesProject.ViewModel
{
    class AddEmployeeViewModel:INotifyPropertyChanged
    {
        private Employee _newEmployee;
        private DelegateCommand _cancelCommand;
        private DelegateCommand _addCommand;
        public List<string> Positions { get; set; }
        private ObservableCollection<Employee> Employees { get; set; }
        public DelegateCommand CancelCommand 
        { 
            get
            {
                return _cancelCommand ?? (_cancelCommand = new DelegateCommand(obj =>
                {
                    var window = obj as Window;
                    window.Close();
                }));
            }
        }

        public DelegateCommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new DelegateCommand(obj =>
                {
                    var employee = NewEmployee;
                    Employees.Add(employee);
                }));
            }
        }

        public Employee NewEmployee
        {
            get => _newEmployee;
            set
            {
                if (value != _newEmployee)
                {
                    _newEmployee = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public AddEmployeeViewModel()
        {
            
        }

        public AddEmployeeViewModel(ObservableCollection<Employee> Employees)
        {
            _newEmployee = new Employee();
            this.Employees = Employees;
            Positions = new List<string>
            {
                "Game Developer",  "Software Developer", "Web Developer", "Data Scientist", "CEO"
            };
        }
    }
}
