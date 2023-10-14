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
using System.Windows.Shapes;

namespace WPF_Base_kafedra_try3
{
    /// <summary>
    /// Логика взаимодействия для fakulteti.xaml
    /// </summary>
    public partial class fakultetiForm : Window
    {
        kafedraEntities dataEntities = new kafedraEntities();
        public fakultetiForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
         from product in dataEntities.fakulteti
         select new { product.kod_fakulteta, product.Name_fakulteta, product.FIO, product.Nom_komnati_dekanata, product.Telefon_dekanata };

            dataGrid1.ItemsSource = query.ToList();
        }

        private void FormClosed_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newFakultet = new fakulteti
            {
                Name_fakulteta = txtName.Text,
                FIO = txtFIO.Text,
                Nom_komnati_dekanata = txtNomKomnati.Text,
                Telefon_dekanata = txtTelefon.Text
            };

            dataEntities.fakulteti.Add(newFakultet);

            dataEntities.SaveChanges();

            txtName.Text = string.Empty;
            txtFIO.Text = string.Empty;
            txtNomKomnati.Text = string.Empty;
            txtTelefon.Text = string.Empty;

            var query =
             from product in dataEntities.fakulteti
             select new { product.kod_fakulteta, product.Name_fakulteta, product.FIO, product.Nom_komnati_dekanata, product.Telefon_dekanata };

            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
