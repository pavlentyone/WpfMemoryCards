using System;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WpfMemoryCards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public MySqlDbContext db;
        private List<Window> openWindows;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new MySqlDbContext();

            openWindows = new List<Window>();
            FillCollection();

            db.Cards.Load();
        }

        // Ты можешь вводить любой id, но если хоть один id будет повторяться, то выскочит ошибка, 
        //из-за чего нельзя будет сохранить любые настройки в рамках одного SaveChanges() метода.
        // Можешь задавать ЛЮБОЙ id. главное, чтобы он не повторялся и не выходил за пределы самого типа
        //Хотя про
        private void FillCollection()
        {
            // if you don't load data it will not be in local
            CardsListView.ItemsSource = db.Cards.Local.ToObservableCollection();
            //CardsListView.ItemsSource = (from row
            //                        in list
            //                             where NullTagCheckBox.IsChecked == true ?
            //                                 row.Tag == null :
            //                                 row.Tag != null
            //                             select row);
            CardsListView.Items.Filter = o => NullTagCheckBox.IsChecked == true ? ((Card)o).Tag == null : ((Card)o).Tag != null;

        }

        private void NullTagCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            FillCollection();
        }

        private void NullTagCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            FillCollection();
        }

        private void PlusCardButton_Click(object sender, RoutedEventArgs e)
        {
            StartWindow();
        }

        private void MinusCardButton_Click(object sender, RoutedEventArgs e)
        {
            Card[] selectedArray = CardsListView.SelectedItems.Cast<Card>().ToArray();
            db.Cards.RemoveRange(selectedArray);
            //db.SaveChanges();
            //db.Remove(selectedCard);
            //db.SaveChanges();
            //CardsListView.UpdateLayout();
        }

        private void EditCardButton_Click(object sender, RoutedEventArgs e)
        {
            StartWindow();
        }

        private void StartWindow()
        {
            EditCardWindow w = new EditCardWindow();
            openWindows.Add(w);
            w.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window window in openWindows)
                window.Close();
        }
    }
}
