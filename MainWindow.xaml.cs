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

namespace Forditva2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

        private void gomb_Click(object sender, RoutedEventArgs e) {

            //szo
            char[] forditottsz = szo.Text.ToString().ToCharArray();
            Array.Reverse(forditottsz);
            szoford.Content = new string(forditottsz);

            //szoveg
            if (pipa.IsChecked == true) {
                string[] szavak = szoveg.Text.Split(' ');
                string output = "";
                foreach (string szo in szavak) {
                    char[] forditott = szo.ToArray().Reverse().ToArray();
                    output += new string(forditott) + " ";
                }
                szovegford.Content = output;
            }
            else if (pipa.IsChecked == false) {
                char[] forditott = szoveg.Text.ToString().ToCharArray();
                Array.Reverse(forditott);
                szovegford.Content = new string(forditott);
            }

            //kep
            KepForgat();

            //reciprok
            szamre.Content = 1 / cleanszam;
        }

        private bool forgatottkep = true;
        private void KepForgat() {
            if (forgatottkep) kep.RenderTransform = new RotateTransform(180);
            else kep.RenderTransform = new RotateTransform(0);
            forgatottkep = !forgatottkep;
        }

        // számnak való
        private float cleanszam;
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) {
            bool isNumeric = float.TryParse(szam.Text, out float val);
            if (!isNumeric) szam.Text = "";
            else cleanszam = val;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

		private void szo_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

		private void CheckBox_Checked(object sender, RoutedEventArgs e) {
            
		}

	}
}
