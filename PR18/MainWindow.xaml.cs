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

namespace PR18
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Window1 wdw1;
		Window2 wdw2;
		bool isShowedWdw1 = false;
		public MainWindow()
		{
			InitializeComponent(); 
			wdw1 = new Window1();
			wdw2 = new Window2();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string? btnText = (sender as Button)?.Content.ToString();
			if (btnText == "Level1") wdw1.Show();
			else if (btnText == "Level2") wdw2.Show();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) => Application.Current.Shutdown();
	}
}
