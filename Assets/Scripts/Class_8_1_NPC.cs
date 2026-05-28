using UnityEngine;
/// <summary>
/// NPC類別
/// 包含NPC的名稱和對話內容資料 有輸出N
/// </summary>
public class Class_8_1_NPC
{

    private string name;
    private string diaogue;

    //建構子：沒有傳回類型 名稱和類別相同的公開方法
    //預設建構子：沒有參數
    public Class_8_1_NPC()
    {
        Debug.Log($"<color=#f39>預設建構子</color>");
    }

    //建構子：有參數 可命名的NPC
    public Class_8_1_NPC(string _name)
    {
        name = _name;
        Debug.Log($"<color=#f39>有參數的構子</color>");
    }


    public void npcName()
    {
        Debug.Log($"<color=#f39>NPC的名稱{name}</color>");
        //Debug.Log($"NPC的名稱{name}"); 不設定字體和其顏色的寫法
    }
    public void npcTalk()
    {
        Debug.Log($"<color=#f39>{diaogue}</color>");

    }
    }
