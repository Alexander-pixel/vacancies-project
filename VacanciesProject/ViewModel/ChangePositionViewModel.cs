using ModelEmployee;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VacanciesProject.Infrastructure;

namespace VacanciesProject.ViewModel
{
    class ChangePositionViewModel:INotifyPropertyChanged
    {
        private Employee _selectedEmployee;

        public List<string> Positions { get; set; }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (value != _selectedEmployee)
                {
                    _selectedEmployee = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ChangePositionViewModel()
        {
            Positions = new List<string>
            {
                "Game Developer",  "Software Developer", "Web Developer", "Data Scientist", "CEO"
            };
        }

        public ChangePositionViewModel(Employee element)
        {
            this.SelectedEmployee = element;
            Positions = new List<string>
            {
                "Game Developer",  "Software Developer", "Web Developer", "Data Scientist", "CEO"
            };
        }

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
