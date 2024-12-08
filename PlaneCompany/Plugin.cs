using System.Collections;
using System.Reflection;
using System.IO;

using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LethalLib.Modules;
using UnityEngine;

namespace PlaneCompany;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(LethalLib.Plugin.ModGUID)] 

public class PlaneCompanyMod : BaseUnityPlugin {
    
    internal static new ManualLogSource Logger;
    private readonly Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
    private static PlaneCompanyMod instance;
    
    private void Awake() {
        Logger = base.Logger;
        if (instance == null) instance = this;

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

        foreach (var line in asciiArtLines)
        {
            Logger.LogInfo(line);
        }
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        
        string assetDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "PlaneCompany");
        AssetBundle bundle = AssetBundle.LoadFromFile(assetDir);
        Harmony.CreateAndPatchAll(typeof(PlaneCompanyMod));
    }
}