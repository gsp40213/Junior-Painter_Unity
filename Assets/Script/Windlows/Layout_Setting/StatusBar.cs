using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 狀態攔: Active-Interface
/// </summary>
public class StatusBar : StatisBar_Interface
{
    // 檔案按鈕
    private Button file;
    private Button_Setting fileBtn_Setting;
    private Font fileTextFont;

    // 編輯按鈕
    private Button edit;
    private Button_Setting editBtn_Setting;
    private Font editTextFont;

    ~StatusBar(){

        fileBtn_Setting = null;
        editBtn_Setting = null;
    }

    public StatusBar(Button file_btn, Button edit_btn)
    {
        this.file = file_btn;
        this.edit = edit_btn;

        fileTextFont = file.transform.GetChild(0).GetComponent<Text>().font;
        editTextFont = edit.transform.GetChild(0).GetComponent<Text>().font;
    }

    // FileBtn OnClick
    public void file_Active()
    {
        VariablesValus.STARTUSBAR_SW_SET = 1;
        VariablesValus.FILE_ACTIVE_SW_SET = !VariablesValus.FILE_ACTIVE_SW_GET;
        VariablesValus._CREATE_ACTVIE_SW_SET = false;
    }

    // EditBtn OnClick
    public void edit_Active()
    {
        VariablesValus.STARTUSBAR_SW_SET = 2;
        VariablesValus.FILE_ACTIVE_SW_SET = false;

        Debug.Log("編輯按鈕");
    }

    public void StatusBar_function()
    {
        // fileButton
        fileBtn_Setting = new Button_Setting(file, VariablesValus.FILE_BTN_POINTX, VariablesValus.FILE_BTN_POINTY, VariablesValus.FILE_BTN_SIZEX, VariablesValus.FILE_BTN_SIZEY, file_Active);
        fileBtn_Setting.textStyle(fileTextFont, FontStyle.Normal, VariablesValus.CREATEFILE_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.FILE_BTN_TEXTSIZE, VariablesValus.FILE_BTN_CHILDNUM);

        // editButton
        editBtn_Setting = new Button_Setting(edit, VariablesValus.EDITOR_BTN_POINTX, VariablesValus.EDITOR_BTN_POINTY, VariablesValus.EDITOR_BTN_SIZEX, VariablesValus.EDITOR_BTN_SIZEY, edit_Active);
        editBtn_Setting.textStyle(editTextFont, FontStyle.Normal, VariablesValus.EDITOR_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.EDITOR_BTN_TEXTSIZE, VariablesValus.EDITOR_BTN_CHILDNUM);
    }
}