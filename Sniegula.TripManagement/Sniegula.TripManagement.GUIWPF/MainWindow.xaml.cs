using Sniegula.TripManagement.Data.exceptions;
using Sniegula.TripManagement.Data.model;
using Sniegula.TripManagement.Logic;
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

namespace Sniegula.TripManagement.GUIWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TripService tripService = new TripService();

        public MainWindow()
        {
            InitializeComponent();
            refreshListBox();
      

            //
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fromUser = MyTextBox1.Text;
            Label1.Content = fromUser;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Person selectedPerson = (Person) ListBoxPeople.SelectedItem;
            if (selectedPerson != null)
            {
                string amout = TextBoxAmount.Text;
                try
                {
                    decimal amountDecimal = decimal.Parse(amout);
                    tripService.PayForATrip(selectedPerson, amountDecimal);
                    refreshListBox();


                }
                catch (FormatException ex) {

                    MessageBox.Show("Podana wartość nie jest liczbą");
                }
                catch (AmountToBigException ex) {
                    MessageBox.Show(ex.Message + " " + "Możesz wpłacić maksymalnie " + ex.MaximalAmount );
                }
            }
            else {

                MessageBox.Show("Zaznacz osobę dla której dokonujesz wpłaty");
            }
        }


        private void refreshListBox() {
            List<Person> people = tripService.GetAllPeople();
            ListBoxPeople.Items.Clear();
            foreach (Person p in people)
            {
                ListBoxPeople.Items.Add(p);
            }

            DataGridPeople.Items.Clear();
            foreach (Person p in people)
            {
                DataGridPeople.Items.Add(p);
            }
        }
    }
}
