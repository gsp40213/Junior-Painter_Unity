using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class Canvas_Class
{
    // protected Texture2D canvas_textrue2d;
    protected bool transparent;
    protected int width;
    protected int height;

    public Canvas_Class(bool transparent, int width, int height)
    {
        this.transparent = transparent;
        this.width = width;
        this.height = height;
    }

    public abstract GameObject transparentFunction();
}

