using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Button_Setting : UI_Class.Button_Setting
{
    public Button_Setting(Button button, float pointX, float pointY, float sizeX, float sizeY, UnityAction action):base(button, pointX, pointY, sizeX,
        sizeY, action)
    {
        button.transform.position = new Vector2(Screen.width / 2 * pointX, Screen.height / 2 * pointY);
        button.image.rectTransform.sizeDelta = new Vector2(Screen.width / 2 * sizeX, Screen.height / 2 * sizeY);
    }

    public override void imageStyle(Sprite image, Color color, bool rayTarget, bool maskable, Image.Type type, int childNum)
    {
        button.image.sprite = image;
        button.image.color = color;
        button.image.raycastTarget = rayTarget;
        button.image.maskable = maskable;
        button.image.type = type;

        Text text = button.transform.GetChild(childNum).GetComponent<Text>();
        text.text = "";
        button.onClick.AddListener(action);
    }

    public override void textStyle(Font font, FontStyle fontStyle, string message, TextAnchor textAnchor, Color color, int textSize, int childNum)
    {
        Text text = button.transform.GetChild(childNum).GetComponent<Text>();
        text.font = font;
        text.fontStyle = fontStyle;
        text.text = message;
        text.alignment = textAnchor;
        text.color = color;
        text.fontSize = Screen.width / 2 / textSize;

        button.onClick.AddListener(action);
    }

    private bool _interacTable;
    public bool interacTable { set { _interacTable = value; } get { return _interacTable; } }
}
