using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Setting : UI_Class.ToggleSetting
{
    public Toggle_Setting(Toggle toggle, float pointX, float pointY) : base (toggle, pointX, pointY)
    {
        toggle.transform.position = new Vector2(Screen.width / 2 * pointX, Screen.height / 2 * pointY);
    }

    public override void breakGroud_ImageType(Color color, bool rayTarget, bool maskable, Image.Type type, int childNum)
    {
        Image breakGroud = toggle.transform.GetChild(childNum).GetComponent<Image>();        
        breakGroud.color = color;
        breakGroud.raycastTarget = rayTarget;
        breakGroud.maskable = maskable;
        breakGroud.type = type;
    }

    public override void checkmark_ImageType(Color color, bool rayTarget, bool maskable, Image.Type type, Transform breakGroud_transform, int childNum)
    {
        Image checkmark = breakGroud_transform.GetChild(childNum).GetComponent<Image>();        
        checkmark.color = color;
        checkmark.raycastTarget = rayTarget;
        checkmark.maskable = maskable;
        checkmark.type = type;
    }

    public override void textStyle(FontStyle fontStyle, string message, TextAnchor textAnchor, Color color, int textSize, int childNum)
    {
        Text text = toggle.transform.GetChild(childNum).GetComponent<Text>();

        text.fontStyle = fontStyle;
        text.text = message;
        text.alignment = textAnchor;
        text.color = color;
        text.fontSize = Screen.width / Screen.width * textSize;
    }
}
