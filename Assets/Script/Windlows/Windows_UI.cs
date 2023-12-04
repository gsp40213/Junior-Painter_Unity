using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(Windows_UI))]
public class WindwosUI_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        // 狀態欄位
        EditorGUILayout.PrefixLabel("State value");
        var script_File = target as Windows_UI;        
        script_File.file = EditorGUILayout.ObjectField("File", script_File.file, typeof(Button), true) as Button;

        var script_Edit = target as Windows_UI;
        script_Edit.edit = EditorGUILayout.ObjectField("Edit", script_Edit.edit, typeof(Button), true) as Button;

        // 按鈕欄位
        EditorGUILayout.PrefixLabel("File Button value");
        var script_createFile = target as Windows_UI;
        script_createFile.createFile = EditorGUILayout.ObjectField("Create File", script_createFile.createFile, typeof(Button), true) as Button;

        var script_saveFile = target as Windows_UI;
        script_saveFile.saveFile = EditorGUILayout.ObjectField("Save File", script_saveFile.saveFile, typeof(Button), true) as Button;

        var script_OpenFile = target as Windows_UI;
        script_OpenFile.openFile = EditorGUILayout.ObjectField("Open File", script_OpenFile.openFile, typeof(Button), true) as Button;

        var script_quit = target as Windows_UI;
        script_quit.quit = EditorGUILayout.ObjectField("Quit", script_quit.quit, typeof(Button), true) as Button;

        // 建立檔案
        EditorGUILayout.PrefixLabel("Create File value");
        var script_creatFileWdith_Input = target as Windows_UI;
        script_creatFileWdith_Input.createFileWidth_Input = EditorGUILayout.ObjectField("Wdith_Input", script_creatFileWdith_Input.createFileWidth_Input, typeof(InputField), true) as InputField;

        var script_createFileWidth_Text = target as Windows_UI;
        script_createFileWidth_Text.createFilewidth_Text = EditorGUILayout.ObjectField("Width_Text", script_createFileWidth_Text.createFilewidth_Text, typeof(Text), true) as Text;

        var script_createFileHeight_Input = target as Windows_UI;
        script_createFileHeight_Input.createFileHeight_Input = EditorGUILayout.ObjectField("Height_Input", script_createFileHeight_Input.createFileHeight_Input, typeof(InputField), true) as InputField;

        var script_createFileHeight_Text = target as Windows_UI;
        script_createFileHeight_Text.createFileheight_Text = EditorGUILayout.ObjectField("Height_Text", script_createFileHeight_Text.createFileheight_Text, typeof(Text), true) as Text;

        var script_createFileName_Input = target as Windows_UI;
        script_createFileName_Input.createFileFileName_Input = EditorGUILayout.ObjectField("FileName_Input", script_createFileName_Input.createFileFileName_Input, typeof(InputField), true) as InputField;

        var script_createFileName_Text = target as Windows_UI;
        script_createFileName_Text.createFileName_Text = EditorGUILayout.ObjectField("CreateFileName_Text", script_createFileName_Text.createFileName_Text, typeof(Text), true) as Text;

        var script_createFileTransparent_Toggle = target as Windows_UI;
        script_createFileTransparent_Toggle.createFileTransparent_Toggle = EditorGUILayout.ObjectField("Transparent_Toggle", script_createFileTransparent_Toggle.createFileTransparent_Toggle, typeof(Toggle)) as Toggle;

        var script_createFileEnter_Button = target as Windows_UI;
        script_createFileEnter_Button.createFileEnter_Btn = EditorGUILayout.ObjectField("Enter_Button", script_createFileEnter_Button.createFileEnter_Btn, typeof (Button)) as Button;
    }
}

public class Windows_UI : MonoBehaviour
{
    public Button file, edit;   
    StatusBar statusBar;

    // statusBar_File VariablesValus
    public Button createFile, saveFile, openFile, quit;
    StatusBar_File statusBar_File;

    // createFileObj VariablesValus
    public InputField createFileWidth_Input, createFileHeight_Input, createFileFileName_Input;
    CreateFile_View createFile_View;
    public Text createFilewidth_Text, createFileheight_Text, createFileName_Text;
    public Toggle createFileTransparent_Toggle;
    public Button createFileEnter_Btn;

    // 解構子
    ~Windows_UI()
    {
        statusBar = null;
        statusBar_File = null;
        createFile_View = null;
    }

   
    /// <summary>
    /// 主要執行
    /// </summary>
    private void Start()
    {
        // 介面
        statusBar = new StatusBar(file, edit);
        statusBar.StatusBar_function();

        statusBar_File = new StatusBar_File(createFile, saveFile, openFile, quit);
        statusBar_File.statusBar_File();

        createFile_View = new CreateFile_View(createFileWidth_Input, createFilewidth_Text, createFileHeight_Input, createFileheight_Text, createFileFileName_Input, createFileName_Text, createFileTransparent_Toggle, createFileEnter_Btn);
        createFile_View.createFile_View();

        
    }

    private void FixedUpdate()
    {
        // 顯示視窗-loop 更新
         statusBar_File.statusBarFile_display();
        createFile_View.createFile_display();
    }
}
