using System;
using Xamarin.Forms;
using Ziggeo.Xamarin.NetStandard.Demo.ViewModels;

namespace Ziggeo.Xamarin.NetStandard.Demo.Views
{
    public partial class SettingsPage : ContentPage
    {
        private readonly SettingsViewModel _viewModel;

        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SettingsViewModel();
            _viewModel.GetCustomPlayerMode();
            _viewModel.GetCustomCameraMode();
            _viewModel.GetLostConnectionAction();
            _viewModel.GetShouldStartAsForeground();
            _viewModel.GetShouldTurnOffUploader();
            _viewModel.GetShouldUseWifiOnly();
            _viewModel.GetShouldCloseAfterSuccessfulScan();
        }

        void OnCustomPlayerModeToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.CustomPlayerMode)
            {
                _viewModel.CustomPlayerMode = e.Value;
            }
        }

        void OnCustomCameraModeToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.CustomPlayerMode)
            {
                _viewModel.CustomCameraMode = e.Value;
            }
        }

        void OnShouldStartAsForegroundToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldStartAsForeground)
            {
                _viewModel.ShouldStartAsForeground = e.Value;
            }
        }

        void OnShouldTurnOffUploaderToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldTurnOffUploader)
            {
                _viewModel.ShouldTurnOffUploader = e.Value;
            }
        }

        void OnShouldUseWifiOnlyToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldUseWifiOnly)
            {
                _viewModel.ShouldUseWifiOnly = e.Value;
            }
        }

        void OnShouldCloseAfterSuccessfulScanToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldCloseAfterSuccessfulScan)
            {
                _viewModel.ShouldCloseAfterSuccessfulScan = e.Value;
            }
        }

        void OnLostConnectionActionSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            int action = _viewModel.LostConnectionActionList[selectedIndex].Number;

            if (selectedIndex != -1 && action != _viewModel.LostConnectionAction)
            {
                _viewModel.LostConnectionAction = action;
            }
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            _viewModel.SaveCustomPlayerMode();
            _viewModel.SaveCustomCameraMode();
            _viewModel.SaveShouldStartAsForeground();
            _viewModel.SaveShouldTurnOffUploader();
            _viewModel.SaveShouldUseWifiOnly();
            _viewModel.SaveShouldCloseAfterSuccessfulScan();
            _viewModel.SaveLostConnectionAction();
        }
    }
}