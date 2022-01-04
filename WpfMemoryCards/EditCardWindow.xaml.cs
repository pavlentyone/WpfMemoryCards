using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfMemoryCards
{
    /// <summary>
    /// Interaction logic for EditCardWindow.xaml
    /// </summary>
    public partial class EditCardWindow : Window
    {
        public Card Value { get; set; }
        public EditCardWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Value = new Card();
            MainWindow.db.Add(new Card());
        }
    }
}
