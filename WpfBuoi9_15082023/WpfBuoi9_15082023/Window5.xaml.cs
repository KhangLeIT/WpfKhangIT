﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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


namespace WpfBuoi9_15082023
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            List<Person> persons = new List<Person>();
            Person person1 = new Person() { Name = "John Doe", Age = 42 };
            Person person2 = new Person() { Name = "Jane Doe", Age = 39 };
            Person child1 = new Person() { Name = "Sammy Doe", Age = 13 };
            person1.Children.Add(child1);
            person2.Children.Add(child1);
            person2.Children.Add(new Person() { Name = "Jenny Moe", Age =17 });
            Person person3 = new Person() { Name = "Becky Toe", Age = 25 };
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            person2.IsExpanded = true;
            person2.IsSelected = true;
            trvPersons.ItemsSource = persons;


        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            if(trvPersons.SelectedItem != null)
            {
                var list = (trvPersons.ItemsSource as List<Person>);
                int curIndex = list.IndexOf(trvPersons.SelectedItem as Person);
                if (curIndex >= 0)
                    curIndex++;
                if (curIndex >= list.Count)
                    curIndex = 0;
                if (curIndex >= 0)
                    list[curIndex].IsSelected = true;
            }
        }

        private void btnToggleExpansion_Click(object sender, RoutedEventArgs e)
        {
            if (trvPersons.SelectedItem != null)
                (trvPersons.SelectedItem as Person).IsExpanded = !(trvPersons.SelectedItem as Person).IsExpanded;
        }

    }

    public class Person : TreeViewItemBase
    {
        public Person()
        {
            this.Children = new ObservableCollection<Person>();
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public ObservableCollection<Person> Children { get; set; }
       
    }
    public class TreeViewItemBase : INotifyPropertyChanged
    {
        private bool isSelected;
        public bool IsSelected
        {
            get { return this.isSelected; }
            set
            {
                if (value != this.isSelected)
                {
                    this.isSelected = value;
                    NotifyPropertyChanged("IsSelected");
                }
            }
        }

        private bool isExpanded;
        public bool IsExpanded
        {
            get { return this.isExpanded; }
            set
            {
                if (value != this.isExpanded)
                {
                    this.isExpanded = value;
                    NotifyPropertyChanged("IsExpanded");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }


}


 
