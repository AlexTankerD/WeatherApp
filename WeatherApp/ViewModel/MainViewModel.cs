using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WeatherApp.Model;
using WeatherApp.Model.YandexAPI;
using WeatherApp.Model.YandexAPI.YandexWeatherApi;
using static System.Net.Mime.MediaTypeNames;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WeatherApp.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public MainViewModel()
		{
			OnStartup();
		}
		private Hour _selectedhour { get; set; }
		public Hour SelectedHour
		{
			get { return _selectedhour; }
			set
			{
				_selectedhour = value;
				OnPropertyChanged("SelectedHour");
			}
		}
		private string _background;
		public string Background
		{
			get { return _background; }
			set
			{
				_background = value;
				OnPropertyChanged("Background");
			}
		}
		private string _region { get; set; }
		public string Region
		{
			get { return _region; }
			set
			{
				_region = value;
				OnPropertyChanged("Region");
			}
		}
		private string _search { get; set; }
		public string Search
		{
			get { return _search; }
			set
			{
				_search = value;
				OnPropertyChanged("Search");
			}
		}
		private WeatherResponce _weatherResponce { get; set; }
		public WeatherResponce WeatherResponce
		{
			get { return _weatherResponce; }
			set
			{
				_weatherResponce = value;
				OnPropertyChanged("WeatherResponce");
			}
		}
		private AsyncRelayCommand _searchenterclickcommand;
		public AsyncRelayCommand SearchEnterClickCommand
		{
			get
			{
				return _searchenterclickcommand ?? new AsyncRelayCommand(async (obj) =>
				{
					WeatherResponce = YandexAPIService.GetWeatherResponces(Search);
					if(WeatherResponce == null)
					{
						Region = null;
						return;
					}

				}
				);

			}
		}
		private RelayCommand _command;
		public RelayCommand Command
		{
			get
			{
				return _command ?? new RelayCommand(obj =>
				{
					
				}
				);

			}
		}
		private RelayCommand _mainwindowclosingcommand;
		public RelayCommand MainWindowClosingCommand
		{
			get
			{
				return _mainwindowclosingcommand ?? new RelayCommand(obj =>
				{
					MainWindowClosing();
					Window wnd = obj as Window;
					wnd.Close();
				}
				);

			}
		}
		public void OnStartup()
		{

		}
		public void MainWindowClosing()
		{



		}
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(String propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

			}
		}
	}
}
