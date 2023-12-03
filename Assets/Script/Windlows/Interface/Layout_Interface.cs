using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  狀態攔-Active
/// </summary>
public interface StatisBar_Interface 
{
    void file_Active();
    void edit_Active();
}

/// <summary>
/// 狀態攔-檔案-Active
/// </summary>
public interface StatusBar_File_Interface
{
    void createFile_Active();
    void saveFile_Active();
    void openFile_Active();
    void quit_Active();
}

public interface CreateFile_Interface
{
    void ceateFileEnter_Active();
}
