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

namespace OOP_Clovek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak Fiat;
        Nakladak Volvo;

        public MainWindow()
        {
            InitializeComponent();

            Fiat = new Nakladak();
            Fiat.Auto = "Fiat";
            Fiat.Znacka = "Ducato";
            Zobraz(Fiat, txt1);

            Volvo = new Nakladak();
            Volvo.Auto = "Volvo";
            Volvo.Znacka = "FH16";
            Zobraz(Volvo, txt2);
        }

        public void Zobraz(Nakladak nakladak, TextBox textBox)
        {
            textBox.Text = nakladak.Auto + " " + nakladak.Znacka + "\n";
            textBox.Text += "Palivo: " + nakladak.Palivo.ToString() + "\n";
            textBox.Text += "Dojezd: " + nakladak.Dojezd.ToString() + "\n";
            textBox.Text += "Nosnost: " + nakladak.Nosnost.ToString() + "\n";
            textBox.Text += "Naklad: " + nakladak.Naklad.ToString() + "\n";
            textBox.Text += "Odjezd: " + nakladak.Odjezd.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fiat.Jed();
            Zobraz(Fiat, txt1);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Fiat.Vylozitnaklad();
            Zobraz(Fiat, txt1);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Fiat.Natankovat();
            Zobraz(Fiat, txt1);  
        }


        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Fiat.Nalozitnaklad();
            Zobraz(Fiat, txt1);
        }


        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            Volvo.Jed();
            Zobraz(Volvo, txt2);
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            Volvo.Vylozitnaklad();
            Zobraz(Volvo, txt2);

        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            Volvo.Natankovat();
            Zobraz(Volvo, txt2);
        }


        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            Volvo.Nalozitnaklad();
            Zobraz(Volvo, txt2);
        }


    }
}

