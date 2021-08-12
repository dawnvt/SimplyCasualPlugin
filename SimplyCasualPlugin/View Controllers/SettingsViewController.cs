using System;
using System.Reflection;
using System.Windows.Forms;
using BeatSaberMarkupLanguage;

using BeatSaberMarkupLanguage.Settings;
using SimplyCasualPlugin.UI;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

using Logger = IPA.Logging.Logger;

namespace SimplyCasualPlugin.View_Controllers
{
    public class SettingsViewController : IInitializable, IDisposable
    {
        //private ModSettingsView _settingsView;
        private readonly Logger _logger;

        public SettingsViewController(/*ModSettingsView settingsView,*/ Logger logger)
        {
            //_settingsView = settingsView;
            _logger = logger;
        }

        public void Initialize()
        {
            //BSMLSettings.instance.AddSettingsMenu("SimplyCasual", "SimplyCasualPlugin.UI.ModSettingsView.bsml", _settingsView);
        }
        
        public void Dispose()
        {
            //if (_settingsView == null) return;
            
            //BSMLSettings.instance.RemoveSettingsMenu(this);
            //_settingsView = null;
        }
    }
}