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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;	
using System.Windows.Shapes;
using WeatherApp.ViewModel;
using System.IO;
using System.Reflection;
namespace WeatherApp.View
{
	/// <summary>
	/// Логика взаимодействия для MainAppWindow.xaml
	/// </summary>
	public partial class MainAppWindow : Window
	{
		public MainAppWindow()
		{
			InitializeComponent();

		}
		private void Border_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}
		
		private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
		{
			ScrollViewer scrollviewer = sender as ScrollViewer;
			if (e.Delta > 0)
				scrollviewer.LineLeft();
			else
				scrollviewer.LineRight();
			e.Handled = true;
		}

	}

}
