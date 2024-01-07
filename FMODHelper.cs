using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace FMODHelper;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class FMODHelper : BasePlugin
{
    public override void Load()
    {
        // FMODHelper startup logic
        Log.LogInfo($"FMODHelper {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
