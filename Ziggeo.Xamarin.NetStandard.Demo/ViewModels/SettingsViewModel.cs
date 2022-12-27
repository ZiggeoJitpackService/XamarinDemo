using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Ziggeo.Xamarin.NetStandard.Demo.Utils;

namespace Ziggeo.Xamarin.NetStandard.Demo.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private List<ControllerStyleModel> _lostConnectionActionList = new List<ControllerStyleModel>
        {
            new ControllerStyleModel(552, "RELOAD VIDEO"),
            new ControllerStyleModel(553, "ERROR NOTIFICATION"),
            new ControllerStyleModel(554, "DELETE VIDEO")
        };
        private bool _customPlayerMode;
        private bool _customCameraMode;
        private bool _shouldCloseAfterSuccessfulScan;
        private bool _shouldUseWifiOnly;
        private bool _shouldTurnOffUploader;
        private bool _shouldStartAsForeground;
        private int _lostConnectionAction;

        public List<ControllerStyleModel> LostConnectionActionList
        {
            get => _lostConnectionActionList;
            set
            {
                _lostConnectionActionList = value;
                OnPropertyChanged(nameof(LostConnectionActionList));
            }
        }

        public bool CustomPlayerMode
        {
            get => _customPlayerMode;
            set {  _customPlayerMode = value; OnPropertyChanged(nameof(CustomPlayerMode));  }
        }
        
        public bool CustomCameraMode
        {
            get => _customCameraMode;
            set {  _customCameraMode = value; OnPropertyChanged(nameof(CustomCameraMode));  }
        }
        
        public bool ShouldCloseAfterSuccessfulScan
        {
            get => _shouldCloseAfterSuccessfulScan;
            set {  _shouldCloseAfterSuccessfulScan = value; OnPropertyChanged(nameof(ShouldCloseAfterSuccessfulScan));  }
        }

        public bool ShouldTurnOffUploader {
            get => _shouldTurnOffUploader;
            set {  _shouldTurnOffUploader = value; OnPropertyChanged(nameof(ShouldTurnOffUploader));  }
        }
        
        public bool ShouldUseWifiOnly {
            get => _shouldUseWifiOnly;
            set {  _shouldUseWifiOnly = value; OnPropertyChanged(nameof(ShouldUseWifiOnly));  }
        }
        
        public bool ShouldStartAsForeground {
            get => _shouldStartAsForeground;
            set {  _shouldStartAsForeground = value; OnPropertyChanged(nameof(ShouldStartAsForeground));  }
        }
        
        public int LostConnectionAction {
            get => _lostConnectionAction;
            set {  _lostConnectionAction = value; OnPropertyChanged(nameof(LostConnectionAction));  }
        }

        public SettingsViewModel()
        {
        }

        public void GetCustomPlayerMode()
        {
            CustomPlayerMode = Preferences.Get(Constants.CustomPlayerMode, false);
        }
        
        public void GetCustomCameraMode()
        {
            CustomCameraMode = Preferences.Get(Constants.CustomCameraMode, false);
        }

        public void GetShouldCloseAfterSuccessfulScan()
        {
            ShouldCloseAfterSuccessfulScan = App.ZiggeoApplication.QrScannerConfig.ShouldCloseAfterSuccessfulScan;
        }

        public void GetShouldTurnOffUploader()
        {
            ShouldTurnOffUploader = App.ZiggeoApplication.UploaderConfig.ShouldTurnOffUploader;
        }
        
        public void GetShouldUseWifiOnly()
        {
            ShouldUseWifiOnly = App.ZiggeoApplication.UploaderConfig.ShouldUseWifiOnly;
        }
        
        public void GetShouldStartAsForeground()
        {
            ShouldStartAsForeground = App.ZiggeoApplication.UploaderConfig.ShouldStartAsForeground;
        }
        
        public void GetLostConnectionAction()
        {
            LostConnectionAction = App.ZiggeoApplication.UploaderConfig.LostConnectionAction;
        }

        public void SaveCustomPlayerMode()
         {
             Preferences.Set(Constants.CustomPlayerMode, CustomPlayerMode);
         }
         
         public void SaveCustomCameraMode()
         {
             Preferences.Set(Constants.CustomCameraMode, CustomCameraMode);
         }

         public void SaveShouldCloseAfterSuccessfulScan()
         {
             App.ZiggeoApplication.QrScannerConfig.ShouldCloseAfterSuccessfulScan = ShouldCloseAfterSuccessfulScan;
         }

         public void SaveShouldTurnOffUploader()
         {
             App.ZiggeoApplication.UploaderConfig.ShouldTurnOffUploader = ShouldTurnOffUploader;
         }
         
         public void SaveShouldUseWifiOnly()
         {
             App.ZiggeoApplication.UploaderConfig.ShouldUseWifiOnly = ShouldUseWifiOnly;
         }
         
         public void SaveShouldStartAsForeground()
         {
             App.ZiggeoApplication.UploaderConfig.ShouldStartAsForeground = ShouldStartAsForeground;
         }
         
         public void SaveLostConnectionAction()
         {
             App.ZiggeoApplication.UploaderConfig.LostConnectionAction = LostConnectionAction;
         }
    }
}