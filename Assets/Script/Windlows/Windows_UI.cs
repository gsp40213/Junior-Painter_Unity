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
    }
}

public class Windows_UI : MonoBehaviour
{
    public Button file, edit;   
    StatusBar statusBar;

    public Button createFile, saveFile, openFile, quit;
    StatusBar_File statusBar_File;

    // 解構子
    ~Windows_UI()
    {
        statusBar = null;
        statusBar_File = null;
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
    }

    private void FixedUpdate()
    {
        // 顯示視窗-loop 更新
        statusBar_File.statusBarFile_display();
    }
}
