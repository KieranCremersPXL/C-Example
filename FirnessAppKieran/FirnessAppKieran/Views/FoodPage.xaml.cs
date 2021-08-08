using FirnessAppKieran.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace FirnessAppKieran.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodPage : ContentPage
	{
		// This handles the Web data request
		private HttpClient _client = new HttpClient();
		public FoodPage()
		{
			InitializeComponent();
		}

		protected async void OnGetList(string url)
		{


				//Getting JSON data from the Web
				var content = await _client.GetStringAsync("https://world.openfoodfacts.org/api/v0/product/" + url + ".json");
			//We deserialize the JSON data from this line
			Root json = JsonConvert.DeserializeObject<Root>(content);

			Food Scannedfood = new Food();
			Scannedfood.product_name = json.product.product_name;
			Scannedfood.allergens=json.product.allergens;
			Scannedfood.energy_value = json.product.nutriments.EnergyKcal100g;
			Scannedfood.image_front_small_url = json.product.image_front_url;

			this.BindingContext = Scannedfood;

			//Then finally we attach the List to the ListView. Seems Simple :)
			string foorname = json.product.product_name;
	

		}

			private async void ScanProduct(Object sender, EventArgs e)
		{
			var scan = new ZXingScannerPage();
			await Navigation.PushAsync(scan);
			scan.OnScanResult += (result) =>
			{
				Device.BeginInvokeOnMainThread(async () =>
				{
					await Navigation.PopAsync();
					OnGetList(result.Text);
		
					scanResultText.Text = result.Text;
				});
			};
		}
		
		public async void Getdata(string result)
		{
			HttpClient client = new HttpClient();
			Uri uri = new Uri("https://world.openfoodfacts.org/api/v0/product/" + result + ".json");

			HttpResponseMessage response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				var item = JsonConvert.DeserializeObject<product>(content);
				Console.WriteLine(item.data.product_name);
			}
			
		}

		class product
		{
			public Productdetails data { get; set; }
		}

		class Productdetails
		{
			public string image_front_small_url { get; set; }
			public string product_name { get; set; }
			public string allergens { get; set; }
			public int energy_value { get; set; }
		}
	}
}