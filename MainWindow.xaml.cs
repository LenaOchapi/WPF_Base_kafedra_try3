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

namespace WPF_Base_kafedra_try3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFakulteti_Click(object sender, RoutedEventArgs e)
        {
            fakultetiForm fakultetiForm = new fakultetiForm();
            fakultetiForm.Closed += fakulteti_FormClosed;
            this.Hide();
            fakultetiForm.Show();
        }
        private void fakulteti_FormClosed(object sender, EventArgs e)
        {
            // Показываем первую форму при закрытии второй формы
            this.Show();
        }
    }
}
