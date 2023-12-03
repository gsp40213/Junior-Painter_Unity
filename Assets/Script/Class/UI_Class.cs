using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public abstract class UI_Class
{
    /// <summary>
    /// Button Setting
    /// </summary>
    /// <para Button="Obj"></para>
    /// <para pointXY="float"></para>
    /// <para sizeXY="float"></para>
    /// <para onClick="UnityAction"></para>

    public abstract class Button_Setting
    {

        protected float pointX, pointY, sizeX, sizeY;
        protected UnityAction action;
        protected Button button;

        public Button_Setting(Button button, float pointX, float pointY, float sizeX, float sizeY, UnityAction action)
        {

            this.button = button;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.action = action;
        }

        /// <summary>
        /// text_Button
        /// </summary>
        /// <param font="Font"></param>
        /// <param fontStyle="FontStyle"></param>
        /// <param message="string"></param>
        /// <param textAnchor="TextAnchor"></param>
        /// <param color="Color"></param>
        /// <param textSize="int"></param>

        public abstract void textStyle(Font font, FontStyle fontStyle, string message, TextAnchor textAnchor, Color color,
            int textSize, int childNum);

        /// <summary>
        /// image_Button
        /// </summary>
        /// <param image="Sprite"></param>
        /// <param color="Color"></param>
        /// <param rayTarget="bool"></param>
        /// <param maskable="bool"></param>
        /// <param type="Type"></param>
        public abstract void imageStyle(Sprite image, Color color, bool rayTarget, bool maskable, Image.Type type, int childNum);

    }

    /// <summary>
    /// Image Setting
    /// </summary>
    /// <para Image="Obj"></para>
    /// <para pointXY="float"></para>
    /// <para sizeXY="float"></para>    
    public abstract class Image_Setting
    {
        protected Image image;
        protected float pointX, pointY, sizeX, sizeY;

        public Image_Setting(Image image, float pointX, float pointY, float sizeX, float sizeY)
        {
            this.image = image;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }

        public abstract void function(Sprite sprite);

        /// <summary>
        /// scroball_Image
        /// </summary>
        /// <param sprite="Sprite"></param>
        /// <param horizontal="bool"></param>
        /// <param vertical="bool"></param>
        /// <param content="RectTransform"></param>
        /// <returns></returns>
        public abstract void scrollRectImage(Sprite sprite, bool horizontal, bool vertical, RectTransform content);
    }


    /// <summary>
    /// InputField Setting
    /// </summary>
    /// <para InputField="Obj"></para>
    /// <para pointXY="float"></para>
    /// <para sizeXY="float"></para>
    /// <para contentType="InputField.ContentType"></para>
    public abstract class InputField_Setting
    {
        protected InputField inputField;
        protected float pointX, pointY, sizeX, sizeY;
        protected InputField.ContentType contentType;

        public InputField_Setting(InputField inputField, float pointX, float pointY, float sizeX, float sizeY, InputField.ContentType contentType)
        {
            this.inputField = inputField;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.contentType = contentType;
        }

        /// <summary>
        /// textStyle
        /// </summary>
        /// <param font="Font"></param>
        /// <param fontStyle="FontStyle"></param>
        /// <param textAnchor="TextAnchor"></param>
        /// <param color="Color"></param>
        /// <param textSize="int"></param>
        public abstract void textStyle(Font font, FontStyle fontStyle, TextAnchor textAnchor, Color color, int textSize, int childNum);
    }

    /// <summary>
    /// TextSetting
    /// <para Text="obj"></para>
    /// <para pointXY="float"></para>
    /// <para sizeXY="float"></para>
    /// <para message="string"></para>
    /// <para textSize="int"></para>
    /// </summary>
    public abstract class TextSetting
    {
        protected Text text;
        protected float pointX, pointY;
        protected float sizeX, sizeY;
        protected string message;
        protected int textSize;

        public TextSetting(Text text, float pointX, float pointY, float sizeX, float sizeY, string message, int textSize)
        {
            this.text = text;
            this.pointX = pointX;
            this.pointY = pointY;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.message = message;
            this.textSize = textSize;
        }

        /// <summary>
        /// style
        /// </summary>
        /// <param font="Font"></param>
        /// <param fontStyle="FontStyle"></param>
        /// <param textAnchor="TextAnchor"></param>
        /// <param color="Color"></param>
        /// <returns></returns>
        public abstract void style(Font font, FontStyle fontStyle, TextAnchor textAnchor, Color color);

        /// <summary>
        /// areaText
        /// </summary>
        /// <param anchorsMin="Vector2"></param>
        /// <param anchorsMax="Vector2"></param>
        /// <param pivot="Vector2"></param>
        /// <returns></returns>
        public abstract void areaText(Vector2 anchorsMin, Vector2 anchorsMax, Vector2 pivot);
    }



    /// <summary>
    /// ToggleSetting
    /// </summary>
    /// <param toggle="Toggle"></param>
    /// <param pointX="float"></param>
    /// <param pointY="float"></param>
    /// <param breakGroud="Sprite"></param>
    /// <param checkmark="Sprite"></param>    
    public abstract class ToggleSetting
    {
        protected Toggle toggle;
        protected float pointX, pointY;
        protected Sprite breakGroud;
        protected Sprite checkmark;

        public ToggleSetting(Toggle toggle, Sprite breakGroud, Sprite checkmark, float pointX, float pointY)
        {
            this.toggle = toggle;
            this.breakGroud = breakGroud;
            this.checkmark = checkmark;
            this.pointX = pointX;
            this.pointY = pointY;
        }


        /// <summary>
        /// breakGroud_ImageType
        /// </summary>
        /// <param color="color"></param>
        /// <param rayTarget="bool"></param>
        /// <param maskable="bool"></param>
        /// <param type="Image.Type"></param>
        /// <param childNum="int"></param>
        public abstract void breakGroud_ImageType(Color color, bool rayTarget, bool maskable, Image.Type type, int childNum);

        /// <summary>
        /// checkmark_ImageType
        /// </summary>
        /// <param color="color"></param>
        /// <param rayTarget="bool"></param>
        /// <param maskable="bool"></param>
        /// <param type="Image.Type"></param>
        /// <param breakGroud_transform="Transform"></param>
        /// <param childNum="int"></param>
        public abstract void checkmark_ImageType(Color color, bool rayTarget, bool maskable, Image.Type type, 
            Transform breakGroud_transform, int childNum);

        /// <summary>
        /// textStyle
        /// </summary>
        /// <param font="Font"></param>
        /// <param fontStyle="FontStyle"></param>
        /// <param message="string"></param>
        /// <param textAnchor="TextAnchor"></param>
        /// <param color="Color"></param>
        /// <param textSize="int"></param>
        /// <param childNum="int"></param>
        /// <returns></returns>
        public abstract void textStyle(Font font, FontStyle fontStyle, string message, TextAnchor textAnchor,
            Color color, int textSize, int childNum);
    }

    /// <summary>
    /// AreaSetting
    /// <para rectTransform="RectTransform"></para>
    /// <para anchorsMinMax="Vector2"></para>
    /// <para pivot="Vector2"></para>
    /// </summary>
    public abstract class AreaSetting
    {
        protected RectTransform rectTransform;
        protected Vector2 anchorsMin, anchorsMax;
        protected Vector2 pivot;

        public AreaSetting(RectTransform rectTransform, Vector2 anchorsMin, Vector2 anchorsMax, Vector2 pivot)
        {
            this.rectTransform = rectTransform;
            this.anchorsMin = anchorsMin;
            this.anchorsMax = anchorsMax;
            this.pivot = pivot;
        }

        /// <summary>
        /// area Function
        /// </summary>
        /// <param textAnchor="TextAnchor"></param>
        /// <param controlWidth="bool"></param>
        /// <param controlHeight="bool"></param>
        /// <param scaleWidth="bool"></param>
        /// <param scaleHeight="bool"></param>
        /// <param forceExpandWidth="bool"></param>
        /// <param forceExpandHeight="bool"></param>
        /// <returns></returns>
        public abstract RectTransform function(TextAnchor textAnchor, bool controlWidth, bool controlHeight,
            bool scaleWidth, bool scaleHeight, bool forceExpandWidth, bool forceExpandHeight);

        /// <summary>
        /// default area
        /// </summary>
        /// <param sizeDelta="Vector2"></param>
        /// <returns></returns>
        public abstract RectTransform defaultArea(Vector2 sizeDelta);

    }
}
