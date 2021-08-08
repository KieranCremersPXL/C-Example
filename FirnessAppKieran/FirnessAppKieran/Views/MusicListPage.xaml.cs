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
	public partial class MusicListPage : ContentPage
	{
		public MusicListPage()
		{
			InitializeComponent();
			BindingContext = new MusicListViewModel(Navigation);
		}
	}
}