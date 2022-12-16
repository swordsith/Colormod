using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace ProjectR.API.ObjUtils
{
    internal static class MenuUtils
    {
        #region ChangeComponents
        public static void DestroyStyleElements(GameObject TargetToDestroy)
        { Object.Destroy(TargetToDestroy.GetComponent<VRC.UI.Core.Styles.StyleElement>()); }

        public static void DestroyChildren(Transform ParentOfGameObject)
        {
            foreach (Transform Child in ParentOfGameObject.transform)
            { Object.Destroy(Child.gameObject); }
        }

        public static void ChangeGameObjectColor(GameObject TargetObject, Color TargetColor, bool ImageorText)
        {
            if (ImageorText)
            { TargetObject.GetComponent<Image>().color = TargetColor; }
            else
            { TargetObject.GetComponent<TextMeshProUGUI>().color = TargetColor; }
        }

        public static void SkipUpdate(Image SkipUpdateOnThis) //skip tab updates  on this object
        {
            SkipUpdateOnThis.m_SkipLayoutUpdate = true;
            SkipUpdateOnThis.m_SkipMaterialUpdate = true;
        }
        #endregion
    }
}
