using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Forms;
using System.IO;

public class OpenFile_Setting : IO_Class.OpenFile
{
    public OpenFile_Setting(string title, string filter, OpenFileDialog openfile): base(title, filter, openfile) { }

    public static string FILE_PATH;

    public override void function(GameObject obj)
    {
        openfile.Title = title;
        openfile.Filter = filter;
        openfile.ShowDialog();

        if(openfile.FilterIndex == 1)
        {
            if (File.Exists(openfile.FileName))
            {
                FILE_PATH = openfile.FileName;
                MonoBehaviour.Instantiate(obj, obj.transform.position, obj.transform.rotation);
            }
        }
    }
}
