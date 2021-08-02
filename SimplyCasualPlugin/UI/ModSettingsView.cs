using BeatSaberMarkupLanguage.Attributes;
using SimplyCasualPlugin.Configuration;

namespace SimplyCasualPlugin.UI
{
	public class ModSettingsView
	{
		private readonly PluginConfig _config;

		public ModSettingsView(PluginConfig config)
		{
			_config = config;
		}

		[UIValue("leaderboardToggle")]
		internal bool EnableLeaderboard
		{
			get => _config.isSimplyCasualEnabled;
			set => _config.isSimplyCasualEnabled = value;
		}
	}
}