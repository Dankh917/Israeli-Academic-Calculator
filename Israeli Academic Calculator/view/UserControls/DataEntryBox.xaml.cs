﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Israeli_Academic_Calculator.view.UserControls
{
    /// <summary>
    /// Interaction logic for DataEntryBox.xaml
    /// </summary>
    public partial class DataEntryBox : UserControl, INotifyPropertyChanged
    {
        public DataEntryBox()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string placeholder;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value;
                OnPropertyChanged("Placeholder");
            }
        }

        private string text;

        public string Text
        {
            get { return  TextInput.Text; }
            set { TextInput.Text = value; }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            TextInput.Clear();
            TextInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextInput.Text))
            {
                TextBlockPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                TextBlockPlaceHolder.Visibility = Visibility.Hidden;
            }

        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //need to add a function to clear the DataEntryBox
        public void Clr_Data_Entry_Box()
        {
            TextInput.Clear();
        }

    }
}
