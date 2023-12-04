using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateFile_View : CreateFile_Interface
{
    // inputWith Setting
    private InputField inputWidth;
    private Input_Setting inputWidth_Setting;
    private Font inputWidth_Font;

    private Text textWdith;
    private Text_Setting textWidth_Setting;
    private Font textWidth_Font;

    // inputHeight Setting
    private InputField inputHeight;
    private Input_Setting inputHeight_Setting;
    private Font inputHeight_Font;

    private Text textHeight;
    private Text_Setting textHeight_Setting;
    private Font textHeight_Font;

    // fileName Setting
    private InputField inputFileName;
    private Input_Setting inputFileName_Setting;
    private Font inputFileName_Font;

    private Text textFileName;
    private Text_Setting textFileName_Setting;
    private Font textFileName_Font;

    // transparent Setting
    private Toggle toggleTransparent;
    private Toggle_Setting toggleTransparent_Setting;

    // Enter Button Setting
    private Button buttonEnter;
    private Button_Setting buttonEnter_Setting;
    private Font buttonEnter_Font;

    public CreateFile_View(InputField inputWidth, Text textWdith, InputField inputHeight, Text textHeight, InputField inputFileName,
        Text textFileName, Toggle toggleTransparent, Button buttonEnter)
    {
        this.inputWidth = inputWidth;
        this.textWdith = textWdith;
        this.inputHeight = inputHeight;
        this.textHeight = textHeight;
        this.inputFileName = inputFileName;
        this.textFileName = textFileName;
        this.toggleTransparent = toggleTransparent;
        this.buttonEnter = buttonEnter;

        // getChild
        getChild();

    }

    private void getChild()
    {
        // get Font 
        inputWidth_Font = inputWidth.transform.GetChild(0).GetComponent<Text>().font;
        textWidth_Font = textWdith.font;
        inputHeight_Font = inputHeight.transform.GetChild(0).GetComponent<Text>().font;
        textHeight_Font = textHeight.font;
        inputFileName_Font = inputFileName.transform.GetChild(0).GetComponent<Text>().font;
        textFileName_Font = textFileName.font;
        buttonEnter_Font = buttonEnter.transform.GetChild(0).GetComponent<Text>().font;
    }

    public void ceateFileEnter_Active()
    {
        Debug.Log("建立檔案成功");
        //  VariablesValus.FILE_ACTIVE_SW_SET = false;
    }

    public void createFile_display()
    {        
        inputWidth.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        textWdith.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        inputHeight.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        textHeight.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        inputFileName.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        textFileName.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        toggleTransparent.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);
        buttonEnter.gameObject.SetActive(VariablesValus._CREATE_ACTVIE_SW_GET);

    }

    public void createFile_View()
    {
        // inputWidth
        inputWidth_Setting = new Input_Setting(inputWidth, VariablesValus.CREATEFILE_INPUTWIDTH_FIELD_POINTX, VariablesValus.CREATEFILE_INPUTWIDTH_FIELD_POINTY, VariablesValus.CREATEFILE_INPUTWIDTH_FIELD_SIZEX, VariablesValus.CREATEFILE_INPUTWIDTH_FIELD_SIZEY, InputField.ContentType.IntegerNumber);
        inputWidth_Setting.textStyle(inputWidth_Font, FontStyle.Normal, TextAnchor.MiddleCenter, Color.black, VariablesValus.CREATEFILE_INPUTWIDTH_FIELD_TEXTSIZE, VariablesValus.CREATEFILE_INPUTWIDTH_FIELD_CHILDNUM);

        textWidth_Setting = new Text_Setting(textWdith, VariablesValus.CREATEFILE_TEXTWIDTH_POINTX, VariablesValus.CREATEFILE_TEXTWIDTH_POINTY, VariablesValus.CREATEFILE_TEXTWIDTH_SIZEX, VariablesValus.CREATEFILE_TEXTWIDTH_SIZEY, VariablesValus.CREATEFILE_TEXTWIDTH_NAME, VariablesValus.CREATEFILE_TEXTWIDTH_TEXTSIZE);
        textWidth_Setting.style(textWidth_Font, FontStyle.Normal, TextAnchor.MiddleCenter, Color.white);

        // inputHeight_Setting
        inputHeight_Setting = new Input_Setting(inputHeight, VariablesValus.CREATEFILE_INPUTHEIGHT_FIELD_POINTX, VariablesValus.CREATEFILE_INPUTHEIGHT_FIELD_POINTY, VariablesValus.CREATEFILE_INPUTHEGIHT_FIELD_SIZEX, VariablesValus.CREATEFILE_INPUTHEGIHT_FIELD_SIZEY, InputField.ContentType.IntegerNumber);
        inputHeight_Setting.textStyle(inputHeight_Font, FontStyle.Normal, TextAnchor.MiddleCenter, Color.black, VariablesValus.CREATEFILE_INPUTHEGIHT_FIELD_TEXTSIZE, VariablesValus.CREATEFILE_INPUTHEGIHT_FIELD_CHILDNUM);

        textHeight_Setting = new Text_Setting(textHeight, VariablesValus.CREATEFILE_TEXTHEIGHT_POINTX, VariablesValus.CREATEFILE_TEXTHEIGHT_POINTY, VariablesValus.CREATEFILE_TEXTHEIGHT_SIZEX, VariablesValus.CREATEFILE_TEXTHEIGHT_SIZEY, VariablesValus.CREATEFILE_TEXTHEIGHT_NAME, VariablesValus.CREATEFILE_TEXTHEIGHT_TEXTSIZE);
        textHeight_Setting.style(textHeight_Font, FontStyle.Normal, TextAnchor.MiddleCenter, Color.white);

        // inputFileName_Setting
        inputFileName_Setting = new Input_Setting(inputFileName, VariablesValus.CREATEFILE_INPUTFILENAME_FIELD_POINTX, VariablesValus.CREATEFILE_INPUTFILENAME_FIELD_POINTY, VariablesValus.CREATEFILE_INPUTFILENAME_FIELD_SIZEX, VariablesValus.CREATEFILE_INPUTFILENAME_FIELD_SIZEY, InputField.ContentType.Name);
        inputFileName_Setting.textStyle(inputFileName_Font, FontStyle.Normal, TextAnchor.MiddleCenter, Color.black, VariablesValus.CREATEFILE_INPUTFILENAME_FIELD_TEXTSIZE, VariablesValus.CREATEFILE_INPUFILENAME_FILE_CHILDNUM);

        textFileName_Setting = new Text_Setting(textFileName, VariablesValus.CREATEFILE_TEXTFILE_POINTX, VariablesValus.CREATEFILE_TEXTFILE_POINTY, VariablesValus.CREATEFILE_TEXTFILE_SIZEX, VariablesValus.CREATEFILE_TEXTFILE_SIZEY, VariablesValus.CREATEFILE_TEXTFILE_NAME, VariablesValus.CREATEFILE_TEXTFILE_TEXTSIZE);
        textFileName_Setting.style(textFileName_Font, FontStyle.Normal, TextAnchor.MiddleCenter, Color.white);

        // transparentToggle_Setting
        toggleTransparent_Setting = new Toggle_Setting(toggleTransparent, VariablesValus.CREATEFILE_TRANSPARENT_TOGGLE_POINTX, VariablesValus.CREATEFILE_TRANSPARENT_TOGGLE_POINTY);
        toggleTransparent_Setting.breakGroud_ImageType(Color.white, true, true, Image.Type.Simple, VariablesValus.CREATEFILE_TRANSPARENT_BREAKGROUD_CHILDNUM);
        Transform breakGroud_Toggle = toggleTransparent.transform.GetChild(0).transform;
        toggleTransparent_Setting.checkmark_ImageType(Color.white, true, true, Image.Type.Simple, breakGroud_Toggle, VariablesValus.CREATEFILE_TRANSPARENT_CHECKMARK_CHILDNUM);
        toggleTransparent_Setting.textStyle(FontStyle.Normal, VariablesValus.CREATEFILE_TRANSPARENT_NAME, TextAnchor.MiddleCenter, Color.white, VariablesValus.CREATEFILE_TRANSPARENT_TEXTSIZE, VariablesValus.CREATEFILE_TRANSPARENT_TEXT_CHILDNUM);
        
        // buttonEnter_Setting
        buttonEnter_Setting = new Button_Setting(buttonEnter, VariablesValus.CREATEFILE_ENTER_BTN_POINTX, VariablesValus.CREATEFILE_ENTER_BTN_POINTY, VariablesValus.CREATEFILE_ENTER_BTN_SIZEX, VariablesValus.CREATEFILE_ENTER_BTN_SIZEY, ceateFileEnter_Active);
        buttonEnter_Setting.textStyle(buttonEnter_Font, FontStyle.Normal, VariablesValus.CREATEFILE_ENTER_BTN_NAME, TextAnchor.MiddleCenter, Color.black, VariablesValus.CREATEFILE_ENTER_BTN_TEXTSIZE, VariablesValus.CREATEFILE_ENTER_BTN_CHILDNUM);
    }
}
