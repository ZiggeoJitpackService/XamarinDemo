using System.Collections.Generic;
using Ziggeo.Xamarin.NetStandard.Demo.Utils;

namespace Ziggeo.Xamarin.NetStandard.Demo.ViewModels
{
    public class RecorderSettingsViewModel : BaseViewModel
    {
        public const int DefaultStartDelay = 3; // seconds

        private List<ControllerStyleModel> _cameraFacing = new List<ControllerStyleModel>
        {
            new ControllerStyleModel(0, "Rear"),
            new ControllerStyleModel(1, "Front"),
        };
        private List<ControllerStyleModel> _quality = new List<ControllerStyleModel>
        {
            new ControllerStyleModel(0, "High"),
            new ControllerStyleModel(1, "Medium"),
            new ControllerStyleModel(2, "Low"),
        };

        private bool _shouldShowFaceOutline;
        private bool _isLiveStreaming;
        private bool _shouldAutoStartRecording;
        private int _startDelay = DefaultStartDelay;
        private bool _blurMode;
        private bool _shouldSendImmediately;
        private bool _shouldDisableCameraSwitch;
        private bool _shouldEnableCoverShot;
        private bool _pausedMode;
        private bool _shouldConfirmStopRecording;
        private int _videoQuality;
        private int _facing;
        private long _maxDuration;

        private string _titleText;
        private string _mesText;
        private string _posBtnText;
        private string _negBtnText;
        
        public List<ControllerStyleModel> CameraFacing
        {
            get => _cameraFacing;
            set
            {
                _cameraFacing = value;
                OnPropertyChanged(nameof(CameraFacing));
            }
        }
        
        public List<ControllerStyleModel> Quality
        {
            get => _quality;
            set
            {
                _quality = value;
                OnPropertyChanged(nameof(Quality));
            }
        }

        public bool ShouldShowFaceOutline
        {
            get => _shouldShowFaceOutline;
            set
            {
                _shouldShowFaceOutline = value;
                OnPropertyChanged(nameof(ShouldShowFaceOutline));
            }
        }

        public bool IsLiveStreaming
        {
            get => _isLiveStreaming;
            set
            {
                _isLiveStreaming = value;
                OnPropertyChanged(nameof(IsLiveStreaming));
            }
        }

        public bool ShouldAutoStartRecording
        {
            get => _shouldAutoStartRecording;
            set
            {
                _shouldAutoStartRecording = value;
                OnPropertyChanged(nameof(ShouldAutoStartRecording));
            }
        }

        public int StartDelay
        {
            get => _startDelay;
            set
            {
                _startDelay = value;
                OnPropertyChanged(nameof(StartDelay));
            }
        }

        public bool BlurMode
        {
            get => _blurMode;
            set
            {
                _blurMode = value;
                OnPropertyChanged(nameof(BlurMode));
            }
        }

        public bool PausedMode
        {
            get => _pausedMode;
            set
            {
                _pausedMode = value;
                OnPropertyChanged(nameof(PausedMode));
            }
        }

        public bool ShouldSendImmediately
        {
            get => _shouldSendImmediately;
            set
            {
                _shouldSendImmediately = value;
                OnPropertyChanged(nameof(ShouldSendImmediately));
            }
        }

        public bool ShouldDisableCameraSwitch
        {
            get => _shouldDisableCameraSwitch;
            set
            {
                _shouldDisableCameraSwitch = value;
                OnPropertyChanged(nameof(ShouldDisableCameraSwitch));
            }
        }

        public bool ShouldEnableCoverShot
        {
            get => _shouldEnableCoverShot;
            set
            {
                _shouldEnableCoverShot = value;
                OnPropertyChanged(nameof(ShouldEnableCoverShot));
            }
        }

        public bool ShouldConfirmStopRecording
        {
            get => _shouldConfirmStopRecording;
            set
            {
                _shouldConfirmStopRecording = value;
                OnPropertyChanged(nameof(ShouldConfirmStopRecording));
            }
        }

        public int VideoQuality
        {
            get => _videoQuality;
            set
            {
                _videoQuality = value;
                OnPropertyChanged(nameof(VideoQuality));
            }
        }

        public int Facing
        {
            get => _facing;
            set
            {
                _facing = value;
                OnPropertyChanged(nameof(Facing));
            }
        }

        public long MaxDuration
        {
            get => _maxDuration;
            set
            {
                _maxDuration = value;
                OnPropertyChanged(nameof(MaxDuration));
            }
        }

        public string TitleText
        {
            get => _titleText;
            set
            {
                _titleText = value;
                OnPropertyChanged(nameof(TitleText));
            }
        }

        public string MesText
        {
            get => _mesText;
            set
            {
                _mesText = value;
                OnPropertyChanged(nameof(MesText));
            }
        }

        public string PosBtnText
        {
            get => _posBtnText;
            set
            {
                _posBtnText = value;
                OnPropertyChanged(nameof(PosBtnText));
            }
        }

        public string NegBtnText
        {
            get => _negBtnText;
            set
            {
                _negBtnText = value;
                OnPropertyChanged(nameof(NegBtnText));
            }
        }
        
