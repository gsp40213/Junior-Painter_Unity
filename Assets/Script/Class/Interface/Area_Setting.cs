using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Area_Setting : UI_Class.AreaSetting
{

    public Area_Setting(RectTransform rectTransform, Vector2 anchorsMin, Vector2 anchorsMax, Vector2 pivot) : 
        base(rectTransform, anchorsMin, anchorsMax, pivot)
    {
        // Area area setting
        rectTransform.anchorMin = anchorsMin;
        rectTransform.anchorMax = anchorsMax;
        rectTransform.pivot = pivot;

        // Area layout setting
        rectTransform.transform.localPosition = Vector2.zero;
        rectTransform.right = Vector2.zero;
    }

    // padding four directions
    public int paddingLeft = 0;
    public int paddingRight = 0;
    public int paddingTop = 0;
    public int paddingBottom = 0;

    public float spacing = 10;

    // ContentSize horizontal/vertical
    public ContentSizeFitter.FitMode horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
    public ContentSizeFitter.FitMode verticalFit = ContentSizeFitter.FitMode.PreferredSize;


    /// <summary>
    /// contentSize
    /// </summary>
    /// <param horizontalFit="ContentSizeFitter.FitMode"></param>
    /// <param verticalFit="ContentSizeFitter.FitMode"></param>
    /// <returns></returns>
    private ContentSizeFitter contentSize(ContentSizeFitter.FitMode horizontalFit, ContentSizeFitter.FitMode verticalFit)
    {
        ContentSizeFitter contentSizeFitter = rectTransform.gameObject.AddComponent<ContentSizeFitter>();
        contentSizeFitter.horizontalFit = horizontalFit;
        contentSizeFitter.verticalFit = verticalFit;

        return contentSizeFitter;
    }

    /// <summary>
    /// verticalLayout
    /// </summary>
    /// <param textAnchor="TextAnchor"></param>
    /// <param controlWidth="bool"></param>
    /// <param controlHeight="bool"></param>
    /// <param scaleWidth="bool"></param>
    /// <param scaleHeight="bool"></param>
    /// <param forceExpandWidth="bool"></param>
    /// <param forceExpandHeight="bool"></param>
    /// <returns></returns>
    private VerticalLayoutGroup verticalLayout(TextAnchor textAnchor, bool controlWidth, bool controlHeight, bool scaleWidth, bool scaleHeight, bool forceExpandWidth, bool forceExpandHeight)
    {
        VerticalLayoutGroup verticalLayoutGroup = rectTransform.gameObject.AddComponent<VerticalLayoutGroup>();

        verticalLayoutGroup.childAlignment = textAnchor;

        verticalLayoutGroup.childControlWidth = controlWidth;
        verticalLayoutGroup.childControlHeight = controlHeight;

        verticalLayoutGroup.childScaleWidth = scaleWidth;
        verticalLayoutGroup.childScaleHeight = scaleHeight;

        verticalLayoutGroup.childForceExpandWidth = forceExpandWidth;
        verticalLayoutGroup.childForceExpandHeight = forceExpandHeight;

        verticalLayoutGroup.spacing = spacing;

        verticalLayoutGroup.padding.left = paddingLeft;
        verticalLayoutGroup.padding.right = paddingRight;
        verticalLayoutGroup.padding.top = paddingTop;
        verticalLayoutGroup.padding.bottom = paddingBottom;

        return verticalLayoutGroup;
    }

    public override RectTransform function(TextAnchor textAnchor, bool controlWidth, bool controlHeight, bool scaleWidth, bool scaleHeight, bool forceExpandWidth, bool forceExpandHeight)
    {
        throw new System.NotImplementedException();
    }

    public override RectTransform defaultArea(Vector2 sizeDelta)
    {
        rectTransform.sizeDelta = sizeDelta;
        return rectTransform;
    }
}