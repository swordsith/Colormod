using System;
using ColorMod.API.Tools;
using ProjectR.API.ObjUtils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorMod.MainFiles.Menus
{
    internal class MainMenu
    {
        public static bool UpdateON { get; set; }
        public static string ThemeFolder { get; set; } 

        #region MM OBJS
        public static GameObject MenuContainer;
        public static GameObject DashboardMenu;
        public static GameObject NotificationMenu;
        public static GameObject HereMenu;
        public static GameObject CameraMenu;
        public static GameObject SoundMenu;
        public static GameObject SettingsMenu;
        public static GameObject RMenu;

        public static GameObject QMExpand;
        public static GameObject MMenu;
        public static GameObject Carousel;
        public static GameObject LaunchTitle;
        public static GameObject QuickLinkTitle;
        public static GameObject QuickActionTitle;
        #endregion
        public static Sprite BackgroundSprite { get; set; } 
        public static Sprite BannerSprite { get; set; }
        public static Sprite ButtonSprite { get; set; }
        public static Sprite TabSprite { get; set; }
        public static GameObject FindOBJ(GameObject OBJ, string objectname) { return OBJ.transform.Find(objectname).gameObject; }
        public static void LaunchMenu() 
        {

            #region MM OBJ's
            MenuContainer  = GameObject.Find("Canvas_QuickMenu(Clone)/Container/"); ;
            GameObject QMP = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent");
            GameObject HH1 = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/Header_H1");
            GameObject VLG = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/");
            GameObject Background1 = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/BackgroundLayer01"); //blue

                MMenu = HH1;
                LaunchTitle      = FindOBJ(HH1, "LeftItemContainer/Text_Title");
                QMExpand         = FindOBJ(HH1, "RightItemContainer/Button_QM_Expand");
                Carousel         = FindOBJ(VLG, "Carousel_Banners/Image_MASK");
                QuickLinkTitle   = FindOBJ(VLG, "Header_QuickLinks/LeftItemContainer/Text_Title");
                QuickActionTitle = FindOBJ(VLG, "Header_QuickActions/LeftItemContainer/Text_Title");

                DashboardMenu    = FindOBJ(QMP, "Menu_Dashboard");
                NotificationMenu = FindOBJ(QMP, "Menu_Notifications");
                HereMenu         = FindOBJ(QMP, "Menu_Here");   
                CameraMenu       = FindOBJ(QMP, "Menu_Camera");
                SoundMenu        = FindOBJ(QMP, "Menu_AudioSettings");
                SettingsMenu     = FindOBJ(QMP, "Menu_Settings");
            #endregion

            JasonConfig.ReadJason(); //Reads config to grab theme preferences
            BackgroundSprite = ProjectRobj.LoadSpriteFromDisk((Environment.CurrentDirectory + $"\\Colormod\\{ThemeFolder}\\BACKGROUND.png"));
            BannerSprite     = ProjectRobj.LoadSpriteFromDisk((Environment.CurrentDirectory + $"\\Colormod\\{ThemeFolder}\\BANNER.png"));
            ButtonSprite     = ProjectRobj.LoadSpriteFromDisk(Environment.CurrentDirectory + $"\\Colormod\\{ThemeFolder}\\BUTTON.png");
            TabSprite        = ProjectRobj.LoadSpriteFromDisk(Environment.CurrentDirectory + $"\\Colormod\\{ThemeFolder}\\TAB.png");



            #region DashboardMods
            if (JasonConfig.BackgroundBool == true) { Background1.GetComponent<Image>().overrideSprite = BackgroundSprite; Background1.GetComponent<Image>().color = Color.white; } else { }
            if (JasonConfig.BannerBool == true) { ProjectRobj.Createbox(HH1.transform, new Vector3(-5.3969f, -276.9864f, 0.9601f), new Vector3(0f, 0f, 0f), new Vector3(9.7618f, 3.3545f, 1f), "MainMenuUtils", Color.white, BannerSprite); } else { }
            if (JasonConfig.ThemeMode == "0") { if (JasonConfig.CarouselBool) Carousel.active = false; } else { Carousel.active = false; }

                QuickLinkTitle.active = false; //cleans out the useless text meshes
                QuickActionTitle.active = false;
                QMExpand.active = false;

                TextMeshProUGUI LaunchTMP = LaunchTitle.GetComponent<TextMeshProUGUI>();
                LaunchTMP.text = " "; //setup custom title at some point
                LaunchTMP.color = ReferencedInfo.C01;
                LaunchTMP.enableWordWrapping = false;
                #endregion

            MenuTheme();
        }
        public static void MenuTheme() //colors main menu and tabs/clients 
        {
            #region theme
            MenuThemes.LaunchMenu.LaunchMenuObj();
            MenuThemes.NotificationMenu.NotificationMenuObj();
            MenuThemes.Tabs.TabOBJ();
            UpdateON = true; //allows On Update elements to run when theme is complete

            //To Be added
            //MenuThemes.SettingsMenu.SettingsMenuObj();
            //MenuThemes.HereMenu.HereMenuObj();
            //MenuThemes.SelectedUserMenu.SelectedUserMenuObj();
            //MenuThemes.SoundMenu.SoundMenuObj();
            //MenuThemes.CameraMenu.CameraMenuObj();
            #endregion
        }
        public static void OnUpdateTheme() //colors ui elements that update, also grabs menu state for optimized themeing
        { if (UpdateON == false) return;

        MenuThemes.Tabs.TabsOnUP();
        MenuThemes.LaunchMenu.LaunchMenuThemeOnUP();

        #region Optimization
        //if (MenuContainerState == false) { goto skip; } //Skips ALL On Update theming while menu is closed, needs fixed
            /*
        skip:;
        #region MENU STATE UPDATE
            try
            {
                MenuContainerState = MenuContainer.active;
                DashboardState     = DashboardMenu.active;
                NotificationState  = NotificationMenu.active;
                HereState          = HereMenu.active;
                CameraState        = CameraMenu.active;
                SoundState         = SoundMenu.active;
                SettingsState      = SettingsMenu.active;
                RTabState          = RMenu.active;
                MunchState         = MunchMenu.active;
            } catch{}
            #endregion
            if (SettingsState == true)
            { 
                MenuThemes.SettingsMenu.SettingsMenuOnUP();
            }
            */
        #endregion
        }
    }
}