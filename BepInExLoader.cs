using BepInEx;
using UnhollowerRuntimeLib;
using HarmonyLib;

namespace RF5.HisaCat.Lib.TextHelper
{

    [BepInPlugin(GUID, MODNAME, VERSION)]
    public class BepInExLoader : BepInEx.IL2CPP.BasePlugin
    {
        public const string
            MODNAME = "Lib.TextHelper",
            AUTHOR = "HisaCat",
            GUID = "com." + AUTHOR + "." + MODNAME,
            VERSION = "1.0.0.0";

        public static BepInEx.Logging.ManualLogSource log;
        public BepInExLoader()
        {
            log = Log;
        }

        public override void Load()
        {
            try
            {
                Harmony.CreateAndPatchAll(typeof(SV));
            }
            catch
            {
                log.LogError($"[{GUID}] FAILED to Register Il2Cpp Types!");
            }
        }

        [HarmonyPatch]
        public class SVPatcher
        {
            private static bool IsInitialized = false;
            [HarmonyPatch(typeof(SV), nameof(SV.CreateUIRes))]
            [HarmonyPostfix]
            public static void CreateUIResPostfix(SV __instance)
            {
                Tester.DoTest();
            }
        }
    }
}
