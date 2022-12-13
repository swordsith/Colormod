using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorMod.MainFiles.Menus.MenuThemes
{
    public class SettingsMenu
    {
        #region Static GOBJs
        public static GameObject SettingsTextHeader;
        public static GameObject QuitGameIcon;
        public static GameObject BigSettingsMenuIcon;
        public static GameObject UIElementsRect;
        public static GameObject UIElementsArrow;
        public static GameObject NameplateDisplayBackground;
        public static GameObject NameplateDisplayIcon1;
        public static GameObject NameplateDisplayIcon2;
        public static GameObject NameplateDisplayIcon3;
        public static GameObject NameplateDisplayText;
        public static GameObject NameplateSettingsBackground;
        public static GameObject NameplateSettingsIcon;
        public static GameObject NameplateSettingsText;
        public static GameObject QMInfoBackground;
        public static GameObject QMInfoIconON;
        public static GameObject QMInfoIconOFF;
        public static GameObject QMInfoText;
        public static GameObject FallbackIconBackground;
        public static GameObject FallbackIconIconON;
        public static GameObject FallbackIconIconOFF;
        public static GameObject FallbackIconText;
        public static GameObject HUDToggleBackground;
        public static GameObject HUDToggleIconON;
        public static GameObject HUDToggleIconOFF;
        public static GameObject HUDToggleText;
        public static GameObject TooltipsBackground;
        public static GameObject TooltipsIconON;
        public static GameObject TooltipsIconOFF;
        public static GameObject TooltipsText;
        public static GameObject AvatarInteractionsRect;
        public static GameObject AvatarInteractionsArrow;
        public static GameObject OSCLearnMore;
        public static GameObject OSCLearnMoreText;
        public static GameObject OSCBackground;
        public static GameObject OSC1;
        public static GameObject OSC1Text;
        public static GameObject OSC2;
        public static GameObject OSC2Text;
        public static GameObject OSC3;
        public static GameObject OSC3Text;
        public static GameObject AllowPauseBackground;
        public static GameObject AllowPauseON;
        public static GameObject AllowPauseOFF;
        public static GameObject AllowPauseText;
        public static GameObject SelfIntereactBackground;
        public static GameObject SelfInteractIconON;
        public static GameObject SelfInteractIconOFF;
        public static GameObject SelfInteractText;
        public static GameObject ComfortRect;
        public static GameObject ComfortArrow;
        public static GameObject ComfortBackground;
        public static GameObject ComfortIcon1;
        public static GameObject ComfortIcon2;
        public static GameObject ComfortIcon3;
        public static GameObject ComfortText;
        public static GameObject DebugRect;
        public static GameObject DebugArrow;
        public static GameObject FPSBackground;
        public static GameObject FPSText;
        public static GameObject FPSFPS;
        public static GameObject PINGBackground;
        public static GameObject PINGPING;
        public static GameObject PINGText;
        public static GameObject BuildBackground;
        public static GameObject BuildBuild;
        public static GameObject BuildText;
        public static GameObject PinFPSPINGBackground;
        public static GameObject PinFPSPINGIconON;
        public static GameObject PinFPSPINGIconOFF;
        public static GameObject PinFPSPINGText;
        #endregion
        public static void SettingsMenuObj()
        {
            #region OBJs
            SettingsTextHeader          = GameObject.Find("Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/QMHeader_H1/LeftItemContainer/Text_Title");
            QuitGameIcon                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/QMHeader_H1/RightItemContainer/Button_QM_Exit/Icon");
            BigSettingsMenuIcon         = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/QMHeader_H1/RightItemContainer/Button_QM_Expand/Icon");
            UIElementsRect              = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_UI_Elements/Label");
            UIElementsArrow             = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_UI_Elements/Arrow");
            NameplateDisplayBackground  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Background");
            NameplateDisplayIcon1       = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button A/Icon");
            NameplateDisplayIcon2       = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button B/Icon");
            NameplateDisplayIcon3       = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button C/Icon");
            NameplateDisplayText        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button B/Text_H4");
            NameplateSettingsBackground = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateSettings/Background");
            NameplateSettingsIcon       = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateSettings/Icon");
            NameplateSettingsText       = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateSettings/Text_H4");
            QMInfoBackground            = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo/Background");
            QMInfoIconON                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo/Icon_On");
            QMInfoIconOFF               = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo/Icon_Off");
            QMInfoText                  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo/Text_H4");
            FallbackIconBackground      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleFallbackIcon/Background");
            FallbackIconIconON          = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleFallbackIcon/Icon_On");
            FallbackIconIconOFF         = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleFallbackIcon/Icon_Off");
            FallbackIconText            = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleFallbackIcon/Text_H4");
            HUDToggleBackground         = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleHud/Background");
            HUDToggleIconON             = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleHud/Icon_On");
            HUDToggleIconOFF            = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleHud/Icon_Off");
            HUDToggleText               = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleHud/Text_H4");
            TooltipsBackground          = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleTooltips/Background");
            TooltipsIconON              = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleTooltips/Icon_On");
            TooltipsIconOFF             = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleTooltips/Icon_Off");
            TooltipsText                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_2/Button_ToggleTooltips/Text_H4");

            AvatarInteractionsRect      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_AvInteractions/Label");
            AvatarInteractionsArrow     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_AvInteractions/Arrow");
            OSCLearnMore                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_AvInteractions/InfoButton");
            OSCLearnMoreText            = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_AvInteractions/InfoButton/Text_MM_H3");
            OSCBackground               = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Background");
            OSC1                        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Buttons/Button_Nobody/Icon");
            OSC1Text                    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Buttons/Button_Nobody/Text_H4");
            OSC2                        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Buttons/Button_Friends/Icon");
            OSC2Text                    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Buttons/Button_Friends/Text_H4");
            OSC3                        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Buttons/Button_Everyone/Icon");
            OSC3Text                    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_InteractPermissions/Buttons/Button_Everyone/Text_H4");
            AllowPauseBackground        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_PauseInteractions/Background");
            AllowPauseON                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_PauseInteractions/Icon_Off");
            AllowPauseOFF               = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_PauseInteractions/Icon_On");
            AllowPauseText              = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_PauseInteractions/Text_H4");
            SelfIntereactBackground     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_ToggleSelfInteract/Background");
            SelfInteractIconON          = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_ToggleSelfInteract/Icon_On");
            SelfInteractIconOFF         = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_ToggleSelfInteract/Icon_Off");
            SelfInteractText            = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_AvInteractions/Button_ToggleSelfInteract/Text_H4");


            ComfortRect                 = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_Comfort/Label");
            ComfortArrow                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_Comfort/Arrow");
            ComfortBackground           = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Comfort/Button_ComfortControls/Background");
            ComfortIcon1                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Comfort/Button_ComfortControls/Buttons/Button A/Icon");
            ComfortIcon2                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Comfort/Button_ComfortControls/Buttons/Button B/Icon");
            ComfortIcon3                = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Comfort/Button_ComfortControls/Buttons/Button C/Icon");
            ComfortText                 = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Comfort/Button_ComfortControls/Text_H4 (1)");

            DebugRect                   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_Debug/Label");
            DebugArrow                  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_Debug/Arrow");
            FPSBackground               = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_FPS/Background");
            FPSFPS                      = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_FPS/Text_H1");
            FPSText                     = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_FPS/Text_H4");
            PINGBackground              = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_Ping/Background");
            PINGPING                    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_Ping/Text_H1");
            PINGText                    = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_Ping/Text_H4");
            BuildBackground             = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_Build/Background");
            BuildBuild                  = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_Build/Text_H1");
            BuildText                   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_Build/Text_H4");
            PinFPSPINGBackground        = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_PinFPSAndPing/Background");
            PinFPSPINGIconON            = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_PinFPSAndPing/Icon_On");
            PinFPSPINGIconOFF           = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_PinFPSAndPing/Icon_Off");
            PinFPSPINGText              = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_Debug/Button_PinFPSAndPing/Text_H4");
            #endregion
            SettingsMenuTheme();
        }
        public static void SettingsMenuTheme()
        {
            OSCLearnMore.active = false;
            OSCLearnMoreText.active = false;
            #region SettingsTheme
            SettingsTextHeader.         GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            QuitGameIcon.               GetComponent<Image>().color = ReferencedInfo.C01;
            BigSettingsMenuIcon.        GetComponent<Image>().color = ReferencedInfo.C01;
            UIElementsRect.             GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            UIElementsArrow.            GetComponent<Image>().color = ReferencedInfo.C01;
            NameplateDisplayText.       GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            NameplateSettingsBackground.GetComponent<Image>().color = ReferencedInfo.C02;
            NameplateSettingsIcon.      GetComponent<Image>().color = ReferencedInfo.C01;
            NameplateSettingsText.      GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            QMInfoBackground.           GetComponent<Image>().color = ReferencedInfo.C02;
            QMInfoText.                 GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            FallbackIconBackground.     GetComponent<Image>().color = ReferencedInfo.C02;
            FallbackIconText.           GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            HUDToggleBackground.        GetComponent<Image>().color = ReferencedInfo.C02;
            HUDToggleText.              GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            TooltipsBackground.         GetComponent<Image>().color = ReferencedInfo.C02;
            TooltipsText.               GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            AvatarInteractionsRect.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            AvatarInteractionsArrow.    GetComponent<Image>().color = ReferencedInfo.C01;
            
            OSC1Text.                   GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            OSC2Text.                   GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            OSC3Text.                   GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            AllowPauseBackground.       GetComponent<Image>().color = ReferencedInfo.C02;
            AllowPauseText.             GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            SelfIntereactBackground.    GetComponent<Image>().color = ReferencedInfo.C02;
            SelfInteractText.           GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            ComfortRect.                GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            ComfortArrow.               GetComponent<Image>().color = ReferencedInfo.C01;
            ComfortText.                GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            DebugRect.                  GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            DebugArrow.                 GetComponent<Image>().color = ReferencedInfo.C01;
            FPSBackground.              GetComponent<Image>().color = ReferencedInfo.C02;
            FPSText.                    GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            FPSFPS.                     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            PINGBackground.             GetComponent<Image>().color = ReferencedInfo.C02;
            PINGPING.                   GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            PINGText.                   GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            BuildBackground.            GetComponent<Image>().color = ReferencedInfo.C02;
            BuildBuild.                 GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            BuildText.                  GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            PinFPSPINGBackground.       GetComponent<Image>().color = ReferencedInfo.C02;
            PinFPSPINGText.             GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            #endregion
        }
        public static void SettingsMenuOnUP()
        {
            #region SettingsThemeOnUP
            NameplateDisplayBackground.GetComponent<Image>().color = ReferencedInfo.C02;
            NameplateDisplayIcon1.     GetComponent<Image>().color = ReferencedInfo.C01;
            NameplateDisplayIcon2.     GetComponent<Image>().color = ReferencedInfo.C01;
            NameplateDisplayIcon3.     GetComponent<Image>().color = ReferencedInfo.C01;
            QMInfoIconON.              GetComponent<Image>().color = ReferencedInfo.C01;
            QMInfoIconOFF.             GetComponent<Image>().color = ReferencedInfo.C01;
            FallbackIconIconON.        GetComponent<Image>().color = ReferencedInfo.C01;
            FallbackIconIconOFF.       GetComponent<Image>().color = ReferencedInfo.C01;
            HUDToggleIconON.           GetComponent<Image>().color = ReferencedInfo.C01;
            HUDToggleIconOFF.          GetComponent<Image>().color = ReferencedInfo.C01;
            TooltipsIconON.            GetComponent<Image>().color = ReferencedInfo.C01;
            TooltipsIconOFF.           GetComponent<Image>().color = ReferencedInfo.C01;
            OSCBackground.             GetComponent<Image>().color = ReferencedInfo.C02;
            OSC1.                      GetComponent<Image>().color = ReferencedInfo.C01;
            OSC2.                      GetComponent<Image>().color = ReferencedInfo.C01;
            OSC3.                      GetComponent<Image>().color = ReferencedInfo.C01;
            AllowPauseON.              GetComponent<Image>().color = ReferencedInfo.C01;
            AllowPauseOFF.             GetComponent<Image>().color = ReferencedInfo.C01;
            SelfInteractIconON.        GetComponent<Image>().color = ReferencedInfo.C01;
            SelfInteractIconOFF.       GetComponent<Image>().color = ReferencedInfo.C01;
            ComfortBackground.         GetComponent<Image>().color = ReferencedInfo.C02;
            ComfortIcon1.              GetComponent<Image>().color = ReferencedInfo.C01;
            ComfortIcon2.              GetComponent<Image>().color = ReferencedInfo.C01;
            ComfortIcon3.              GetComponent<Image>().color = ReferencedInfo.C01;
            PinFPSPINGIconON.          GetComponent<Image>().color = ReferencedInfo.C01;
            PinFPSPINGIconOFF.         GetComponent<Image>().color = ReferencedInfo.C01;
            #endregion
        }
    }
}