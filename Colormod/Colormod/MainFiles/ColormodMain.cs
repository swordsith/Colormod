using System.Collections;
using System.Threading.Tasks;
using ColorMod.API.Patching;
using ColorMod.MainFiles.Menus;
using MelonLoader;
using UnityEngine;

namespace ColorMod.MainFiles
{
    public class ReferencedInfo
    {
        public static string ModName = "ColorMod";
        public static string Version = "1.5.0";
        public static string Developers = "Swordsith & Kanna";
        public static Color C01 { get; set; } //highlight
        public static Color C02 { get; set; } //base
    }
    public class ColormodMain : MelonMod
    {
        public static ColormodMain Instance { get; set; }
        public static bool StartedUI;

        #region Start UI
        public override void OnApplicationStart()
        {
            Instance = new ColormodMain();
                Task.Run(() => { StartPatches.StartPatch(); }); //patch awaits menus
            
        }
        public static IEnumerator WaitMenu()
        {
            while (true)
            {
                GameObject Menu = GameObject.Find("Canvas_QuickMenu(Clone)/Container/");
                if (Menu != null) {MelonLogger.Msg("Menu Found, Starting Init. . ."); StartUI(); MelonCoroutines.Stop(WaitMenu()); }
                yield return new WaitForSeconds(5);
            }
        }
        public static void StartUI() //runs from patch
        {
            if (!StartedUI)
            {
                MainMenu.LaunchMenu();
                StartedUI = true;
            }
        }
        #endregion

        public override void OnUpdate() { MainMenu.OnUpdateTheme(); } //only runs when ui is setup
        public override void OnSceneWasInitialized(int buildIndex, string sceneName) { }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName) { }
        public override void OnApplicationQuit() { }
    }
}
