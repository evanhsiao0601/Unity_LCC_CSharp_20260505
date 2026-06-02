using UnityEngine;
/// <summary>
/// NPC類別
/// 包含NPC的名稱和對話內容資料 有輸出N
/// </summary>
public class Class_8_1_NPC
{
    //建構子用途：在物件（或結構）產生時 快速幫它設定初始值 可大量建立遊戲中的NPC 武器 道具等

    private string name;
    private string dialogue;

    //建構子：沒有傳回類型 名稱和類別相同的公開方法
    //預設建構子：沒有參數
    public Class_8_1_NPC()
    {
        Debug.Log($"<color=#f39>預設建構子</color>");
    }

    //建構子：有參數 可之後填入數值
    //單一參數的建構子
    //此為簡寫
    public Class_8_1_NPC(string _name) => name = _name; 

    //有複數參數的建構子 (string _name)可修改NPC名稱 (string _dialogue)可增加對話 無預設
    public Class_8_1_NPC(string _name, string _dialogue)
    {
        name = _name;
        dialogue = _dialogue;
        Debug.Log($"<color=#f39>有參數的構子</color>");
    }


    public void npcName()
    {
        Debug.Log($"<color=#f39>NPC的名稱{name}</color>");
        //Debug.Log($"NPC的名稱{name}"); 不設定字體和其顏色的寫法
    }
    public void npcTalk()
    {
        Debug.Log($"<color=#f39>{dialogue}</color>");

    }
    }
