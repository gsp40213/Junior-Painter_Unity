using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UnityEngine;


public abstract class IO_Class
{    
    public abstract class OpenFile{

        protected string title;
        protected string filter;        
        protected OpenFileDialog openfile;

        public OpenFile(string title, string filter, OpenFileDialog openfile)
        {
            this.title = title;
            this.filter = filter;
            this.openfile = openfile;
        }

        public abstract void function(GameObject obj);
    }

    public abstract class SaveFile{

        protected string title;
        protected string filter;
        protected SaveFileDialog savefile;
        protected Texture2D canvas;
        
        public SaveFile(string title, string filter, SaveFileDialog savefile, Texture2D canvas)
        {
            this.title = title;
            this.filter = filter;
            this.savefile = savefile;
            this.canvas = canvas;
        }

        public abstract void function(GameObject obj);

    }
}
