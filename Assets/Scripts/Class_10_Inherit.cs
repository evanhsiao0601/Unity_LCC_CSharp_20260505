using UnityEngine;
namespace Evan
{
    public class Class_10_Inherit : MonoBehaviour
    {
        /// <summary>
        /// 繼承 (Inherit)
        /// </summary>
        private void Awake()
        {
            //建立哥布林和史萊姆
            var goblin1 = new Goblin(10, 1);
            LogWithColor.LogWithColors($"哥不林A的攻擊：{goblin1.attack}", "#f3d");
            var slime1 = new Slime(3, 2);
            LogWithColor.LogWithColors($"史萊姆A的攻擊：{slime1.attack}", "#f3d");
            //顯示史萊姆(子類別)是否成功覆寫哥布林(父類別)
            goblin1.Move();
            slime1.Move();
            slime1.Intilize();

            //判斷史萊姆是否繼承哥布林
            //類別A is 類別B : 布林值
            var slimeIsGoblin = slime1 is Goblin;
            LogWithColor.LogWithColors($"史萊姆A是否為哥布林：{slimeIsGoblin}", "#f3d");
            //建立蜘蛛
            var spider1 = new Spider(15, 3);
            //判斷蜘蛛是否繼承史萊姆(多層繼承)
            var spderIsSlime = spider1 is Slime;
            LogWithColor.LogWithColors($"蜘蛛A是否為史萊姆：{slimeIsGoblin}", "#f3d");
            //判斷蜘蛛是否繼承哥布林
            var spderIsGoblin = spider1 is Goblin;
            LogWithColor.LogWithColors($"蜘蛛A是否為哥布林：{slimeIsGoblin}", "#f3d");

        }


        public class Goblin
        {
            public int attack;        //公開：所有類別可存取
            public int defense;
            private float moveSpeed;　//私人：此類別可存取　
            protected float hp;　　　 //保護：子類別可存取
            protected int lv = 5;

            public Goblin(int _attack, int _defense)
            {
               attack = _attack;
               defense = _defense;
                
            }
            //virtual 虛擬：允許子類別複寫
            public virtual void Move()
            {
                LogWithColor.LogWithColors("兩條腿移動", "#f3d");
            }

        }


        //繼承分為：
        //1. 單層繼承：Slime繼承Goblin
        //2. 多層繼承：Spider繼承Slime Slime繼承Goblin
        //3. 分層繼承：Spoder和Slime 同時繼承Goblin

        //繼承讓類別可以繼承另一個類別 擁有該類別的成員
        //C#僅提供單一繼承(只能繼承一個類別)
        //子類別：父類別

        #region 單層繼承
        public class Slime : Goblin
        {
            //在子類別底下 修改父類別的原始數值
            protected int lv = 10;
            //base 父類別原始變數資料
            public Slime(int _attack, int _defense) : base(_attack, _defense)
            {
            }

            public void Intilize()
            {
                attack = 7;          //公開：可存取
                // movespeed = 3.5f; //私人：無法存取
                hp = 10;             //保護：可存取因在子類別

            }

            //接續上面virtual 這邊在Slime的類別下複寫原始資料 覆寫父類別有virtual的成員
            //快速完成：打override選擇覆寫成員後按Enter完成
            public override void Move()
            {
                LogWithColor.LogWithColors("爬行", "#f3d");
                //顯示在子類別修改後的數值
                LogWithColor.LogWithColors($"等級{lv}", "#78f");
                //顯示父類別原始的數值
                LogWithColor.LogWithColors($"等級{base.lv}父類別", "#78f");
            } 
            }
        #endregion

        #region 多層繼承
        //多層繼承：Spider繼承Slime Slime繼承Goblin
        //只要成功繼承上一個 就會自動一路繼承到最頂層 所以Spider也繼承Goblin
        public class Spider : Slime
        {
            public Spider(int _attack, int _defense) : base(_attack, _defense)
            {
            }
        #endregion

        }

    }

}
