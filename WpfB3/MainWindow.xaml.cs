using ClientTestingDb;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfB3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Client> maListe;

        public MainWindow()
        {
            InitializeComponent();
            maListe = new ObservableCollection<Client>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbClient.ItemsSource = Client.GetList();
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            if(tbNom.Text != "" && tbType.Text != "" && tbMtEnCours.Text != "")
            {
                var client = Client.CreateObject(TypeClient.NORMAL);
                client.Name = tbNom.Text;
                //client.Type = tbType.Text;
                client.MtEncours = Convert.ToInt32(tbMtEnCours.Text);
                client.Save();
                lbClient.ItemsSource = Client.GetList();
            }


        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            Client clientSelected = lbClient.SelectedItem as Client;
            if (clientSelected != null)
            {
                clientSelected.PrepareToDelete();
            }
            clientSelected.Save();
            lbClient.ItemsSource = Client.GetList();
        }

    }
}
