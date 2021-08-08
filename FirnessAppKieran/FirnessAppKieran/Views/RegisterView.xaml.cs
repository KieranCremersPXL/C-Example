using FirnessAppKieran.Models;
using FirnessAppKieran.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirnessAppKieran.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterView : ContentPage
	{
		public RegisterView()
		{
			InitializeComponent();
		}

		async void Register(object sender, EventArgs e)
		{
			string URL = "https://extivefit-default-rtdb.europe-west1.firebasedatabase.app/Users.json";

			HttpClient client = new HttpClient();
			if (ePassword.Text == hEPassword.Text)
			{

					User user = new User();
					user.Naam = eNaam.Text;
					user.Email = eMail.Text;





				user.Wachtwoord = "Not implemented";

				var content = JsonConvert.SerializeObject(user);
				await client.PostAsync(URL, new StringContent(content));
			}
			else
			{
				DisplayAlert("Register is gefaald", "Paswoorden komen niet overeen", "OK");
			}
		}
	}
}