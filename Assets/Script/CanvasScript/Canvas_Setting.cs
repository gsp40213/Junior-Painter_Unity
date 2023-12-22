using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Setting : Canvas_Class
{
    private Texture2D canvasImage;
    private GameObject CanvasObj;

    public Canvas_Setting (bool transparent, int width, int height) : base(transparent, width, height)
    {
        canvasImage = new Texture2D(width, height);        
    }

    public override GameObject canvasFunction()
    {
        
        
        if (GameObject.Find("CanvasObj") == null)
        {
            CanvasObj = new GameObject("CanvasObj");
            CanvasObj.AddComponent<RectTransform>();
            CanvasObj.AddComponent<CanvasRenderer>();
            CanvasObj.AddComponent<RawImage>();

            GameObject canvas_parent = GameObject.Find("Canvas");
            CanvasObj.transform.parent = canvas_parent.transform;

            RawImage rawImage = CanvasObj.GetComponent<RawImage>();
            rawImage.texture = canvasSetting();

            return CanvasObj;
        }

        return CanvasObj;
    }

    private Texture2D canvasSetting()
    {
        VariablesValus.CANVAS_RECT_TRANSFORM = canvasFunction().GetComponent<RectTransform>();
        VariablesValus.CANVAS_RECT_TRANSFORM.anchoredPosition = new Vector2(Screen.width / Screen.width, Screen.height / Screen.height);

        VariablesValus.CANVAS_RECT_TRANSFORM.sizeDelta = new Vector2(canvasImage.width, canvasImage.height);
        VariablesValus.CANVAS_RECT_TRANSFORM.pivot = new Vector2(0.5f, 0.5f);
        VariablesValus.CANVAS_RECT_TRANSFORM.localScale = new Vector2(1, 1);

        canvasImage.SetPixels(canvasTransparent());
        canvasImage.Apply();

        return canvasImage;
    }

    // 透明度
    private Color[] canvasTransparent()
    {
        Color[] color = new Color[canvasImage.width * canvasImage.height];

        for (int x = 0; x < color.Length; x++)
        {
            if (transparent.Equals(true))
                color[x] = new Color(0, 0, 0, 0);
            else color[x] = Color.white;
        }

        return color;
    }
}
