using FirnessAppKieran.Models;
using FirnessAppKieran.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirnessAppKieran.ViewModels
{
	class MusicListViewModel:BaseViewModel
	{
        public INavigation Navigation { get; set; }

        public MusicListViewModel(INavigation navigation)
		{
            this.Navigation = navigation;
            musicList = GetMusics();
			recentMusic = musicList.Where(x => x.IsRecent == true).FirstOrDefault();
		}

		ObservableCollection<Music> musicList;
		public ObservableCollection<Music> MusicList
		{
			get { return musicList; }
			set
			{
				musicList = value;
				OnPropertyChanged();
			}
		}

        private Music recentMusic;
        public Music RecentMusic
        {
            get { return recentMusic; }
            set
            {
                recentMusic = value;
                OnPropertyChanged();
            }
        }

        private Music selectedMusic;
        public Music SelectedMusic
        {
            get { return selectedMusic; }
            set
            {
                selectedMusic = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectionCommand => new Command(PlayMusic);

        private async void PlayMusic()
        {
            if (selectedMusic != null)
            {
                var viewModel = new MusicplayerViewModel(selectedMusic, musicList);
                var playerPage = new MusicplayerPage { BindingContext = viewModel };

                await Navigation.PushAsync(playerPage);
            }
        }

        private ObservableCollection<Music> GetMusics()
        {
            return new ObservableCollection<Music>
            {
                new Music { Title = "Flying", Artist = "AXM", Url = "https://kieranc.ga/Music/AXMFlying.mp3", CoverImage = "https://i.ytimg.com/vi/scie7Ig3T2s/hqdefault.jpg?sqp=-oaymwEZCNACELwBSFXyq4qpAwsIARUAAIhCGAFwAQ==&rs=AOn4CLC3bpVQq4soyGCFRbsb_Z-vvf23Jg", IsRecent = true},
                new Music { Title = "League-FM", Artist = "De Internet Radio Voor Jongeren", Url = "https://ssl.streaming.webmediax.nl/8004/stream", CoverImage = "https://cdn.discordapp.com/icons/521025926322978827/b827f9d7e40eb0ed2b0d52ced3028eb0.png?size=512"},
                new Music { Title = "BearGroup Radio", Artist = "Het Nieuwe Geluid", Url = "https://proxy.pixelhosting.nl/bg/radio.mp3", CoverImage = "https://cdn.discordapp.com/icons/789881654180446270/5f765f080c4bdc1dce2b46b5029f10f3.png?size=256"},
            };
        }
    }
}
