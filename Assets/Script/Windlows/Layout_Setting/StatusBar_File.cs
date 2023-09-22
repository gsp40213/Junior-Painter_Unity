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

        // 取得按鈕底下Text物件屬性
        createFileTextFont = createFile.transform.GetChild(0).GetComponent<Text>().font;
        saveFileTextFont = saveFile.transform.GetChild(0).GetComponent<Text>().font;
        openFileTextFont = openFile.transform.GetChild(0).GetComponent<Text>().font;
        quitTextFont = quit.transform.GetChild(0).GetComponent<Text>().font;
    }

    // 建立檔案
    public void createFile_Active()
    {
        Debug.Log("建立新檔案按鈕");
    }

    // 開啟檔案
    public void openFile_Active()
    {
        Debug.Log("開啟檔案按鈕");
    }

    // 離開
    public void quit_Active()
    {
        Debug.Log("離開程式");
    }

    // 另存檔案
    public void saveFile_Active()
    {
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
        createFileBtn_Setting = new Button_Setting(createFile, 0.16f, 1.62f, 0.3f, 0.13f, createFile_Active);
        createFileBtn_Setting.textStyle(createFileTextFont, FontStyle.Normal, "建立新檔案", TextAnchor.MiddleCenter, Color.black, 28, 0);

        // 另存新檔
        saveFileBtn_Setting = new Button_Setting(saveFile, 0.16f, 1.48f, 0.3f, 0.13f, saveFile_Active);
        saveFileBtn_Setting.textStyle(saveFileTextFont, FontStyle.Normal, "另存新檔", TextAnchor.MiddleCenter, Color.black, 28, 0);

        // 開啟檔案
        openFileBtn_Setting = new Button_Setting(openFile, 0.16f, 1.34f, 0.3f, 0.13f, openFile_Active);
        openFileBtn_Setting.textStyle(openFileTextFont, FontStyle.Normal, "開啟檔案", TextAnchor.MiddleCenter, Color.black, 28, 0);

        // 離開
        quitBtn_Setting = new Button_Setting(quit, 0.16f, 1.2f, 0.3f, 0.13f, quit_Active);
        quitBtn_Setting.textStyle(quitTextFont, FontStyle.Normal, "離開", TextAnchor.MiddleCenter, Color.black, 28, 0);

    }
}
