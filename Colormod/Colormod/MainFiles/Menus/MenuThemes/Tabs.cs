using System;
using MelonLoader;
using ColorMod.API.Tools;
using MelonLoader.TinyJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ProjectR.API.ObjUtils;

namespace ColorMod.MainFiles.Menus.MenuThemes
{
    public class Tabs
    {
        #region StaticGOBJs
        public static Image MuteIcon;
        public static Image MuteButton;
        public static Image SafeIcon;
        public static Image SafeButton;
        public static Image WingL;
        public static Image WingR;
        public static TextMeshProUGUI FPS;
        public static TextMeshProUGUI Ping;
        public static Image FPSBack;

        public static Image LaunchTab;
        public static Image AlertTab;
        public static Image HereTab;
        public static Image CameraTab;
        public static Image SoundTab;
        public static Image OptionsTab;

        public static Image LaunchIcon;
        public static Image AlertIcon;
        public static Image HereIcon;
        public static Image CameraIcon;
        public static Image SoundIcon;
        public static Image OptionsIcon;
        #endregion
        public static GameObject HLG;
        public static GameObject Window;
        public static bool UsingTabImage { get; set; }
        public static GameObject FindOBJ(GameObject OBJ, string objectname) { return OBJ.transform.Find(objectname).gameObject; }
        public static void TabOBJ()
        {
            #region OBJs
            HLG         = GameObject.Find("aCanvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
            Window      = GameObject.Find("aCanvas_QuickMenu(Clone)/CanvasGroup/Container/Window/");
            LaunchTab   = FindOBJ(HLG, "Page_Dashboard/Background").GetComponent<Image>();
            AlertTab    = FindOBJ(HLG, "Page_Notifications/Background").GetComponent<Image>();
            HereTab     = FindOBJ(HLG, "Page_Here/Background").GetComponent<Image>();
            CameraTab   = FindOBJ(HLG, "Page_Camera/Background").GetComponent<Image>();
            SoundTab    = FindOBJ(HLG, "Page_AudioSettings/Background").GetComponent<Image>();
            OptionsTab  = FindOBJ(HLG, "Page_Settings/Background").GetComponent<Image>();

            LaunchIcon  = FindOBJ(HLG, "Page_Dashboard/Icon").GetComponent<Image>();
            AlertIcon   = FindOBJ(HLG, "Page_Notifications/Icon").GetComponent<Image>();
            HereIcon    = FindOBJ(HLG, "Page_Here/Icon").GetComponent<Image>();
            CameraIcon  = FindOBJ(HLG, "Page_Camera/Icon").GetComponent<Image>();
            SoundIcon   = FindOBJ(HLG, "Page_AudioSettings/Icon").GetComponent<Image>();
            OptionsIcon = FindOBJ(HLG, "Page_Settings/Icon").GetComponent<Image>();

            MuteIcon   = FindOBJ(Window, "MicButton/Icon").GetComponent<Image>();
            MuteButton = FindOBJ(Window, "MicButton").GetComponent<Image>();
            SafeIcon   = FindOBJ(Window, "Toggle_SafeMode/Icon").GetComponent<Image>();
            SafeButton = FindOBJ(Window, "Toggle_SafeMode").GetComponent<Image>();
            WingL      = FindOBJ(Window, "Wing_Left/Button/Icon").GetComponent<Image>();
            WingR      = FindOBJ(Window, "Wing_Right/Button/Icon").GetComponent<Image>();
            FPS        = FindOBJ(Window, "QMNotificationsArea/DebugInfoPanel/Panel/Text_FPS").GetComponent<TextMeshProUGUI>();
            Ping       = FindOBJ(Window, "QMNotificationsArea/DebugInfoPanel/Panel/Text_Ping").GetComponent<TextMeshProUGUI>();
            FPSBack    = FindOBJ(Window, "QMNotificationsArea/DebugInfoPanel/Panel/Background").GetComponent<Image>();
            #endregion
            TabsTheme();
        }

        public static void TabsTheme()
        {
            MenuUtils.SkipUpdate(MuteButton); //skips update to avoid tabs recoloring themselves
            MenuUtils.SkipUpdate(SafeButton);
            MenuUtils.SkipUpdate(LaunchTab);
            MenuUtils.SkipUpdate(AlertTab);
            MenuUtils.SkipUpdate(HereTab);
            MenuUtils.SkipUpdate(CameraTab);
            MenuUtils.SkipUpdate(SoundTab);
            MenuUtils.SkipUpdate(OptionsTab);

            #region TabsTheme
            WingL.     color = ReferencedInfo.C01;
            WingR.     color = ReferencedInfo.C01;
            FPSBack.   color = ReferencedInfo.C02;
            FPS.       color = ReferencedInfo.C01;
            Ping.      color = ReferencedInfo.C01;

            UsingTabImage = true;
            Sprite TABBack = MainMenu.TabSprite;
            if (JasonConfig.ThemeMode == "0") //checks if custom theme
            {
                if (!JasonConfig.TabBool) //colors with theme if not using custom image
                {
                    LaunchTab. color = ReferencedInfo.C02;
                    AlertTab.  color = ReferencedInfo.C02;
                    HereTab.   color = ReferencedInfo.C02;
                    CameraTab. color = ReferencedInfo.C02;
                    SoundTab.  color = ReferencedInfo.C02;
                    OptionsTab.color = ReferencedInfo.C02;
                    UsingTabImage = false; return;
                }  //if custom theme wants no button image skips
                if (!UsingTabImage) return;
                LaunchTab. overrideSprite = TABBack;
                AlertTab.  overrideSprite = TABBack;
                HereTab.   overrideSprite = TABBack;
                CameraTab. overrideSprite = TABBack;
                SoundTab.  overrideSprite = TABBack;
                OptionsTab.overrideSprite = TABBack;
                LaunchTab. color = Color.white;
                AlertTab.  color = Color.white;
                HereTab.   color = Color.white;
                CameraTab. color = Color.white;
                SoundTab.  color = Color.white;
                OptionsTab.color = Color.white;
            }
            else //uses set theme images
            { 
                LaunchTab. overrideSprite = TABBack;
                AlertTab.  overrideSprite = TABBack;
                HereTab.   overrideSprite = TABBack;
                CameraTab. overrideSprite = TABBack;
                SoundTab.  overrideSprite = TABBack;
                OptionsTab.overrideSprite = TABBack;
                LaunchTab. color = Color.white;
                AlertTab.  color = Color.white;
                HereTab.   color = Color.white;
                CameraTab. color = Color.white;
                SoundTab.  color = Color.white;
                OptionsTab.color = Color.white;
            }
            #endregion

        }
        public static void TabsOnUP()
        {
            #region TabsOnUPTheme
            SafeIcon.   color = ReferencedInfo.C01;
            LaunchIcon. color = ReferencedInfo.C01;
            AlertIcon.  color = ReferencedInfo.C01;
            HereIcon.   color = ReferencedInfo.C01;
            CameraIcon. color = ReferencedInfo.C01;
            SoundIcon.  color = ReferencedInfo.C01;
            OptionsIcon.color = ReferencedInfo.C01;
            MuteButton. color = ReferencedInfo.C02;
            SafeButton. color = ReferencedInfo.C02;
            #endregion
        }
    }
}