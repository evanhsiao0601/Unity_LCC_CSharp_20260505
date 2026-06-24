using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 介面物件：實作介面的物件
    /// </summary>
    public class Class_15_InterfaceObject
    {

    }

    //介面的使用步驟
    //1. 定義介面和介面成員
    //2. 類別實作介面
    //3. 實作介面成員

    //步驟1
    //建立帶有使用功能的介面 遊戲內可被使用的物品都會繼承這個父類別
    public interface IUse //命名規則：介面類型都會在變數名稱前加上大寫i　
    {
        //不用宣告方法主體 不用寫大括號
        public void Use();
    }

    //步驟2
    //C#只能繼承一個父類別 但可以多重實作介面 (不同物品可以繼承同一個父類別)
    public class Weapon : IUse 
    {
        public void Use()
        {
            Debug.Log($"<color=#fa3>使用武器，施展武器技能<color/>");
        }
    }
    public class Potions : IUse
    {
        public void Use()
        {
            Debug.Log($"<color=#fa3>使用藥水，恢復魔力<color/>");
        }
    }
    public class Chest : IUse
    {
        public void Use()
        {
            Debug.Log($"<color=#fa3>使用寶箱，獲得隨機道具<color/>");
        }
    }
}
