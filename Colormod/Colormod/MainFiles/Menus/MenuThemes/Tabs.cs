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
        public static GameObject MuteIcon;
        public static GameObject MuteButton;
        public static GameObject SafeIcon;
        public static GameObject SafeButton;
        public static GameObject WingL;
        public static GameObject WingR;
        public static GameObject FPS;
        public static GameObject Ping;
        public static GameObject FPSBack;

        public static GameObject LaunchTab;
        public static GameObject AlertTab;
        public static GameObject HereTab;
        public static GameObject CameraTab;
        public static GameObject SoundTab;
        public static GameObject OptionsTab;

        public static GameObject LaunchIcon;
        public static GameObject AlertIcon;
        public static GameObject HereIcon;
        public static GameObject CameraIcon;
        public static GameObject SoundIcon;
        public static GameObject OptionsIcon;
        #endregion
        public static bool UsingTabImage { get; set; }
        public static void TabOBJ()
        {
            #region OBJs
            //===Tabs
            LaunchTab   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Background");
            AlertTab    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Background");
            HereTab     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Background");
            CameraTab   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Background");
            SoundTab    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Background");
            OptionsTab  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Background");

            //===TabIcons
            LaunchIcon  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Icon");
            AlertIcon   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Icon");
            HereIcon    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Icon");
            CameraIcon  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Icon");
            SoundIcon   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Icon");
            OptionsIcon = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Icon");

            MuteIcon   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/MicButton/Icon");
            MuteButton = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/MicButton");
            SafeIcon   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Toggle_SafeMode/Icon");
            SafeButton = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Toggle_SafeMode");
            WingL      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Button/Icon");
            WingR      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Right/Button/Icon");
            FPS        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Text_FPS");
            Ping       = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Text_Ping");
            FPSBack    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Background");
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
            WingL.     GetComponent<Image>().color = ReferencedInfo.C01;
            WingR.     GetComponent<Image>().color = ReferencedInfo.C01;
            FPSBack.   GetComponent<Image>().color = ReferencedInfo.C02;
            FPS.       GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            Ping.      GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;

            Sprite TABBack = MainMenu.TabSprite;
            if (JasonConfig.ThemeMode == "0") //checks if custom theme
            {
                if (!JasonConfig.TabBool) //colors with theme if not using custom image
                {
                    LaunchTab. GetComponent<Image>().color = ReferencedInfo.C02;
                    AlertTab.  GetComponent<Image>().color = ReferencedInfo.C02;
                    HereTab.   GetComponent<Image>().color = ReferencedInfo.C02;
                    CameraTab. GetComponent<Image>().color = ReferencedInfo.C02;
                    SoundTab.  GetComponent<Image>().color = ReferencedInfo.C02;
                    OptionsTab.GetComponent<Image>().color = ReferencedInfo.C02;
                    UsingTabImage = false; return;
                }  //if custom theme wants no button image skips
                if (!UsingTabImage) return;
                LaunchTab. GetComponent<Image>().overrideSprite = TABBack;
                AlertTab.  GetComponent<Image>().overrideSprite = TABBack;
                HereTab.   GetComponent<Image>().overrideSprite = TABBack;
                CameraTab. GetComponent<Image>().overrideSprite = TABBack;
                SoundTab.  GetComponent<Image>().overrideSprite = TABBack;
                OptionsTab.GetComponent<Image>().overrideSprite = TABBack;
                LaunchTab. GetComponent<Image>().color = Color.white;
                AlertTab.  GetComponent<Image>().color = Color.white;
                HereTab.   GetComponent<Image>().color = Color.white;
                CameraTab. GetComponent<Image>().color = Color.white;
                SoundTab.  GetComponent<Image>().color = Color.white;
                OptionsTab.GetComponent<Image>().color = Color.white;
            }
            else //uses set theme images
            { 
                LaunchTab. GetComponent<Image>().overrideSprite = TABBack;
                AlertTab.  GetComponent<Image>().overrideSprite = TABBack;
                HereTab.   GetComponent<Image>().overrideSprite = TABBack;
                CameraTab. GetComponent<Image>().overrideSprite = TABBack;
                SoundTab.  GetComponent<Image>().overrideSprite = TABBack;
                OptionsTab.GetComponent<Image>().overrideSprite = TABBack;
                LaunchTab. GetComponent<Image>().color = Color.white;
                AlertTab.  GetComponent<Image>().color = Color.white;
                HereTab.   GetComponent<Image>().color = Color.white;
                CameraTab. GetComponent<Image>().color = Color.white;
                SoundTab.  GetComponent<Image>().color = Color.white;
                OptionsTab.GetComponent<Image>().color = Color.white;
            }
            #endregion

        }
        public static void TabsOnUP()
        {
            #region TabsOnUPTheme
            SafeIcon.   GetComponent<Image>().color = ReferencedInfo.C01;
            LaunchIcon. GetComponent<Image>().color = ReferencedInfo.C01;
            AlertIcon.  GetComponent<Image>().color = ReferencedInfo.C01;
            HereIcon.   GetComponent<Image>().color = ReferencedInfo.C01;
            CameraIcon. GetComponent<Image>().color = ReferencedInfo.C01;
            SoundIcon.  GetComponent<Image>().color = ReferencedInfo.C01;
            OptionsIcon.GetComponent<Image>().color = ReferencedInfo.C01;
            MuteButton. GetComponent<Image>().color = ReferencedInfo.C02;
            SafeButton. GetComponent<Image>().color = ReferencedInfo.C02;
            #endregion
        }
    }
}