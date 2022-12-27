using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ziggeo.Xamarin.NetStandard.Demo.ViewModels;

namespace Ziggeo.Xamarin.NetStandard.Demo.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerSettingsPage : ContentPage
    {

        private readonly PlayerSettingsViewModel _viewModel;

        public PlayerSettingsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PlayerSettingsViewModel();
            _viewModel.GetIsMuted();
            _viewModel.GetShouldShowSubtitles();
            _viewModel.GetControllerStyle();
            _viewModel.GetBufferedColor();
            _viewModel.GetTextColor();
            _viewModel.GetTintColor();
            _viewModel.GetPlayedColor();
            _viewModel.GetUnplayedColor();
        }

        void OnIsMutedToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.IsMuted)
            {
             _viewModel.IsMuted = e.Value;
            }
        }

        void OnShouldShowSubtitlesToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldShowSubtitles)
            {
             _viewModel.ShouldShowSubtitles = e.Value;
            }
        }
        
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1 && selectedIndex != _viewModel.ControllerStyle)
            {
                _viewModel.ControllerStyle = selectedIndex;
            }
        }
        private void SaveSettings(object sender, EventArgs e)
        {
            _viewModel.SaveIsMuted();
            _viewModel.SaveControllerStyle();
            _viewModel.SaveBufferedColor();
            _viewModel.SaveTextColor();
            _viewModel.SaveTintColor();
            _viewModel.SavePlayedColor();
            _viewModel.SaveUnplayedColor();
            _viewModel.SaveShouldShowSubtitles();
        }
    }
    
}