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
    public partial class RecorderSettingsPage : ContentPage
    {
        private readonly RecorderSettingsViewModel _viewModel;

        public RecorderSettingsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RecorderSettingsViewModel();
            _viewModel.GetShouldShowFaceOutline();
            _viewModel.GetIsLiveStreaming();
            _viewModel.GetShouldAutoStartRecording();
            _viewModel.GetStartDelay();
            _viewModel.GetBlurMode();
            _viewModel.GetPausedMode();
            _viewModel.GetShouldSendImmediately();
            _viewModel.GetShouldDisableCameraSwitch();
            _viewModel.GetVideoQuality();
            _viewModel.GetFacing();
            _viewModel.GetMaxDuration();
            _viewModel.GetShouldEnableCoverShot();
            _viewModel.GetShouldConfirmStopRecording();

        }
        
        void OnShouldEnableCoverShotToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldEnableCoverShot)
            {
                _viewModel.ShouldEnableCoverShot = e.Value;
            }
        }
        
        void OnShouldConfirmStopRecordingToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldConfirmStopRecording)
            {
                _viewModel.ShouldConfirmStopRecording = e.Value;
            }
        }
        
        void OnShouldDisableCameraSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldDisableCameraSwitch)
            {
                _viewModel.ShouldDisableCameraSwitch = e.Value;
            }
        }
        void OnShouldSendImmediatelyToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldSendImmediately)
            {
                _viewModel.ShouldSendImmediately = e.Value;
            }
        }
        
        void OnPausedModeToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.PausedMode)
            {
                _viewModel.PausedMode = e.Value;
            }
        }
        void OnBlurModeToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.BlurMode)
            {
                _viewModel.BlurMode = e.Value;
            }
        }
        
        void OnShouldAutoStartRecordingToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldAutoStartRecording)
            {
                _viewModel.ShouldAutoStartRecording = e.Value;
            }
        }
        
        void OnIsLiveStreamingToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.IsLiveStreaming)
            {
                _viewModel.IsLiveStreaming = e.Value;
            }
        }
        
        void OnShouldShowFaceOutlineToggled(object sender, ToggledEventArgs e)
        {
            if (e != null && e.Value != _viewModel.ShouldShowFaceOutline)
            {
                _viewModel.ShouldShowFaceOutline = e.Value;
            }
        }
        
        void OnFacingSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1 && selectedIndex != _viewModel.Facing)
            {
                _viewModel.Facing = selectedIndex;
            }
        }
        
        void OnQualitySelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1 && selectedIndex != _viewModel.VideoQuality)
            {
                _viewModel.VideoQuality = selectedIndex;
            }
        }
        private void SaveSettings(object sender, EventArgs e)
        {
            _viewModel.SaveShouldShowFaceOutline();
            _viewModel.SaveIsLiveStreaming();
            _viewModel.SaveShouldAutoStartRecording();
            _viewModel.SaveStartDelay();
            _viewModel.SaveBlurMode();
            _viewModel.SavePausedMode();
            _viewModel.SaveShouldSendImmediately();
            _viewModel.SaveShouldDisableCameraSwitch();
            _viewModel.SaveVideoQuality();
            _viewModel.SaveFacing();
            _viewModel.SaveMaxDuration();
            _viewModel.SaveShouldEnableCoverShot();
            _viewModel.SaveShouldConfirmStopRecording();

        }
    }
}