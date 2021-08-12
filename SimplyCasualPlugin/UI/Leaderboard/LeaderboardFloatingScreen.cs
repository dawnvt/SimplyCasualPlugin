using System;
using System.Linq;
using System.Reflection;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.FloatingScreen;
using UnityEngine;
using Zenject;

namespace SimplyCasualPlugin.UI.Leaderboard
{
    public class LeaderboardFloatingScreen : IInitializable, IDisposable
    {
        private FloatingScreen _floatingScreen;

        public LeaderboardFloatingScreen()
        {
            
        }

        public void Initialize()
        {
            _floatingScreen = FloatingScreen.CreateFloatingScreen(new Vector2(150, 75), false, new Vector3(0, 0.01f, 2f),
                Quaternion.Euler(90, 0f, 0f));
            BSMLParser.instance.Parse(
                BeatSaberMarkupLanguage.Utilities.GetResourceContent(Assembly.GetExecutingAssembly(),
                    "SimplyCasualPlugin.UI.Leaderboard.BSMLLeaderboard.bsml"), _floatingScreen.gameObject, this);
            _floatingScreen.name = "AccSaberFloatingScreen";
        }

        public void Dispose()
        {
        }
    }
}
