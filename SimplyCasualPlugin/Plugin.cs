using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;
using IPA.Config.Stores;
using SimplyCasualPlugin.Installers;
using Config = IPA.Config.Config;
using SimplyCasualPlugin.Configuration;

namespace SimplyCasualPlugin
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        private PluginConfig _config;

        [Init]
        public void Init(Zenjector zenjector, PluginConfig config)
        {
            zenjector.OnMenu<MenuInstaller>().WithParameters(_config);
        }

        [OnEnable]
        public void OnEnable()
        {
        }

        [OnDisable]
        public void OnDisable()
        {
        }
    }
}
