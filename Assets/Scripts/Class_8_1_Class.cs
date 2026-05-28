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
           
            //NPC實體化並儲存在npcJack變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC();
            //因先前有Class_8_1_NPC(string _name) 所以能在(string _name)中命名
            Class_8_1_NPC npcEvan = new Class_8_1_NPC("Evan");

            //執行Class_8_1_NPC裡面npcName方法 在Log上顯示名字
            npcJack.npcName();
            npcEvan.npcName();

        }
    }

}
