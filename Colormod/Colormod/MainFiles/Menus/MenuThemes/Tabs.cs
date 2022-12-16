using ColorMod.API.Tools;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ProjectR.API.ObjUtils;
using System.Collections.Generic;

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
        public static GameObject HLG;
        public static GameObject Window;
        #endregion

        public static bool UsingTabImage { get; set; }
        public static GameObject FindOBJ(GameObject OBJ, string objectname) { return OBJ.transform.Find(objectname).gameObject; }
        public static Image ReturnImage(GameObject Parent, string Object) { GameObject OBJ = Parent.transform.Find(Object).gameObject; return OBJ.GetComponent<Image>(); }
        public static TextMeshProUGUI ReturnText(GameObject Parent, string Object) { GameObject OBJ = Parent.transform.Find(Object).gameObject; return OBJ.GetComponent<TextMeshProUGUI>(); }
        public static List<Image> TabComponents = new List<Image>();
        public static List<Image> IconComponents = new List<Image>();
        public static List<TextMeshProUGUI> TextComponents = new List<TextMeshProUGUI>();

        public static void TabOBJ()
        {
            #region OBJs
            HLG         = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
            Window      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/");
            LaunchTab   = ReturnImage(HLG, "Page_Dashboard/Background");
            AlertTab    = ReturnImage(HLG, "Page_Notifications/Background");
            HereTab     = ReturnImage(HLG, "Page_Here/Background");
            CameraTab   = ReturnImage(HLG, "Page_Camera/Background");
            SoundTab    = ReturnImage(HLG, "Page_AudioSettings/Background");
            OptionsTab  = ReturnImage(HLG, "Page_Settings/Background");

            LaunchIcon  = ReturnImage(HLG, "Page_Dashboard/Icon");
            AlertIcon   = ReturnImage(HLG, "Page_Notifications/Icon");
            HereIcon    = ReturnImage(HLG, "Page_Here/Icon");
            CameraIcon  = ReturnImage(HLG, "Page_Camera/Icon");
            SoundIcon   = ReturnImage(HLG, "Page_AudioSettings/Icon");
            OptionsIcon = ReturnImage(HLG, "Page_Settings/Icon");

            MuteIcon   = ReturnImage(Window, "MicButton/Icon");
            MuteButton = ReturnImage(Window, "MicButton");
            SafeIcon   = ReturnImage(Window, "Toggle_SafeMode/Icon");
            SafeButton = ReturnImage(Window, "Toggle_SafeMode");
            WingL      = ReturnImage(Window, "Wing_Left/Button/Icon");
            WingR      = ReturnImage(Window, "Wing_Right/Button/Icon");
            FPS        = ReturnText(Window, "QMNotificationsArea/DebugInfoPanel/Panel/Text_FPS");
            Ping       = ReturnText(Window, "QMNotificationsArea/DebugInfoPanel/Panel/Text_Ping");
            FPSBack    = ReturnImage(Window, "QMNotificationsArea/DebugInfoPanel/Panel/Background");
            #endregion
            TabsTheme();
        }

        public static void TabsTheme()
        {
            //foreach (Image Img in TabComponents) { Img }
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