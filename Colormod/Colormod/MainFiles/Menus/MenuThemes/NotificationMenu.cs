using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorMod.MainFiles.Menus.MenuThemes
{
    public class NotificationMenu
    {
        #region StaticGOBJs
        public static GameObject NotiExpandIcon;
        public static GameObject NotificationTitle;
        public static GameObject Checkmark;
        public static GameObject CheckBoxBackground;
        public static GameObject HidePhoto;
        public static GameObject HidePhotoText;
        public static GameObject InvitesTabText;
        public static GameObject InvitesTab;
        public static GameObject FriendsTabText;
        public static GameObject FriendsTab;
        public static GameObject OtherTabText;
        public static GameObject OtherTab;
        public static GameObject NoNotificationText;
        public static GameObject NoNotificationIcon;
        public static GameObject M_N; //menu notification parent
        public static GameObject P_N_T; //panel notification tabs parent
        #endregion
        public static GameObject FindOBJ(GameObject OBJ, string objectname) { return OBJ.transform.Find(objectname).gameObject; }
        public static void NotificationMenuObj()
        {
            #region OBJs
            M_N   = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications/");
            P_N_T = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications/Panel_Notification_Tabs");

            NotiExpandIcon     = FindOBJ(M_N,   "QMHeader_H1/RightItemContainer/Button_QM_Expand/Icon");
            NotificationTitle  = FindOBJ(M_N,   "QMHeader_H1/LeftItemContainer/Text_Title");
            NoNotificationText = FindOBJ(M_N,   "Panel_NoNotifications_Message");
            NoNotificationIcon = FindOBJ(M_N,   "Panel_NoNotifications_Message/Icon");
            Checkmark          = FindOBJ(P_N_T, "Button_HideInvitePhotos/HidePhotos/Checkbox_Background/Checkmark");
            CheckBoxBackground = FindOBJ(P_N_T, "Button_HideInvitePhotos/HidePhotos/Checkbox_Background");
            HidePhoto          = FindOBJ(P_N_T, "Button_HideInvitePhotos/HidePhotos/Background_Field");
            HidePhotoText      = FindOBJ(P_N_T, "Button_HideInvitePhotos/HidePhotos/Label");
            InvitesTabText     = FindOBJ(P_N_T, "Tabs/InvitesTab/Text");
            InvitesTab         = FindOBJ(P_N_T, "Tabs/InvitesTab/Background");
            FriendsTabText     = FindOBJ(P_N_T, "Tabs/FriendRequestsTab/Text");
            FriendsTab         = FindOBJ(P_N_T, "Tabs/FriendRequestsTab/Background");
            OtherTabText       = FindOBJ(P_N_T, "Tabs/OtherTab/Text");
            OtherTab           = FindOBJ(P_N_T, "Tabs/OtherTab/Background");
            #endregion
            NotificationMenuTheme();
        }
        public static void NotificationMenuTheme()
        {
            #region NotificationTheme
            NotificationTitle. GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            HidePhotoText.     GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            InvitesTabText.    GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            FriendsTabText.    GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            OtherTabText.      GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;
            NoNotificationText.GetComponent<TextMeshProUGUI>().color = ReferencedInfo.C01;

            NotiExpandIcon.    GetComponent<Image>().color = ReferencedInfo.C01;
            Checkmark.         GetComponent<Image>().color = ReferencedInfo.C01;
            CheckBoxBackground.GetComponent<Image>().color = ReferencedInfo.C02;
            HidePhoto.         GetComponent<Image>().color = ReferencedInfo.C01;
            InvitesTab.        GetComponent<Image>().color = ReferencedInfo.C01;
            FriendsTab.        GetComponent<Image>().color = ReferencedInfo.C01;
            OtherTab.          GetComponent<Image>().color = ReferencedInfo.C01;
            NoNotificationIcon.GetComponent<Image>().color = ReferencedInfo.C01;
            #endregion
        }
    }
}