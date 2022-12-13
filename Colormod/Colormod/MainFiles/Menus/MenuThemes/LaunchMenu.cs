using System;
using ColorMod.API.Tools;
using ProjectR.API.ObjUtils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorMod.MainFiles.Menus.MenuThemes
{
    public class LaunchMenu
    {
        #region Static GOBJs
        public static GameObject WorldButton;
        public static GameObject AvatarButton;
        public static GameObject SocialButton;
        public static GameObject SafetyButton;
        public static GameObject GoHomeButton;
        public static GameObject RespawnButton;
        public static GameObject SelectButton;
        //public static GameObject AllowButton;

        public static GameObject WorldText;
        public static GameObject AvatarText;
        public static GameObject SocialText;
        public static GameObject SafetyText;
        public static GameObject GoHomeText;
        public static GameObject RespawnText;
        public static GameObject SelectText;
        //public static GameObject AllowText;

        public static GameObject WorldIcon;
        public static GameObject AvatarIcon;
        public static GameObject SocialIcon;
        public static GameObject SafetyIcon;
        public static GameObject GoHomeIcon;
        public static GameObject RespawnIcon;
        public static GameObject SelectIcon;
        //public static GameObject AllowIcon;

        public static GameObject SittingIcon;
        public static GameObject SitStandButton;
        public static GameObject StandingIcon;
        public static GameObject CalibrateIcon;
        public static GameObject CalibrateButton;
        public static GameObject CalibrateText;
        public static GameObject SitStandText;

        public static GameObject GroupsButton;
        public static GameObject GroupsIcon;
        public static GameObject GroupsText;

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

                WorldButton      = FindOBJ(QL, "Button_Worlds/Background");
                WorldIcon        = FindOBJ(QL, "Button_Worlds/Icon");
                WorldText        = FindOBJ(QL, "Button_Worlds/Text_H4");

                AvatarButton     = FindOBJ(QL, "Button_Avatars/Background");
                AvatarIcon       = FindOBJ(QL, "Button_Avatars/Icon");
                AvatarText       = FindOBJ(QL, "Button_Avatars/Text_H4");

                SocialButton     = FindOBJ(QL, "Button_Social/Background");
                SocialIcon       = FindOBJ(QL, "Button_Social/Icon");
                SocialText       = FindOBJ(QL, "Button_Social/Text_H4");

                SafetyButton     = FindOBJ(QA, "Button_Safety/Background");
                SafetyIcon       = FindOBJ(QA, "Button_Safety/Icon");
                SafetyText       = FindOBJ(QA, "Button_Safety/Text_H4");

                GroupsButton     = FindOBJ(QL, "Button_ViewGroups/Background");
                GroupsIcon       = FindOBJ(QL, "Button_ViewGroups/Icon");
                GroupsText       = FindOBJ(QL, "Button_ViewGroups/Text_H4");
                    
                GoHomeButton     = FindOBJ(QA, "Button_GoHome/Background");
                GoHomeIcon       = FindOBJ(QA, "Button_GoHome/Icon");
                GoHomeText       = FindOBJ(QA, "Button_GoHome/Text_H4");

                RespawnButton    = FindOBJ(QA, "Button_Respawn/Background");
                RespawnIcon      = FindOBJ(QA, "Button_Respawn/Icon");
                RespawnText      = FindOBJ(QA, "Button_Respawn/Text_H4");

                SelectButton     = FindOBJ(QA, "Button_SelectUser/Background");
                SelectIcon       = FindOBJ(QA, "Button_SelectUser/Icon");
                SelectText       = FindOBJ(QA, "Button_SelectUser/Text_H4");

                //left these whole because they do not exist until in vr and they tend to error with FindOBJ(); i think that transform.find might have issues with hidden objs
                SittingIcon      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off");
                StandingIcon     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_On");
                SitStandButton   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Background");
                CalibrateIcon    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Icon");
                CalibrateButton  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Background");
                CalibrateText    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_CalibrateFBT/Text_H4");
                SitStandText     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Text_H4");        
                #endregion
            LaunchMenuTheme();
        }
        public static void LaunchMenuTheme()
        {
            #region LaunchTheme
            WorldText.      GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            AvatarText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            SocialText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            SafetyText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            GoHomeText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            RespawnText.    GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            SelectText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            GroupsText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;

            WorldIcon.      GetComponent<Image>().color = ReferencedInfo.C01;
            AvatarIcon.     GetComponent<Image>().color = ReferencedInfo.C01;
            SocialIcon.     GetComponent<Image>().color = ReferencedInfo.C01;
            SafetyIcon.     GetComponent<Image>().color = ReferencedInfo.C01;
            GoHomeIcon.     GetComponent<Image>().color = ReferencedInfo.C01;
            RespawnIcon.    GetComponent<Image>().color = ReferencedInfo.C01;
            SelectIcon.     GetComponent<Image>().color = ReferencedInfo.C01;
            GroupsIcon.     GetComponent<Image>().color = ReferencedInfo.C01;

            Sprite BUTTON = MainMenu.ButtonSprite;
            if (JasonConfig.ThemeMode == "0") //checks if custom theme
            {
                UsingButtonImage = true;
                if (!JasonConfig.ButtonBool) { UsingButtonImage = false; return; }  //if custom theme wants no button image skips
                if (!UsingButtonImage) return;
            WorldButton.    GetComponent<Image>().overrideSprite = BUTTON;
            AvatarButton.   GetComponent<Image>().overrideSprite = BUTTON;
            SocialButton.   GetComponent<Image>().overrideSprite = BUTTON;
            SafetyButton.   GetComponent<Image>().overrideSprite = BUTTON;
            GoHomeButton.   GetComponent<Image>().overrideSprite = BUTTON;
            RespawnButton.  GetComponent<Image>().overrideSprite = BUTTON;
            SelectButton.   GetComponent<Image>().overrideSprite = BUTTON;
            SitStandButton. GetComponent<Image>().overrideSprite = BUTTON;
            CalibrateButton.GetComponent<Image>().overrideSprite = BUTTON;
            GroupsButton.   GetComponent<Image>().overrideSprite = BUTTON;
                UsingButtonImage = true;
            } 
            else //if not custom theme loads theme images
            { 
            WorldButton.    GetComponent<Image>().overrideSprite = BUTTON;
            AvatarButton.   GetComponent<Image>().overrideSprite = BUTTON;
            SocialButton.   GetComponent<Image>().overrideSprite = BUTTON;
            SafetyButton.   GetComponent<Image>().overrideSprite = BUTTON;
            GoHomeButton.   GetComponent<Image>().overrideSprite = BUTTON;
            RespawnButton.  GetComponent<Image>().overrideSprite = BUTTON;
            SelectButton.   GetComponent<Image>().overrideSprite = BUTTON;
            SitStandButton. GetComponent<Image>().overrideSprite = BUTTON;
            CalibrateButton.GetComponent<Image>().overrideSprite = BUTTON;
            GroupsButton.   GetComponent<Image>().overrideSprite = BUTTON;
                UsingButtonImage = true;
            }
            #endregion
        }
        public static void LaunchMenuThemeOnUP()
        {
            #region LaunchOnUpdate
            if (UsingButtonImage == true) //makes buttons white if using image to fix visibility, else uses custom color
            {
            WorldButton.    GetComponent<Image>().color = Color.white;
            AvatarButton.   GetComponent<Image>().color = Color.white;
            SocialButton.   GetComponent<Image>().color = Color.white;
            SafetyButton.   GetComponent<Image>().color = Color.white;
            GoHomeButton.   GetComponent<Image>().color = Color.white;
            RespawnButton.  GetComponent<Image>().color = Color.white;
            SelectButton.   GetComponent<Image>().color = Color.white;
            SitStandButton. GetComponent<Image>().color = Color.white;
            CalibrateButton.GetComponent<Image>().color = Color.white;
            GroupsButton.   GetComponent<Image>().color = Color.white;
            }
            else
            {
            WorldButton.    GetComponent<Image>().color = ReferencedInfo.C02;
            AvatarButton.   GetComponent<Image>().color = ReferencedInfo.C02;
            SocialButton.   GetComponent<Image>().color = ReferencedInfo.C02;
            SafetyButton.   GetComponent<Image>().color = ReferencedInfo.C02;
            GoHomeButton.   GetComponent<Image>().color = ReferencedInfo.C02;
            RespawnButton.  GetComponent<Image>().color = ReferencedInfo.C02;
            SelectButton.   GetComponent<Image>().color = ReferencedInfo.C02;
            SitStandButton. GetComponent<Image>().color = ReferencedInfo.C02;
            CalibrateButton.GetComponent<Image>().color = ReferencedInfo.C02;
            GroupsButton.   GetComponent<Image>().color = ReferencedInfo.C02;
            }
            #endregion

            #region SittingStanding Calibrate
            try
            {
                SittingIcon.GetComponent<Image>().color            = ReferencedInfo.C01;
                StandingIcon.GetComponent<Image>().color           = ReferencedInfo.C01;
                SitStandText.GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            }
            catch { }
            try
            {
                CalibrateIcon.GetComponent<Image>().color           = ReferencedInfo.C01;
                CalibrateText.GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            } catch { }
            #endregion
        }
    }
}