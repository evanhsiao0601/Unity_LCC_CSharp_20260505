using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 類別 (Class)
    /// 用來定義一個物件以及他所擁有的資料與功能(成員)
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        private void Awake()
        {

            //NPC實例化並儲存在npcJack變數內
            //創建的實例會根據new Class_8_1_NPC("Jack")括號內參數的數量代入Class_8_1_NPC裡腳本相應的建構子
            Class_8_1_NPC npcJack = new Class_8_1_NPC("Jack");
            //因先前在Class_8_1_NPC類別腳本中 有Class_8_1_NPC(string _name) (string _dialogue)所以能在括號內填入兩個數值
            Class_8_1_NPC npcEvan = new Class_8_1_NPC("Evan", "你好");

            //執行Class_8_1_NPC腳本裡面npcName方法 在Log上顯示名字或對話
            npcJack.npcName();
            npcEvan.npcName();
            npcJack.npcTalk();
            npcEvan.npcTalk();

        }
    }

}
