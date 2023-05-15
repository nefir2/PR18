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

namespace PR18
{
	/// <summary>
	/// Логика взаимодействия для Window2.xaml
	/// </summary>
	public partial class Window2 : Window
	{
		public Window2()
		{
			InitializeComponent();
		}
		private void btnClick(object sender, RoutedEventArgs e)
		{
			string? btnName = (sender as Button)?.Name;
			if (btnName == btnLeft.Name)
			{
				lblLeft.Background = Brushes.Green;
				lblMiddle.Background = Brushes.Green;
			}
			else if (btnName == btnMiddle.Name)
			{
				lblLeft.Background = Brushes.Blue;
				lblRight.Background = Brushes.Blue;
			}
			else if (btnName == btnRight.Name)
			{
				lblMiddle.Background = Brushes.Red;
				lblRight.Background = Brushes.Red;
			}
		}
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			lblLeft.Background = Brushes.White;
			lblMiddle.Background = Brushes.White;
			lblRight.Background = Brushes.White;
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
