using System;
using ColorMod.MainFiles;
using ColorMod.MainFiles.Menus;
using MelonLoader;
using UnityEngine;

namespace ColorMod.API.Tools
{
    public class JasonConfig
    {
        #region Static
        public static string ThemeMode { get; set; }
        public static string BackgroundImage { get; set; }
        public static string ButtonImage { get; set; }
        public static string TabsImage { get; set; }
        public static string LaunchImage { get; set; }
        public static string HideCarousel { get; set; }
        public static string BaseColor { get; set; }
        public static string HighlightColor { get; set; }
        
        public static bool BackgroundBool {get; set;}
        public static bool ButtonBool {get; set;}
        public static bool TabBool {get; set;}
        public static bool BannerBool {get; set;}
        public static bool CarouselBool {get; set;}

        public static Color Base {get; set;} 
        public static Color Highlight { get; set;}

        #endregion

        #region Identify
        public static Color ColorIdentify(string ColorString)
        {
            switch (ColorString)
            {
                case "white":   return Color.white;
                case "black":   return Color.black;
                case "blue":    return Color.blue;
                case "clear":   return Color.clear;
                case "cyan":    return Color.cyan;
                case "gray":    return Color.gray;
                case "green":   return Color.green;
                case "grey":    return Color.grey;
                case "magenta": return Color.magenta;
                case "red":     return Color.red;
                case "yelllow": return Color.yellow;
                default:       
                    MelonLogger.Msg($"Improper color selected {ColorString}, edit json and select from the list with exact capitalization"); return Color.white;

            }
        }
        public static bool BoolIdentify(string BianaryString)
        {
            switch (BianaryString)
            {
                case "0": return false;
                case "1": return true;
                default: return true;
            }
        }
        #endregion

        #region Create
        public static void CreateJason() // todo add launch title override, add sepperate tab / button color option
        {
            MelonLogger.Msg("Colormod config not found, Creating file now in VRChat/Colormod/Theme.json");
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Colormod") == false) {System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\Colormod"); System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\Colormod\\CustomTheme"); } //checks for folder, creats if missing
            string[] config =
            {
                "{",
                "//Color options => (white, black, blue, clear, cyan, gray, green, grey, magenta, red, yellow) - !Preset Themes overwrite Custom Options!",
                "Preset (0 = Custom, 1 = Red, 2 = Green, 3 = Blue) :1",
                " ",
                "//Custom Options - Template Images can be found in Colormod/CustomTheme",
                "Highlight color (Icons & Text)                    :green",
                "Base color (Button Backgrounds)                   :black",
                "Use Custom Background Image (0 = No, 1 = Yes)     :1",
                "Use Custom Button Image     (0 = No, 1 = Yes)     :1",
                "Use Custom Tabs Image       (0 = No, 1 = Yes)     :1",
                "Use Custom Launch banner img(0 = No, 1 = Yes)     :1",
                "Hide Advertisement Carousel (0 = No, 1 = Yes)     :1",
                "}",
            };
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + "\\Colormod\\Theme.json", config);
        }
        #endregion

        public static void ReadJason()
        {                                                                                                                      //I know this looks bad, and it is, but does it not work? its 5 am and im tired
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\Colormod\\Theme.json") == false) {CreateJason();} //checks for jason and puts him back if hes missing <3 love u jason
            string[] Jason = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\Colormod\\Theme.json");        //reads the lines from jason file and splits user input

            #region parseJason
            string ModeString      = Jason[2];  string[] ModeSplit = ModeString.Split(':');            ThemeMode = ModeSplit[1];
            string HighlightString = Jason[5];  string[] HighlightSplit = HighlightString.Split(':');  HighlightColor = HighlightSplit[1];
            string BaseString      = Jason[6];  string[] BaseSplit = BaseString.Split(':');            BaseColor = BaseSplit[1];
            string Background      = Jason[7];  string[] BackgroundSplit = Background.Split(':');      BackgroundImage = BackgroundSplit[1];
            string Button          = Jason[8];  string[] ButtonSplit = Button.Split(':');              ButtonImage = ButtonSplit[1];
            string Tabs            = Jason[9];  string[] TabsSplit = Tabs.Split(':');                  TabsImage = TabsSplit[1];
            string LaunchBanner    = Jason[10]; string[] LaunchBannerSplit = LaunchBanner.Split(':');  LaunchImage = LaunchBannerSplit[1];
            string Carousel        = Jason[11]; string[] CarouselSplit = Carousel.Split(':');          HideCarousel = CarouselSplit[1];

            Base           = ColorIdentify(BaseColor);
            Highlight      = ColorIdentify(HighlightColor);
            BackgroundBool = BoolIdentify(BackgroundImage);
            ButtonBool     = BoolIdentify(ButtonImage);
            TabBool        = BoolIdentify(TabsImage);
            BannerBool     = BoolIdentify(LaunchImage);
            CarouselBool   = BoolIdentify(HideCarousel);

            MelonLogger.Msg("ColorMod Config - Set Config in VRChat/Colormod/Theme.json - All images are avaible in the themes folders to edit");
            MelonLogger.Msg("Theme Mode: "               + ModeSplit[1]);
            MelonLogger.Msg("Highlight Color "           + HighlightSplit[1]);
            MelonLogger.Msg("Base Color "                + BaseSplit[1]);
            MelonLogger.Msg("Background Img Enabled "    + BackgroundBool);
            MelonLogger.Msg("Button Img Enabled "        + ButtonBool);
            MelonLogger.Msg("Tab's Img Enabled "         + TabBool);
            MelonLogger.Msg("Launch Banner Img Enabled " + BannerBool);
            MelonLogger.Msg("Hide ad Carousel? "         + CarouselBool);
            MelonLogger.Msg(" ");
            #endregion

            ExecuteConfig();
        }

        #region Theme Load
        public static void ExecuteConfig()
        {
            switch (ThemeMode)
            {
                case "0":
                    ReferencedInfo.C02 = Base;
                    ReferencedInfo.C01 = Highlight;
                    MainMenu.ThemeFolder = "CustomTheme";
                    MelonLogger.Msg("Custom Theme Loading. . .");
                    break;

                case "1":
                    ReferencedInfo.C02 = Color.black;
                    ReferencedInfo.C01 = Color.red;
                    MainMenu.ThemeFolder = "RedTheme";
                    MelonLogger.Msg("Edgy Red Theme loading. . .");
                    break;

                case "2":
                    ReferencedInfo.C02 = Color.black;
                    ReferencedInfo.C01 = Color.green;
                    MainMenu.ThemeFolder = "GreenTheme";
                    MelonLogger.Msg("Spaced Out Green Theme Loading. . .");
                    break;

                case "3":
                    ReferencedInfo.C02 = Color.black;
                    ReferencedInfo.C01 = Color.blue;
                    MainMenu.ThemeFolder = "BlueTheme";
                    MelonLogger.Msg("Untitled Blue Theme Loading. . .");
                    break;
            }
        }
        #endregion
    }
}