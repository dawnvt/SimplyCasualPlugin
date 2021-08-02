using SimplyCasualPlugin.Configuration;
using SiraUtil;
using Zenject;

namespace SimplyCasualPlugin.Installers
{
    public class MenuInstaller : Installer
    {
        private readonly PluginConfig _config;
        public MenuInstaller(PluginConfig config)
        {
            _config = config;
        }
        
        public override void InstallBindings()
        {
            Container.BindInstance(_config).AsSingle();
            Container.BindInterfacesAndSelfTo<MenuInstaller>().AsSingle();
        }
    }
}