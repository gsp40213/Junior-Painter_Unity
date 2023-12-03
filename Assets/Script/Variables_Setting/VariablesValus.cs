﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesValus
{

    // file button actvie
    private static bool _FILE_ACTIVE_SW = false;
    public static bool FILE_ACTIVE_SW_SET { set { _FILE_ACTIVE_SW = value; } }
    public static bool FILE_ACTIVE_SW_GET { get { return _FILE_ACTIVE_SW; } }

    /* startusBar_File createFile button :
     * button point and size or button string (name, textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float CREATEFILE_BTN_POINTX = 0.16f;
    public static float CREATEFILE_BTN_POINTY = 1.62f;
    public static float CREATEFILE_BTN_SIZEX = 0.3f;
    public static float CREATEFILE_BTN_SIZEY = 0.13f;
    public static string CREATEFILE_BTN_NAME = "建立新檔案";
    public static int CREATEFILE_BTN_TEXTSZIE = 28;
    public static int CREATEFILE_BTN_CHILDNUM = 0;

    /* startusBar_File saveFile button :
     * point and size or button string (name, textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float SAVEFILE_BTN_POINTX = 0.16f;
    public static float SAVEFILE_BTN_POINTY = 1.48f;
    public static float SAVEFILE_BTN_SIZEX = 0.3f;
    public static float SAVEFILE_BTN_SIZEY = 0.13f;
    public static string SAVEFILE_BTN_NAME = "另存新檔";
    public static int SAVEFILE_BTN_TEXTSIZE = 28;
    public static int SAVEFILE_BTN_CHILDNUM = 0;

    /* startusBar_File openfile button :
     * point and size or button string (name, textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float OPENFILE_BTN_POINTX = 0.16f;
    public static float OPENFILE_BTN_POINTY = 1.34f;
    public static float OPENFILE_BTN_SIZEX = 0.3f;
    public static float OPENFILE_BTN_SIZEY = 0.13f;
    public static string OPENFILE_BTN_NAME = "開啟檔案";
    public static int OPENFILE_BTN_TEXTSIZE = 28;
    public static int OPENFILE_BTN_CHILDNUM = 0;

    /* startusBar_File quit button :
     * point and size or button string (name, textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float QUIT_BTN_POINTX = 0.16f;
    public static float QUIT_BTN_POINTY = 1.2f;
    public static float QUIT_BTN_SIZEX = 0.3f;
    public static float QUIT_BTN_SIZEY = 0.13f;
    public static string QUIT_BTN_NAME = "離開";
    public static int QUIT_BTN_TEXTSIZE = 28;
    public static int QUIT_BTN_CHILDNUM = 0;

    // startusBar active
    private static int _STARTUSBAR_SW = 0;
    public static int STARTUSBAR_SW_SET { set { _STARTUSBAR_SW = value; } }
    public static int STARTUSBAR_SW_GET { get { return _STARTUSBAR_SW; } }

    /* startusBar file button :
     * point and size or button string (name, textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float FILE_BTN_POINTX = 0.16f;
    public static float FILE_BTN_POINTY = 1.86f;
    public static float FILE_BTN_SIZEX = 0.3f;
    public static float FILE_BTN_SIZEY = 0.2f;
    public static string FILE_BTN_NAME = "檔案";
    public static int FILE_BTN_TEXTSIZE = 28;
    public static int FILE_BTN_CHILDNUM = 0;

    /* startusBar editor button :
     * point and size or button string (name, textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float EDITOR_BTN_POINTX = 0.5f;
    public static float EDITOR_BTN_POINTY = 1.86f;
    public static float EDITOR_BTN_SIZEX = 0.3f;
    public static float EDITOR_BTN_SIZEY = 0.2f;
    public static string EDITOR_BTN_NAME = "編輯";
    public static int EDITOR_BTN_TEXTSIZE = 28;
    public static int EDITOR_BTN_CHILDNUM = 0;

    /* createFile_view inputWidth inputField :
    * point and size or inputField string (textSize, chlid obj)
    * textSize Default value: 28
    * childNum Default value: 0
    */
    public static float CREATEFILE_INPUTWIDTH_FIELD_POINTX = 0.5f;
    public static float CREATEFILE_INPUTWIDTH_FIELD_POINTY = 1.3f;
    public static float CREATEFILE_INPUTWIDTH_FIELD_SIZEX = 0.3f;
    public static float CREATEFILE_INPUTWIDTH_FIELD_SIZEY = 0.15f;
    public static int CREATEFILE_INPUTWIDTH_FIELD_TEXTSIZE = 18;
    public static int CREATEFILE_INPUTWIDTH_FIELD_CHILDNUM = 0;

    /* createFile_view WidthText Text :
     * point and size or Text Number (IntegerNumber)
     * textSize Default value: 22
     */
    public static float CREATEFILE_TEXTWIDTH_POINTX = 0.78f;
    public static float CREATEFILE_TEXTWIDTH_POINTY = 1.3f;
    public static float CREATEFILE_TEXTWIDTH_SIZEX = 0.3f;
    public static float CREATEFILE_TEXTWIDTH_SIZEY = 0.15f;
    public static string CREATEFILE_TEXTWIDTH_NAME = "寬度(piexl)";
    public static int CREATEFILE_TEXTWIDTH_TEXTSIZE = 22;

    /* createFile_view inputHeight inputField :
     * point and size or inputField string (textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float CREATEFILE_INPUTHEIGHT_FIELD_POINTX = 0.5f;
    public static float CREATEFILE_INPUTHEIGHT_FIELD_POINTY = 1.1f;
    public static float CREATEFILE_INPUTHEGIHT_FIELD_SIZEX = 0.3f;
    public static float CREATEFILE_INPUTHEGIHT_FIELD_SIZEY = 0.15f;
    public static int CREATEFILE_INPUTHEGIHT_FIELD_TEXTSIZE = 18;
    public static int CREATEFILE_INPUTHEGIHT_FIELD_CHILDNUM = 0;

    /* createFile_view HeightText Text :
     * point and size or Text Number (IntegerNumber)
     * textSize Default value: 22
     */
    public static float CREATEFILE_TEXTHEIGHT_POINTX = 0.78f;
    public static float CREATEFILE_TEXTHEIGHT_POINTY = 1.1f;
    public static float CREATEFILE_TEXTHEIGHT_SIZEX = 0.3f;
    public static float CREATEFILE_TEXTHEIGHT_SIZEY = 0.15f;
    public static string CREATEFILE_TEXTHEIGHT_NAME = "高度(pixel)";
    public static int CREATEFILE_TEXTHEIGHT_TEXTSIZE = 22;

    /* createFile_view inputName inputField :
     * point and size or inputField string (textSize, chlid obj)
     * textSize Default value: 28
     * childNum Default value: 0
     */
    public static float CREATEFILE_INPUTFILENAME_FIELD_POINTX = 0.5f;
    public static float CREATEFILE_INPUTFILENAME_FIELD_POINTY = 0.9f;
    public static float CREATEFILE_INPUTFILENAME_FIELD_SIZEX = 0.3f;
    public static float CREATEFILE_INPUTFILENAME_FIELD_SIZEY = 0.15f;
    public static int CREATEFILE_INPUTFILENAME_FIELD_TEXTSIZE = 18;
    public static int CREATEFILE_INPUFILENAME_FILE_CHILDNUM = 0;

    /* createFile_view WidthText Text :
     * point and size or Text Number (IntegerNumber)
     * textSize Default value: 22
     */
    public static float CREATEFILE_TEXTFILE_POINTX = 0.87f;
    public static float CREATEFILE_TEXTFILE_POINTY = 0.9f;
    public static float CREATEFILE_TEXTFILE_SIZEX = 0.5f;
    public static float CREATEFILE_TEXTFILE_SIZEY = 0.15f;
    public static string CREATEFILE_TEXTFILE_NAME = "檔案名稱(FileName)";
    public static int CREATEFILE_TEXTFILE_TEXTSIZE = 22;
}