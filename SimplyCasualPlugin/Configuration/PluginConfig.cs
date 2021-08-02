using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace SimplyCasualPlugin.Configuration
{
    public class PluginConfig
    {
        public virtual bool isSimplyCasualEnabled { get; set; }
    }
}