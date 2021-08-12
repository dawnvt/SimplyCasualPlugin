using SimplyCasualPlugin.Configuration;
using SimplyCasualPlugin.UI;
using SimplyCasualPlugin.UI.Leaderboard;
using SimplyCasualPlugin.View_Controllers;
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
            Container.BindInterfacesAndSelfTo<SettingsViewController>().AsSingle();
            Container.BindInterfacesAndSelfTo<LeaderboardFloatingScreen>().AsSingle();
        }
    }
}