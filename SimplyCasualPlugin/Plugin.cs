using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;
using SimplyCasualPlugin.Installers;
using SimplyCasualPlugin.Configuration;

namespace SimplyCasualPlugin
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        private PluginConfig _config;
        private IPALogger _logger;

        public Plugin(PluginConfig config, IPALogger logger)
        {
            _config = config;
            _logger = logger;
        }

        [Init]
        public void Init(Zenjector zenjector, PluginConfig config, IPALogger logger)
        {
            zenjector.OnMenu<MenuInstaller>().WithParameters(_config, _logger);
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
