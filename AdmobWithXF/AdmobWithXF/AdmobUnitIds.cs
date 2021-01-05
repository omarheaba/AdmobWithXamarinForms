using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AdmobWithXF
{
    public class AdmobUnitIds
    {
        // For Banner Ad
        private static string _bannerId { get; set; }
        public static string BannerId
        {
            get
            {
                if (Device.RuntimePlatform == Device.Android)
                    _bannerId = "ca-app-pub-3940256099942544/6300978111";
                else if (Device.RuntimePlatform == Device.iOS)
                    _bannerId = "ca-app-pub-3940256099942544/2934735716";

                return _bannerId;
            }
        }

        // For Interstitial Ad
        private static string _interstitialId { get; set; }
        public static string InterstitialId
        {
            get
            {
                if (Device.RuntimePlatform == Device.Android)
                    _interstitialId = "ca-app-pub-3940256099942544/1033173712";
                else if (Device.RuntimePlatform == Device.iOS)
                    _interstitialId = "ca-app-pub-3940256099942544/4411468910";

                return _interstitialId;
            }
        }

        
        // For Rewarded Ad
        private static string _rewardedId { get; set; }
        public static string RewardedId
        {
            get
            {
                if (Device.RuntimePlatform == Device.Android)
                    _rewardedId = "ca-app-pub-3940256099942544/5224354917";
                else if (Device.RuntimePlatform == Device.iOS)
                    _rewardedId = "ca-app-pub-3940256099942544/1712485313";

                return _rewardedId;
            }
        }
    }
}