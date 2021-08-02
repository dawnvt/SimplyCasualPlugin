using IPA;
using IPA.Config;
using IPA.Config.Stores;
using IPA.Logging;
using SiraUtil.Zenject;
using SimplyCasualPlugin.Installers;
using SimplyCasualPlugin.Configuration;

namespace SimplyCasualPlugin
{
	[Plugin(RuntimeOptions.DynamicInit)]
	public class Plugin
	{
		[Init]
		public void Init(Logger logger, Config config, Zenjector zenjector)
		{
			zenjector.OnMenu<MenuInstaller>().WithParameters(config.Generated<PluginConfig>());
		}

		[OnEnable, OnDisable]
		public void OnStateChanged()
		{
		}
	}
}