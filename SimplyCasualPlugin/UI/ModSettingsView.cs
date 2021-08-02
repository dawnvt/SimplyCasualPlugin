using System.ComponentModel;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using IPA.Config.Data;
using SimplyCasualPlugin.Configuration;

namespace SimplyCasualPlugin.UI
{
    public class ModSettingsView : BSMLAutomaticViewController
    {
        private PluginConfig _config;
        public ModSettingsView(PluginConfig config)
        {
            _config = config;
        }
        
        [UIValue("leaderboardToggle")]
        internal bool EnableLeaderboard
        {
            get => _config.isSimplyCasualEnabled;
            set
            {
                _config.isSimplyCasualEnabled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnableLeaderboard)));
            } 
        }
        
    }
}