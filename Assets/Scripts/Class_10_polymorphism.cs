using System;
using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 多型 (Polymorphism)
    /// </summary>
    public class Class_10_polymorphism : MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("落穴", 3);
            Magic magic1 = new Magic("死者甦醒", 5);

            //多型：多種型式 可以使用父親或自己的成員
            trap1.Information(); //型式1：呼叫父親類別的無參數方法
            trap1.Information(37); //型式2：呼叫自己有參數的方法

            //多型：當一個建構子使用override覆寫原本的父類別資料
            //即Magic為Card的子類別 但覆寫原本父類別資料後
            //C#會根據實體化的物件名稱去抓取相應的資料 即根據右邊的new Magic
            //所以即便方法名稱相同 也會抓取正確的資料
            Card card1 = new Card("一般卡片", 0);
            Magic magic2 = new Magic("羽毛", 7);
            card1.Information();  //型式1：呼叫Card的方法
            magic2.Information(); //型式2：呼叫Magic的方法

        }
    }

    //建立基礎(base)
    public class Card
    {
        public string name;
        public int cost;
        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        //需要添加virtual 之後的子類別才可以override覆寫原本的父類別資料
        public virtual void Information() //無參數方法
        {
            LogWithColor.LogWithColors("這是一張卡牌", "#aaa");
        }


    }

    //分層繼承：Trap和Magic都繼承Card
    //Trap繼承Card
    public class Trap : Card
    {    public Trap(string _name, int _cost) : base(_name, _cost)
        {
        }  
        public void Information(int index) //有參數方法
        {
            LogWithColor.LogWithColors($"這是一張陷阱卡牌 編號{index}", "#f77");
        }
        //只有給予一個欄位 數據才會保留下來直到修改或銷毀 所以index並不會存下來
        //保存數據的方法寫法：
        //public class Trap {
        //private int damage;
        //public void information(int _damage)
        //{
        //     damage = _damage;
        // }
        //}

    }

    //Magic繼承Card
    public class Magic : Card
    {       
        public Magic(string _name, int _cost) : base(_name, _cost)
        {
        }
        public override void Information()
        {
            LogWithColor.LogWithColors("這是一張魔法卡牌", "#f77");
        }
    }


}
