using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 檔案按鈕事件內容
/// </summary>
public class StatusBar_File : StatusBar_File_Interface
{
    // 建立檔案按鈕
    private Button createFile;
    private Button_Setting createFileBtn_Setting;
    private Font createFileTextFont;

    // 另存檔案按鈕
    private Button saveFile;
    private Button_Setting saveFileBtn_Setting;
    private Font saveFileTextFont;

    // 開啟檔案按鈕
    private Button openFile;
    private Button_Setting openFileBtn_Setting;
    private Font openFileTextFont;

    // 離開按鈕
    private Button quit;
    private Button_Setting quitBtn_Setting;
    private Font quitTextFont;

    ~StatusBar_File()
    {
        createFileBtn_Setting = null;
        saveFileBtn_Setting = null;
        openFileBtn_Setting = null;
        quitBtn_Setting = null;
    }

    public StatusBar_File(Button createFile, Button saveFile, Button openFile, Button quit)
    {
        this.createFile = createFile;
        this.saveFile = saveFile;
        this.openFile = openFile;
        this.quit = quit;

        // get child
        getChild();
    }

   
    private void getChild()
    {
        // get Font 
        createFileTextFont = createFile.transform.GetChild(0).GetComponent<Text>().font;
        saveFileTextFont = saveFile.transform.GetChild(0).GetComponent<Text>().font;
        openFileTextFont = openFile.transform.GetChild(0).GetComponent<Text>().font;
        quitTextFont = quit.transform.GetChild(0).GetComponent<Text>().font;
    }

    // 建立檔案
    public void createFile_Active()
    {
        VariablesValus._CREATE_ACTVIE_SW_SET = true;
        VariablesValus.FILE_ACTIVE_SW_SET = false;
        Debug.Log("建立新檔案按鈕");
    }

    // 開啟檔案
    public void openFile_Active()
    {
        VariablesValus.FILE_ACTIVE_SW_SET = false;        

        Debug.Log("開啟檔案按鈕");
    }

    // 離開
    public void quit_Active()
    {
        VariablesValus.FILE_ACTIVE_SW_SET = false;
        Debug.Log("離開程式");
    }

    // 另存檔案
    public void saveFile_Active()
    {
        VariablesValus.FILE_ACTIVE_SW_SET = false;
        VariablesValus._CREATE_ACTVIE_SW_SET = false;        

        Debug.Log("另存檔按鈕");
    }    

    // Display view
    public void statusBarFile_display()
    {
        bool statusBarFileActive = (VariablesValus.FILE_ACTIVE_SW_GET == true && VariablesValus.STARTUSBAR_SW_GET == 1) ? true : false;
        
        createFile.gameObject.SetActive(statusBarFileActive);
        saveFile.gameObject.SetActive(statusBarFileActive);
        openFile.gameObject.SetActive(statusBarFileActive);
        quit.gameObject.SetActive(statusBarFileActive);
    }

    public void statusBar_File()
    {      
        // 建立新檔
        createFileBtn_Setting = new Button_Setting(createFile, VariablesValus.CREATEFILE_BTN_POINTX, VariablesValus.CREATEFILE_BTN_POINTY, VariablesValus.CREATEFILE_BTN_SIZEX, VariablesValus.CREATEFILE_BTN_SIZEY, createFile_Active);
        createFileBtn_Setting.textStyle(createFileTextFont, FontStyle.Normal, VariablesValus.CREATEFILE_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.CREATEFILE_BTN_TEXTSZIE, VariablesValus.CREATEFILE_BTN_CHILDNUM);

        // 另存新檔
        saveFileBtn_Setting = new Button_Setting(saveFile, VariablesValus.SAVEFILE_BTN_POINTX, VariablesValus.SAVEFILE_BTN_POINTY, VariablesValus.SAVEFILE_BTN_SIZEX, VariablesValus.SAVEFILE_BTN_SIZEY, saveFile_Active);
        saveFileBtn_Setting.textStyle(saveFileTextFont, FontStyle.Normal, VariablesValus.SAVEFILE_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.SAVEFILE_BTN_TEXTSIZE, VariablesValus.SAVEFILE_BTN_CHILDNUM);

        // 開啟檔案
        openFileBtn_Setting = new Button_Setting(openFile, VariablesValus.OPENFILE_BTN_POINTX, VariablesValus.OPENFILE_BTN_POINTY, VariablesValus.OPENFILE_BTN_SIZEX, VariablesValus.OPENFILE_BTN_SIZEY, openFile_Active);
        openFileBtn_Setting.textStyle(openFileTextFont, FontStyle.Normal, VariablesValus.OPENFILE_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.OPENFILE_BTN_TEXTSIZE, VariablesValus.OPENFILE_BTN_CHILDNUM);

        // 離開
        quitBtn_Setting = new Button_Setting(quit, VariablesValus.QUIT_BTN_POINTX, VariablesValus.QUIT_BTN_POINTY, VariablesValus.QUIT_BTN_SIZEX, VariablesValus.QUIT_BTN_SIZEY, quit_Active);
        quitBtn_Setting.textStyle(quitTextFont, FontStyle.Normal, VariablesValus.QUIT_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.QUIT_BTN_TEXTSIZE, VariablesValus.QUIT_BTN_CHILDNUM);

    }
}
