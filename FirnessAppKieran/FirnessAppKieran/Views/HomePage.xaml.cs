using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirnessAppKieran.Views
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		public async void Musicpage(Object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MusicListPage());
		}

		public async void FoodPage(Object sender, EventArgs e)
		{
			await Navigation.PushAsync(new FoodPage());
		}

		public async void Test(Object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RegisterView());
		}
	}
}