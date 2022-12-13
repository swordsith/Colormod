using System.IO;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectR.API.ObjUtils
{
    internal static class ProjectRobj
    {
        #region CreatOBJ
        public static GameObject Createbox(Transform parent, Vector3 Position, Vector3 Rotation, Vector3 Scale, string name, Color color, Sprite sprite)
        {
            GameObject boxtemp = new GameObject();
            Image Box = boxtemp.AddComponent<Image>();
            Box.overrideSprite = sprite;
            boxtemp.transform.parent = parent;
            boxtemp.GetComponent<RectTransform>().localEulerAngles = Rotation;
            boxtemp.GetComponent<RectTransform>().localScale = Scale;
            boxtemp.GetComponent<RectTransform>().localPosition = Position;
            boxtemp.name = name;
            Box.color = color;
            return boxtemp;
        }
        public static void CreateTextobject(Transform parent, Vector3 Position, Vector3 Rotation, Vector3 Scale, string text, string objname, bool wordwrapping, int fontsize)
        {
            GameObject gameObject = new GameObject();
            TextMeshProUGUI textMeshPro = gameObject.AddComponent<TextMeshProUGUI>();
            textMeshPro.name = objname;
            textMeshPro.text = text;
            gameObject.transform.parent = parent;
            gameObject.GetComponent<RectTransform>().localPosition = Position;
            gameObject.GetComponent<RectTransform>().localEulerAngles = Rotation;
            gameObject.GetComponent<RectTransform>().localScale = Scale;
            textMeshPro.enableWordWrapping = wordwrapping;
            textMeshPro.fontSize = fontsize;
        }
        #endregion

        internal static Sprite LoadSpriteFromDisk(this string path)
        {
            if (string.IsNullOrEmpty(path)) { return null; }
            byte[] data = File.ReadAllBytes(path);
            if (data == null || data.Length <= 0) { return null; }
            Texture2D tex = new Texture2D(512, 512);
            if (!Il2CppImageConversionManager.LoadImage(tex, data)) { return null; }
            Sprite sprite = Sprite.CreateSprite(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f, 0, 0, new Vector4(), false);
            sprite.hideFlags |= HideFlags.DontUnloadUnusedAsset;
            return sprite;
        }
    }
}
