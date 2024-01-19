using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Setting : Canvas_Class
{
    private Texture2D canvasImage, transparent_Image;
    private GameObject CanvasObj, transparent;


    public Canvas_Setting(bool transparent, int width, int height) : base(transparent, width, height)
    {
        canvasImage = new Texture2D(width, height);
        transparent_Image = new Texture2D(width, height);
    }

    public override GameObject transparentFunction()
    {
        if (GameObject.Find("Transparent") == null)
        {
            transparent = new GameObject("Transparent");
            transparent.AddComponent<RectTransform>();
            transparent.AddComponent<CanvasRenderer>();
            transparent.AddComponent<RawImage>();

            GameObject canvas_parent = GameObject.Find("Canvas");
            transparent.transform.parent = canvas_parent.transform;

            RawImage rawImage = transparent.GetComponent<RawImage>();
            rawImage.texture = transparentSetting();
     
            return transparent;
        }

        return transparent;
    }

    // transparent Setting
    private Texture2D transparentSetting()
    {
        VariablesValus.CANVAS_RECT_TRANSFORM = transparentFunction().GetComponent<RectTransform>();
        VariablesValus.CANVAS_RECT_TRANSFORM.anchoredPosition = new Vector2(Screen.width / Screen.width, Screen.height / Screen.height);

        VariablesValus.CANVAS_RECT_TRANSFORM.sizeDelta = new Vector2(transparent_Image.width, transparent_Image.height);
        VariablesValus.CANVAS_RECT_TRANSFORM.pivot = new Vector2(0.5f, 0.5f);
        VariablesValus.CANVAS_RECT_TRANSFORM.localScale = new Vector2(1, 1);

        WWW path = new WWW("File://" + Application.dataPath + "/R.png");
        transparent_Image = path.texture;

        return transparent_Image;
    }

    // 透明度
    private Color[] canvasTransparent()
    {
        Color[] color = new Color[canvasImage.width * canvasImage.height];

        for (int x = 0; x < color.Length; x++)
        {
            if (VariablesValus.CREATEFILE_TRANSPARENT__VARIBALES.Equals(true))
                color[x] = new Color(0, 0, 0, 0);
            else color[x] = Color.white;
        }

        return color;
    }
}
