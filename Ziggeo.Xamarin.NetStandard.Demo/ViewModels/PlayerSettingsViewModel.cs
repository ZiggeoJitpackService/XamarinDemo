using System.Collections.Generic;
using Ziggeo.Xamarin.NetStandard.Demo.Utils;

namespace Ziggeo.Xamarin.NetStandard.Demo.ViewModels
{
    public class PlayerSettingsViewModel : BaseViewModel
    {
        private List<ControllerStyleModel> _stylesList = new List<ControllerStyleModel>
        {
            new ControllerStyleModel(0, "DEFAULT"),
            new ControllerStyleModel(1, "MODERN"),
            new ControllerStyleModel(2, "CUBE"),
            new ControllerStyleModel(3, "SPACE"),
            new ControllerStyleModel(4, "MINIMALIST"),
            new ControllerStyleModel(5, "ELEVATE"),
            new ControllerStyleModel(6, "THEATRE"),
        };

        private bool _shouldShowSubtitles;
        private bool _isMuted;
        private int _textColor;
        private int _bufferedColor;
        private int _playedColor;
        private int _tintColor;
        private int _unplayedColor;
        private int _controllerStyle;

        public PlayerSettingsViewModel()
        {
        }

        public List<ControllerStyleModel> StylesList
        {
            get => _stylesList;
            set
            {
                _stylesList = value;
                OnPropertyChanged(nameof(StylesList));
            }
        }

        public bool ShouldShowSubtitles
        {
            get => _shouldShowSubtitles;
            set
            {
                _shouldShowSubtitles = value;
                OnPropertyChanged(nameof(ShouldShowSubtitles));
            }
        }

        public bool IsMuted
        {
            get => _isMuted;
            set
            {
                _isMuted = value;
                OnPropertyChanged(nameof(IsMuted));
            }
        }

        public int TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                OnPropertyChanged(nameof(TextColor));
            }
        }

        public int BufferedColor
        {
            get => _bufferedColor;
            set
            {
                _bufferedColor = value;
                OnPropertyChanged(nameof(BufferedColor));
            }
        }

        public int TintColor
        {
            get => _tintColor;
            set
            {
                _tintColor = value;
                OnPropertyChanged(nameof(TintColor));
            }
        }

        public int PlayedColor
        {
            get => _playedColor;
            set
            {
                _playedColor = value;
                OnPropertyChanged(nameof(PlayedColor));
            }
        }

        public int UnplayedColor
        {
            get => _unplayedColor;
            set
            {
                _unplayedColor = value;
                OnPropertyChanged(nameof(UnplayedColor));
            }
        }

        public int ControllerStyle
        {
            get => _controllerStyle;
            set
            {
                _controllerStyle = value;
                OnPropertyChanged(nameof(ControllerStyle));
            }
        }

        public void GetShouldShowSubtitles()
        {
            ShouldShowSubtitles = App.ZiggeoApplication.PlayerConfig.ShouldShowSubtitles;
        }

        public void GetIsMuted()
        {
            IsMuted = App.ZiggeoApplication.PlayerConfig.IsMuted;
        }

        public void GetTextColor()
        {
            TextColor = App.ZiggeoApplication.PlayerConfig.PlayerStyle.TextColor;
        }

        public void GetBufferedColor()
        {
            BufferedColor = App.ZiggeoApplication.PlayerConfig.PlayerStyle.BufferedColor;
        }

        public void GetTintColor()
        {
            TintColor = App.ZiggeoApplication.PlayerConfig.PlayerStyle.TintColor;
        }

        public void GetPlayedColor()
        {
            PlayedColor = App.ZiggeoApplication.PlayerConfig.PlayerStyle.PlayedColor;
        }

        public void GetUnplayedColor()
        {
            UnplayedColor = App.ZiggeoApplication.PlayerConfig.PlayerStyle.UnplayedColor;
        }

        public void GetControllerStyle()
        {
            ControllerStyle = App.ZiggeoApplication.PlayerConfig.PlayerStyle.ControllerStyle;
        }

        public void SaveShouldShowSubtitles()
        {
            App.ZiggeoApplication.PlayerConfig.ShouldShowSubtitles = ShouldShowSubtitles;
        }

        public void SaveIsMuted()
        {
            App.ZiggeoApplication.PlayerConfig.IsMuted = IsMuted;
        }

        public void SaveTextColor()
        {
            App.ZiggeoApplication.PlayerConfig.PlayerStyle.TextColor = TextColor;
        }

        public void SaveBufferedColor()
        {
            App.ZiggeoApplication.PlayerConfig.PlayerStyle.BufferedColor = BufferedColor;
        }

        public void SaveTintColor()
        {
            App.ZiggeoApplication.PlayerConfig.PlayerStyle.TintColor = TintColor;
        }

        public void SavePlayedColor()
        {
            App.ZiggeoApplication.PlayerConfig.PlayerStyle.PlayedColor = PlayedColor;
        }

        public void SaveUnplayedColor()
        {
            App.ZiggeoApplication.PlayerConfig.PlayerStyle.UnplayedColor = UnplayedColor;
        }

        public void SaveControllerStyle()
        {
            App.ZiggeoApplication.PlayerConfig.PlayerStyle.ControllerStyle = ControllerStyle;
        }
    }
}