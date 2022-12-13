using Harmony;
using HarmonyLib;
using System;
using System.Reflection;
using ColorMod.API.Tools;
using ColorMod.MainFiles;
using MelonLoader;


namespace ColorMod.API.Patching
{
    public class StartPatches
    {
        public static HarmonyLib.Harmony Instance = new HarmonyLib.Harmony("ColorMod");
        public static void StartPatch()
        {
            MelonLogger.Msg("Starting Patches. . .");
            try
            {
                Instance.Patch(typeof(VRC.UI.Elements.QuickMenu).GetMethod("Start"), null, 
                    new HarmonyLib.HarmonyMethod(HarmonyLib.AccessTools.Method(typeof(ColormodMain), "StartUI")));
            }
            catch { MelonLogger.Msg("Patching Failure!"); }
        }

    }
}