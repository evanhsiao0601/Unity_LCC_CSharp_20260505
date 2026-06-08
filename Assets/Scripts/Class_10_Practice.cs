using UnityEngine;
namespace Evan
{
    public class Class_10_Practice : MonoBehaviour
    {
        private void Awake()
        {
            Item item1 = new Item("道具");
            Potion potion1 = new Potion("藥水");
            Equip equip1 = new Equip("裝備");
            //都呼叫相同方法名稱的狀況下 C#會根據實體化採用的類別名稱去抓資料 例右邊的new Item
            item1.Description();
            potion1.Description(30);
            equip1.Description();
        }

    }

    public class Item
    {
        public string name;
        public Item(string _name) 
        { 
        name = _name;
        }
        public virtual void Description()
        {
            LogWithColor.LogWithColors("這是道具", "#f93");
        }

    }

    public class Potion : Item
    {
        public Potion (string _name) : base(_name)
        {
        }
        public void Description(int cost)
        {
            LogWithColor.LogWithColors($"這是藥水 消耗{cost}", "#f93");
        }

    }

    public class Equip : Item
    {
        public Equip(string _name) : base(_name)
        {
        }
        public override void Description()
        {
            LogWithColor.LogWithColors("這是裝備", "#f93");
        }

    }

}
