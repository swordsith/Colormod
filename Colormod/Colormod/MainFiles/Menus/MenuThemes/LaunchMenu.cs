using System;
using ColorMod.API.Tools;
using MelonLoader.TinyJSON;
using ProjectR.API.ObjUtils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorMod.MainFiles.Menus.MenuThemes
{
    public class LaunchMenu
    {
        #region Static GOBJs
        public static Image WorldButton;
        public static Image AvatarButton;
        public static Image SocialButton;
        public static Image SafetyButton;
        public static Image GoHomeButton;
        public static Image RespawnButton;
        public static Image SelectButton;
        public static Image SitStandButton;
        public static Image CalibrateButton;
        public static Image GroupsButton;

        public static TextMeshProUGUI WorldText;
        public static TextMeshProUGUI AvatarText;
        public static TextMeshProUGUI SocialText;
        public static TextMeshProUGUI SafetyText;
        public static TextMeshProUGUI GoHomeText;
        public static TextMeshProUGUI RespawnText;
        public static TextMeshProUGUI SelectText;
        public static TextMeshProUGUI CalibrateText;
        public static TextMeshProUGUI SitStandText;
        public static TextMeshProUGUI GroupsText;
        
        public static Image CalibrateIcon;
        public static Image WorldIcon;
        public static Image AvatarIcon;
        public static Image SocialIcon;
        public static Image SafetyIcon;
        public static Image GoHomeIcon;
        public static Image RespawnIcon;
        public static Image SelectIcon;
        public static Image SittingIcon;
        public static Image StandingIcon;
        public static Image GroupsIcon;

        public static GameObject QL; //Quick Links Parent
        public static GameObject QA; //Quick Action Parent
        #endregion
        public static bool UsingButtonImage { get; set; }

        public static GameObject FindOBJ(GameObject OBJ, string objectname) { return OBJ.transform.Find(objectname).gameObject; }
        public static void LaunchMenuObj()
        {
            #region OBJs 
                QL   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks");
                QA   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions");

                WorldButton   = FindOBJ(QL, "Button_Worlds/Background").GetComponent<Image>();
                AvatarButton  = FindOBJ(QL, "Button_Avatars/Background").GetComponent<Image>();
                SocialButton  = FindOBJ(QL, "Button_Social/Background").GetComponent<Image>();
                SafetyButton  = FindOBJ(QA, "Button_Safety/Background").GetComponent<Image>();
                GroupsButton  = FindOBJ(QL, "Button_ViewGroups/Background").GetComponent<Image>();
                GoHomeButton  = FindOBJ(QA, "Button_GoHome/Background").GetComponent<Image>();
                RespawnButton = FindOBJ(QA, "Button_Respawn/Background").GetComponent<Image>();
                SelectButton  = FindOBJ(QA, "Button_SelectUser/Background").GetComponent<Image>();

                WorldIcon = FindOBJ(QL, "Button_Worlds/Icon").GetComponent<Image>();
                AvatarIcon = FindOBJ(QL, "Button_Avatars/Icon").GetComponent<Image>();
                SafetyIcon = FindOBJ(QA, "Button_Safety/Icon").GetComponent<Image>();
                SocialIcon = FindOBJ(QL, "Button_Social/Icon").GetComponent<Image>();
                GroupsIcon = FindOBJ(QL, "Button_ViewGroups/Icon").GetComponent<Image>();
                GoHomeIcon = FindOBJ(QA, "Button_GoHome/Icon").GetComponent<Image>();
                RespawnIcon = FindOBJ(QA, "Button_Respawn/Icon").GetComponent<Image>();
                SelectIcon = FindOBJ(QA, "Button_SelectUser/Icon").GetComponent<Image>();
                
                WorldText = FindOBJ(QL, "Button_Worlds/Text_H4").GetComponent<TextMeshProUGUI>();
                AvatarText = FindOBJ(QL, "Button_Avatars/Text_H4").GetComponent<TextMeshProUGUI>();
                SocialText = FindOBJ(QL, "Button_Social/Text_H4").GetComponent<TextMeshProUGUI>();
                SafetyText = FindOBJ(QA, "Button_Safety/Text_H4").GetComponent<TextMeshProUGUI>();
                GroupsText = FindOBJ(QL, "Button_ViewGroups/Text_H4").GetComponent<TextMeshProUGUI>();
                GoHomeText = FindOBJ(QA, "Button_GoHome/Text_H4").GetComponent<TextMeshProUGUI>();
                RespawnText = FindOBJ(QA, "Button_Respawn/Text_H4").GetComponent<TextMeshProUGUI>();
                SelectText = FindOBJ(QA, "Button_SelectUser/Text_H4").GetComponent<TextMeshProUGUI>();

                //left these whole because they do not exist until in vr and they tend to error with FindOBJ(); i think that transform.find might have issues with hidden objs
                SittingIcon      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off").GetComponent<Image>();
                StandingIcon     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_On").GetComponent<Image>();
                SitStandButton   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Background").GetComponent<Image>();
                CalibrateIcon    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Icon").GetComponent<Image>();
                CalibrateButton  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Background").GetComponent<Image>();
                CalibrateText    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Text_H4").GetComponent<TextMeshProUGUI>();
                SitStandText     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Text_H4").GetComponent<TextMeshProUGUI>();        
                #endregion
            LaunchMenuTheme();
        }
        public static void LaunchMenuTheme()
        {

            #region LaunchTheme
            WorldText.color = ReferencedInfo.C01;
            AvatarText.color = ReferencedInfo.C01;
            SocialText.color = ReferencedInfo.C01;
            SafetyText.color = ReferencedInfo.C01;
            GoHomeText.color = ReferencedInfo.C01;
            RespawnText.color = ReferencedInfo.C01;
            SelectText.color = ReferencedInfo.C01;
            GroupsText.color = ReferencedInfo.C01;

            WorldIcon.color = ReferencedInfo.C01;
            AvatarIcon.color = ReferencedInfo.C01;
            SocialIcon.color = ReferencedInfo.C01;
            SafetyIcon.color = ReferencedInfo.C01;
            GoHomeIcon.color = ReferencedInfo.C01;
            RespawnIcon.color = ReferencedInfo.C01;
            SelectIcon.color = ReferencedInfo.C01;
            GroupsIcon.color = ReferencedInfo.C01;

            Sprite BUTTON = MainMenu.ButtonSprite;
            if (JasonConfig.ThemeMode == "0") //checks if custom theme
            {
                UsingButtonImage = true;
                if (!JasonConfig.ButtonBool) { UsingButtonImage = false; return; }  //if custom theme wants no button image skips
                if (!UsingButtonImage) return;
                WorldButton.overrideSprite = BUTTON;
                AvatarButton.overrideSprite = BUTTON;
                SocialButton.overrideSprite = BUTTON;
                SafetyButton.overrideSprite = BUTTON;
                GoHomeButton.overrideSprite = BUTTON;
                RespawnButton.overrideSprite = BUTTON;
                SelectButton.overrideSprite = BUTTON;
                SitStandButton.overrideSprite = BUTTON;
                CalibrateButton.overrideSprite = BUTTON;
                GroupsButton.overrideSprite = BUTTON;
                UsingButtonImage = true;
            } 
            else //if not custom theme loads theme images
            { 
                WorldButton.overrideSprite = BUTTON;
                AvatarButton.overrideSprite = BUTTON;
                SocialButton.overrideSprite = BUTTON;
                SafetyButton.overrideSprite = BUTTON;
                GoHomeButton.overrideSprite = BUTTON;
                RespawnButton.overrideSprite = BUTTON;
                SelectButton.overrideSprite = BUTTON;
                SitStandButton.overrideSprite = BUTTON;
                CalibrateButton.overrideSprite = BUTTON;
                GroupsButton.overrideSprite = BUTTON;
                UsingButtonImage = true;
            }
            #endregion
        }
        public static void LaunchMenuThemeOnUP()
        {
            #region LaunchOnUpdate
            if (UsingButtonImage == true) //makes buttons white if using image to fix visibility, else uses custom color
            {
                WorldButton.color = Color.white;
                AvatarButton.color = Color.white;
                SocialButton.color = Color.white;
                SafetyButton.color = Color.white;
                GoHomeButton.color = Color.white;
                RespawnButton.color = Color.white;
                SelectButton.color = Color.white;
                SitStandButton.color = Color.white;
                CalibrateButton.color = Color.white;
                GroupsButton.color = Color.white;
            }
            else
            {
                WorldButton.color = ReferencedInfo.C02;
                AvatarButton.color = ReferencedInfo.C02;
                SocialButton.color = ReferencedInfo.C02;
                SafetyButton.color = ReferencedInfo.C02;
                GoHomeButton.color = ReferencedInfo.C02;
                RespawnButton.color = ReferencedInfo.C02;
                SelectButton.color = ReferencedInfo.C02;
                SitStandButton.color = ReferencedInfo.C02;
                CalibrateButton.color = ReferencedInfo.C02;
                GroupsButton.color = ReferencedInfo.C02;
            }
            try
            {
                SittingIcon.color = ReferencedInfo.C01;
                StandingIcon.color = ReferencedInfo.C01;
                SitStandText.color = ReferencedInfo.C01;
            }
            catch { }
            try
            {
                CalibrateIcon.color = ReferencedInfo.C01;
                CalibrateText.color = ReferencedInfo.C01;
            } catch { }
            #endregion
        }
    }
}