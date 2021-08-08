using FirnessAppKieran.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirnessAppKieran.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			this.BindingContext = new LoginViewModel();
		}

		private async void Login(object sender, EventArgs e)
		{
			
			

		}
		private void Register(object sender, EventArgs e)
		{
			Navigation.PushAsync(new RegisterView());

		}
	}
}