        public void GetIsLiveStreaming()
        {
            IsLiveStreaming = App.ZiggeoApplication.CameraRecorderConfig.IsLiveStreaming;
        }

        public void SaveIsLiveStreaming()
        {
            App.ZiggeoApplication.CameraRecorderConfig.IsLiveStreaming = IsLiveStreaming;
        }
        
        public void GetShouldShowFaceOutline()
        {
            ShouldShowFaceOutline = App.ZiggeoApplication.CameraRecorderConfig.ShouldShowFaceOutline;
        }

        public void SaveShouldShowFaceOutline()
        {
            App.ZiggeoApplication.CameraRecorderConfig.ShouldShowFaceOutline = ShouldShowFaceOutline;
        }
        
        public void GetShouldAutoStartRecording()
        {
            ShouldAutoStartRecording = App.ZiggeoApplication.CameraRecorderConfig.ShouldAutoStartRecording;
        }

        public void SaveShouldAutoStartRecording()
        {
            App.ZiggeoApplication.CameraRecorderConfig.ShouldAutoStartRecording = ShouldAutoStartRecording;
        }
        
        public void GetStartDelay()
        {
            StartDelay = App.ZiggeoApplication.CameraRecorderConfig.StartDelay;
        }

        public void SaveStartDelay()
        {
            App.ZiggeoApplication.CameraRecorderConfig.StartDelay = StartDelay;
        }
        
        public void GetBlurMode()
        {
            BlurMode = App.ZiggeoApplication.CameraRecorderConfig.BlurMode;
        }

        public void SaveBlurMode()
        {
            App.ZiggeoApplication.CameraRecorderConfig.BlurMode = BlurMode;
        }
        
        public void GetPausedMode()
        {
            PausedMode = App.ZiggeoApplication.CameraRecorderConfig.PausedMode;
        }

        public void SavePausedMode()
        {
            App.ZiggeoApplication.CameraRecorderConfig.PausedMode = PausedMode;
        }
        
        public void GetShouldSendImmediately()
        {
            ShouldSendImmediately = App.ZiggeoApplication.CameraRecorderConfig.ShouldSendImmediately;
        }

        public void SaveShouldSendImmediately()
        {
            App.ZiggeoApplication.CameraRecorderConfig.ShouldSendImmediately = ShouldSendImmediately;
        }
        
        public void GetShouldDisableCameraSwitch()
        {
            ShouldDisableCameraSwitch = App.ZiggeoApplication.CameraRecorderConfig.ShouldDisableCameraSwitch;
        }

        public void SaveShouldDisableCameraSwitch()
        {
            App.ZiggeoApplication.CameraRecorderConfig.ShouldDisableCameraSwitch = ShouldDisableCameraSwitch;
        }
        
        public void GetShouldEnableCoverShot()
        {
            ShouldEnableCoverShot = App.ZiggeoApplication.CameraRecorderConfig.ShouldEnableCoverShot;
        }

        public void SaveShouldEnableCoverShot()
        {
            App.ZiggeoApplication.CameraRecorderConfig.ShouldEnableCoverShot = ShouldEnableCoverShot;
        }
        
        public void GetShouldConfirmStopRecording()
        {
            ShouldConfirmStopRecording = App.ZiggeoApplication.CameraRecorderConfig.ShouldConfirmStopRecording;
        }

        public void SaveShouldConfirmStopRecording()
        {
            App.ZiggeoApplication.CameraRecorderConfig.ShouldConfirmStopRecording = ShouldConfirmStopRecording;
        }

        public void GetVideoQuality()
        {
            VideoQuality = App.ZiggeoApplication.CameraRecorderConfig.VideoQuality;
        }

        public void SaveVideoQuality()
        {
            App.ZiggeoApplication.CameraRecorderConfig.VideoQuality = VideoQuality;
        }
        
        public void GetFacing()
        {
            Facing = App.ZiggeoApplication.CameraRecorderConfig.Facing;
        }

        public void SaveFacing()
        {
            App.ZiggeoApplication.CameraRecorderConfig.Facing = Facing;
        }
        
        public void GetMaxDuration()
        {
            MaxDuration = App.ZiggeoApplication.CameraRecorderConfig.MaxDuration;
        }

        public void SaveMaxDuration()
        {
            App.ZiggeoApplication.CameraRecorderConfig.MaxDuration = MaxDuration;
        }
        
        public void GetTitleText()
        {
            TitleText = App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.titleText;
        }

        public void SaveTitleText()
        {
            App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.titleText = TitleText;
        }
        
        public void GetMesText()
        {
            MesText = App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.mesText;
        }

        public void SaveMesText()
        {
            App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.mesText = MesText;
        }
        
        public void GetPosBtnText()
        {
            PosBtnText = App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.posBtnText;
        }

        public void SavePosBtnText()
        {
            App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.posBtnText = PosBtnText;
        }
        
        public void GetNegBtnText()
        {
            NegBtnText = App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.negBtnText;
        }

        public void SaveNegBtnText()
        {
            App.ZiggeoApplication.CameraRecorderConfig.StopRecordingConfirmationDialogConfig.negBtnText = NegBtnText;
        }
    }
}