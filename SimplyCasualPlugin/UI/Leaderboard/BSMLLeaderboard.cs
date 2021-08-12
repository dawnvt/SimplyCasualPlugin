using System;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using SimplyCasualPlugin.Configuration;

namespace SimplyCasualPlugin.UI.Leaderboard
{
    public class BSMLLeaderboard : BSMLAutomaticViewController
    {
        public string ResourceName => "SimplyCasualPlugin.UI.Leaderboard.BSMLLeaderboard.bsml";

        internal LeaderboardTableView table;
        public string lastClicked = "";
        [UIComponent("leaderboard")]
        public void UpdateLeaderboard()
        {
        }
    }
}