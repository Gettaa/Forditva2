﻿using System;
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

		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {

		}

		private void szo_SelectionChanged(object sender, SelectionChangedEventArgs e) {

		}

		private void CheckBox_Checked(object sender, RoutedEventArgs e) {

		}

		// számnak való
		private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) {
			bool isNumeric = int.TryParse(szam.Text, out int val);
			if (!isNumeric) szam.Text = new string(szam.Text.Take(szam.Text.Length - 1).ToArray());
		}
	}
}
