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

namespace EsercizioNatale
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Txt1.Text);
            double b = double.Parse(Txt2.Text);
            if (CmbOperazioni.SelectedIndex == 0)
            {
                double somma = a + b ;
                Risultato.Text = $"{somma}";
            }
            if (CmbOperazioni.SelectedIndex == 1)
            {
                double sottrazione = a - b;
                Risultato.Text = $"{sottrazione}";
            }
            if (CmbOperazioni.SelectedIndex == 2)
            {
                double moltiplicazione = a * b;
                Risultato.Text = $"{moltiplicazione}";
            }
            if (CmbOperazioni.SelectedIndex == 3)
            {
                double divisione = a / b;
                Risultato.Text = $"{divisione}";
            }

        }
    }
}
