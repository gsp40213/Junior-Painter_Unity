using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Setting : UI_Class.TextSetting
{
    public Text_Setting(Text text ,float pointX, float pointY, float sizeX, float sizeY, string message, int textSize) 
        : base (text, pointX, pointY, sizeX, sizeY, message, textSize)
    {
        // text obj point and Size
        text.transform.position = new Vector2(Screen.width / 2 * pointX, Screen.height / 2 * pointY);
        text.rectTransform.sizeDelta = new Vector2(Screen.width / 2 * sizeX, Screen.height / 2 * sizeY);

        // text message and size
        text.text = message;
        text.fontSize = Screen.width / Screen.width * textSize;
    }

    public override void areaText(Vector2 anchorsMin, Vector2 anchorsMax, Vector2 pivot)
    {
        // area setting
        Area_Setting areaFunction = new Area_Setting(text.GetComponent<RectTransform>(), anchorsMin, anchorsMax, pivot);
        areaFunction.defaultArea(new Vector2(Screen.width / 2 * sizeX, Screen.height / 2 * sizeY));

        // text horizontal/vertical setting
        text.horizontalOverflow = HorizontalWrapMode.Overflow;
        text.verticalOverflow = VerticalWrapMode.Truncate;
    }

    public override void style(Font font, FontStyle fontStyle, TextAnchor textAnchor, Color color)
    {
        text.font = font;
        text.fontStyle = fontStyle;
        text.alignment = textAnchor;
        text.color = color;
    }

    private string _textMessage;
    public string textMessage { set { _textMessage = value; } get { return _textMessage; } }
}