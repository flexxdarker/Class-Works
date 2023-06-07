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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07._06._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int countPeople = 0;
        string typeofaparts = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if(countPeople < 12)
            {
                countPeople+=1;
                CountPeople.Content = countPeople;
            }
            else
            {
                countPeople = 0;
                countPeople+=1;
                CountPeople.Content = countPeople;
            }
        }

        private void CountBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Name: {NameTB.Text}\nSurname: {SurnameTB.Text}\nPhone number: {PhoneTB.Text}\nCount of People: {countPeople}\nSelected Apartments: {typeofaparts}\nDate From: {Calendar.SelectedDates.First()}\nDate To: {Calendar.SelectedDates.Last()}");
        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Luxe_Click(object sender, RoutedEventArgs e)
        {
            typeofaparts = Luxe.ToString();
        }

        private void Standart_Click(object sender, RoutedEventArgs e)
        {
            typeofaparts = Standart.ToString();
        }

        private void Econom_Click(object sender, RoutedEventArgs e)
        {
            typeofaparts = Econom.ToString();
        }
    }
}
