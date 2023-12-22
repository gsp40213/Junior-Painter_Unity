using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Setting : UI_Class.Image_Setting
{
    public Image_Setting(Image image, float pointX, float pointY, float sizeX, float sizeY) :
       base(image, pointX, pointY, sizeX, sizeY)
    {
        image.rectTransform.position = new Vector2(Screen.width / 2 * pointX, Screen.height / 2 * pointY);
        image.rectTransform.sizeDelta = new Vector2(Screen.width / 2 * sizeX, Screen.height / 2 * sizeY);
    }

    public override void function(Sprite sprite)
    {
        image.sprite = sprite;
    }

    public override void scrollRectImage(Sprite sprite, bool horizontal, bool vertical, RectTransform content)
    {
        // scrollRect Setting
        ScrollRect scrollRect = image.gameObject.AddComponent<ScrollRect>();
        scrollRect.content = content;
        scrollRect.horizontal = horizontal;
        scrollRect.vertical = vertical;

        // mask
        Mask mask = image.gameObject.AddComponent<Mask>();
        mask.showMaskGraphic = true;
    }
}
