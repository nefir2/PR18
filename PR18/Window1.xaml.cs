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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
	{
		private bool isVisible = true;
		public Window1()
        {
            InitializeComponent();
		}
		private void ButtonClick(object sender, RoutedEventArgs e) => TextBox1.IsReadOnly = ((Button)sender).Name == Button1.Name;
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			window.Background = Brushes.Gray;
			grid.Visibility = isVisible ? Visibility.Collapsed : Visibility.Visible;
			isVisible = !isVisible;
		}

		private void window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
