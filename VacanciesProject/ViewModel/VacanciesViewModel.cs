using ModelEmployee;
using System.Collections.ObjectModel;
using System;
using System.ComponentModel;
using System.Windows.Data;
using VacanciesProject.Infrastructure;
using System.Windows.Controls;
using System.Windows;
using VacanciesProject.View;
using System.Collections.Generic;

namespace VacanciesProject.ViewModel
{
    class VacanciesViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public ICollectionView Sorted { get; set; }

        private DelegateCommand _openAddWindowCommand;
        private DelegateCommand _removeEmployeeCommand;
        private DelegateCommand _changePositionCommand;
        private DelegateCommand _sortedCommand;

        public DelegateCommand ChangePositionCommand
        {
            get
            {
                return _changePositionCommand ?? (_changePositionCommand = new DelegateCommand(obj =>
                {
                    var list = (ListView)obj;
                    var element = (Employee)list.SelectedItem;
                    if(element != null)
                    {
                        var window = new ChangePositionWindow(element);
                        window.Show();
                    }
                }));
            }
        }

        public DelegateCommand SortedCommand
        {
            get => _sortedCommand ?? (_sortedCommand = new DelegateCommand(SortCommandMethod));
        }

        public DelegateCommand OpenAddWindowCommand
        {
            get
            {
                return _openAddWindowCommand ?? (_openAddWindowCommand = new DelegateCommand(obj =>
                {
                    var window = new AddEmployee(Employees);
                    window.Show();
                }));
            }
        }

        public DelegateCommand RemoveEmployeeCommand
        {
            get
            {
                return _removeEmployeeCommand ?? (_removeEmployeeCommand = new DelegateCommand(obj =>
                {
                    try
                    {
                        var list = (ListView)obj;
                        var item = (Employee)list.SelectedItems[0];
                        Employees.Remove(item);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("You need to choose employee from list to remove.");
                    }
                }));
            }
        }

        public VacanciesViewModel()
        {
            Employees = new ObservableCollection<Employee>()
            {
                new Employee(){ FirstName = "FirstName_1", LastName = "LastName_1", BirthDate = DateTime.Parse("10-27-1984"), Position = "Game Developer"},
                new Employee(){ FirstName = "FirstName_2", LastName = "LastName_2", BirthDate =  DateTime.Parse("04-19-1989"), Position = "Software Developer"},
                new Employee(){ FirstName = "FirstName_3", LastName = "LastName_3", BirthDate =  DateTime.Parse("01-22-1995"), Position = "Web Developer"},
                new Employee(){ FirstName = "FirstName_4", LastName = "LastName_4", BirthDate =  DateTime.Parse("11-01-2002"), Position = "Data Scientist"},
                new Employee(){ FirstName = "FirstName_5", LastName = "LastName_5", BirthDate =  DateTime.Parse("05-11-1998"), Position = "CEO"},
            };

            Sorted = CollectionViewSource.GetDefaultView(Employees);
            Sorted.SortDescriptions.Add(new SortDescription("FirstName", ListSortDirection.Ascending));

            
        }

        void SortCommandMethod(object obj)
        {
            var column = obj as GridViewColumnHeader;
            var sortBy = column.Tag.ToString();
            var dir = Sorted.SortDescriptions[0].Direction;
            var col = Sorted.SortDescriptions[0].PropertyName;
            Sorted.SortDescriptions.Clear();
            if (sortBy == col && dir == ListSortDirection.Ascending)
                Sorted.SortDescriptions.Add(new SortDescription(sortBy, ListSortDirection.Descending));
            else
                Sorted.SortDescriptions.Add(new SortDescription(sortBy, ListSortDirection.Ascending));
        }
    }
}
