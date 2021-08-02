using System;
using BeatSaberMarkupLanguage.Settings;
using SimplyCasualPlugin.UI;
using Zenject;

namespace SimplyCasualPlugin.Managers
{
    public class SettingsViewManager : IInitializable, IDisposable
    {
        private ModSettingsView _settingsView; 

        public SettingsViewManager(ModSettingsView settingsView)
        {
            _settingsView = settingsView;
        }

        public void Initialize()
        {
            BSMLSettings.instance.AddSettingsMenu("SimplyCasual", "SimplyCasualPlugin.UI.ModSettingsView.bsml", _settingsView);
        }

        public void Dispose()
        {
            if (_settingsView == null) return;

            BSMLSettings.instance.RemoveSettingsMenu(this);
            _settingsView = null;
        }
    }
}