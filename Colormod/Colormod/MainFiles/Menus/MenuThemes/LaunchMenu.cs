using System.Collections.Generic;
using ColorMod.API.Tools;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorMod.MainFiles.Menus.MenuThemes
{
    public class LaunchMenu
    {
        public static GameObject QL; //Quick Links Parent
        public static GameObject QA; //Quick Action Parent
        public static bool UsingButtonImage { get; set; }
        public static List<Image> ButtonComponents = new List<Image>();
        public static List<TextMeshProUGUI> TextComponenets = new List<TextMeshProUGUI>();
        public static List<Image> IconComponents = new List<Image>();

        public static Image ReturnImage(GameObject Parent, string Object) { GameObject OBJ = Parent.transform.Find(Object).gameObject; return OBJ.GetComponent<Image>();  }
        public static TextMeshProUGUI ReturnText(GameObject Parent, string Object) { GameObject OBJ = Parent.transform.Find(Object).gameObject; return OBJ.GetComponent<TextMeshProUGUI>(); }

        public static void LaunchMenuObj()
        {
            #region OBJs 
                QL   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks");
                QA   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions");

                ButtonComponents.Add(ReturnImage(QL, "Button_Worlds/Background"));
                ButtonComponents.Add(ReturnImage(QL, "Button_Avatars/Background"));
                ButtonComponents.Add(ReturnImage(QL, "Button_Social/Background"));
                ButtonComponents.Add(ReturnImage(QA, "Button_Safety/Background"));
                ButtonComponents.Add(ReturnImage(QL, "Button_ViewGroups/Background"));
                ButtonComponents.Add(ReturnImage(QA, "Button_GoHome/Background"));
                ButtonComponents.Add(ReturnImage(QA, "Button_Respawn/Background"));
                ButtonComponents.Add(ReturnImage(QA, "Button_SelectUser/Background"));

                IconComponents.Add(ReturnImage(QL, "Button_Worlds/Icon"));
                IconComponents.Add(ReturnImage(QL, "Button_Avatars/Icon"));
                IconComponents.Add(ReturnImage(QA, "Button_Safety/Icon"));
                IconComponents.Add(ReturnImage(QL, "Button_Social/Icon"));
                IconComponents.Add(ReturnImage(QL, "Button_ViewGroups/Icon"));
                IconComponents.Add(ReturnImage(QA, "Button_GoHome/Icon"));
                IconComponents.Add(ReturnImage(QA, "Button_Respawn/Icon"));
                IconComponents.Add(ReturnImage(QA, "Button_SelectUser/Icon"));
                
                TextComponenets.Add(ReturnText(QL, "Button_Worlds/Text_H4"));
                TextComponenets.Add(ReturnText(QL, "Button_Avatars/Text_H4"));
                TextComponenets.Add(ReturnText(QL, "Button_Social/Text_H4"));
                TextComponenets.Add(ReturnText(QA, "Button_Safety/Text_H4"));
                TextComponenets.Add(ReturnText(QL, "Button_ViewGroups/Text_H4"));
                TextComponenets.Add(ReturnText(QA, "Button_GoHome/Text_H4"));
                TextComponenets.Add(ReturnText(QA, "Button_Respawn/Text_H4"));
                TextComponenets.Add(ReturnText(QA, "Button_SelectUser/Text_H4"));

                //left these whole because they do not exist until in vr and they tend to error with GameObject.Find(); +i think that transform.find might have issues with hidden objs
                IconComponents.Add(ReturnImage(QA, "SitStandCalibrateButton/Button_SitStand/Icon_Off"));
                IconComponents.Add(ReturnImage(QA, "SitStandCalibrateButton/Button_SitStand/Icon_On"));
                ButtonComponents.Add(ReturnImage(QA, "SitStandCalibrateButton/Button_SitStand/Background"));
                IconComponents.Add(ReturnImage(QA, "SitStandCalibrateButton/Button_CalibrateFBT/Icon"));
                ButtonComponents.Add(ReturnImage(QA, "SitStandCalibrateButton/Button_CalibrateFBT/Background"));
                TextComponenets.Add(ReturnText(QA, "SitStandCalibrateButton/Button_CalibrateFBT/Text_H4"));
                TextComponenets.Add(ReturnText(QA, "SitStandCalibrateButton/Button_SitStand/Text_H4"));        
                #endregion
            LaunchMenuTheme();
        }
        public static void LaunchMenuTheme()
        {
            #region LaunchTheme
            foreach (TextMeshProUGUI Txt in TextComponenets) { Txt.color = ReferencedInfo.C01; } //Colors text
            foreach (Image Img in IconComponents) { Img.color = ReferencedInfo.C01; } //Colors icons

            Sprite BUTTON = MainMenu.ButtonSprite;
            if (JasonConfig.ThemeMode == "0") //checks if custom theme
            {
                UsingButtonImage = true;
                if (!JasonConfig.ButtonBool) { UsingButtonImage = false; return; }  //if custom theme wants no button image skips
                if (!UsingButtonImage) return;
                foreach (Image Img in ButtonComponents) { Img.overrideSprite = BUTTON; }
                UsingButtonImage = true;
            } 
            else //if not custom theme loads theme images
            {
                foreach (Image Img in ButtonComponents) { Img.overrideSprite = BUTTON; } //Sets button sprites if preset theme
                UsingButtonImage = true;
            }
            #endregion
        }
        public static void LaunchMenuThemeOnUP()
        {
            #region LaunchOnUpdate
            if (UsingButtonImage == true) //makes buttons white if using image to fix visibility, else uses custom color
            {
                foreach (Image Img in ButtonComponents) { Img.color = Color.white; } //Updates textured buttons color to white
            }
            else //Use color if not textured
            {
                foreach (Image Img in ButtonComponents) { Img.color = ReferencedInfo.C02; } //Updates button colors if not textured
            }
            #endregion
        }
    }
}