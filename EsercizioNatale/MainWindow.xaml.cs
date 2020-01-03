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
using System.IO;

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
        private const string file_name = "txtfile";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(Txt1.Text);
                double b = double.Parse(Txt2.Text);
                string op = "";
                double ris = 0;
               

                if (CmbOperazioni.SelectedIndex == 0)
                {
                    op = "somma";
                    double somma = a + b;
                    ris = somma;
                    Risultato.Text = $"{somma}";
                }
                if (CmbOperazioni.SelectedIndex == 1)
                {
                    op = "sottrazione";
                    double sottrazione = a - b;
                    ris = sottrazione;
                    Risultato.Text = $"{sottrazione}";
                }
                if (CmbOperazioni.SelectedIndex == 2)
                {
                    op = "moltiplicazione";
                    double moltiplicazione = a * b;
                    ris = moltiplicazione;
                    Risultato.Text = $"{moltiplicazione}";
                }
                if (CmbOperazioni.SelectedIndex == 3)
                {
                    op = "divisione";
                    double divisione = a / b;
                   
                    if (b == 0)
                    {
                        MessageBox.Show("impossibile dividere un numero per 0", "errore", MessageBoxButton.OK, MessageBoxImage.Error);
                        Risultato.Text = "errore";
                    }
                    else
                    {
                        ris = divisione;
                        Risultato.Text = $"{divisione}";
                    }

                }
                using (StreamWriter t = new StreamWriter(file_name, true))
                {
                    t.WriteLine($"{a} {b} {op} {ris}");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("inserire solo numeri", "errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           

        }
    }
}
