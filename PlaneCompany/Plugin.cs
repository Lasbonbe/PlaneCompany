using BepInEx;
using BepInEx.Logging;

namespace PlaneCompany;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;

        string[] asciiArtLines = new string[]
        {
            "`,        .'",
            "                                     `M,    .|'",
            "                                      `M,  .|'",
            "                ,e..__            .|333MMM|||33333M.          __..e,",
            "                C3333333ee..__  .|333333MM||3333333M. __..ee3333333D",
            "                 'Y333333333333||333|3333333333M333MM333333333333P'",
            "                   'Y3333333333|3333||33333333MM3333M3333333333P'",
            "                     'Y3333333||3333|||333333MMM3333MM3333333P'",
            "                       'Y33333||3333||||3333MMMM3333MM33333P'",
            "                         'Y333||@@@@||`||$$MM\"MM@@@@MM333P'",
            "                           'Y3|@@@@||| .|$$M, MMM@@@@M3P'",
            "                             'Y$$$$|||.|$'`$M,MMM$$$$P'",
            "                               'Y33|||||$$$$MMMMM33P'",
            "                                 'Y||||$$$$$$MMMMP'",
            "                                   'Y||$$|M$$MMP'",
            "                                     'Y|||MMMP'",
            "                                       `Y|MM'",
            "                                         `'`",
        };

        foreach (string line in asciiArtLines)
        {
            Logger.LogInfo(line);
        }
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

    }
}