using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MarcTron.Plugin;

namespace AdmobWithXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.bannerAd_view.AdsId = AdmobUnitIds.BannerId;
        }

        private void loadInterstitialAd_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadInterstitial(AdmobUnitIds.InterstitialId);
        }

        private void showInterstitialAd_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.ShowInterstitial();
        }

        private void loadRewardedAd_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadRewardedVideo(AdmobUnitIds.RewardedId);
        }

        private void showRewardedAd_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.ShowRewardedVideo();
        }
    }
}
