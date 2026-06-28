using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static Evan.Class_15_2_Generices;
namespace Evan
{
    public class Class_15_2_Generices : MonoBehaviour
    {
        private void Awake()
        {
            #region 不使用泛型對調
            //C#會根據相對位置將數字填入Swap方法內 所以不用讓numberA和a兩個變數名稱相同
            int numberA = 6, numberB = 4;
            LogWithColor.LogWithColors($"數字{numberA} 數字{numberB}", "#f93");
            //有ref的狀況會直接取得原本numberA和B的變數本身 能讀取且修改原始值
            //沒有ref的狀況只是在運行Swap時取得一個變數副本 不會改寫原本的預設值
            SwapNumber(ref numberA, ref numberB);
            LogWithColor.LogWithColors($"數字{numberA} 數字{numberB}", "#f93");

            char charA = '好', charB = '壞';
            LogWithColor.LogWithColors($"字{charA} 字{charB}", "#f93");
            SwapChar(ref charA, ref charB);
            LogWithColor.LogWithColors($"字{charA} 字{charB}", "#f93");

            object objA = 6f, objB = 4f;
            LogWithColor.LogWithColors($"物件{objA} 物件{objB}", "#f93");
            SwapObject(ref objA, ref objB);
            LogWithColor.LogWithColors($"物件{objA} 物件{objB}", "#f93");
            #endregion

            #region 使用泛型對調
            //原始的預設值
            bool boolA = true, boolB = false;
            LogWithColor.LogWithColors($"{boolA} {boolB}", "#f93");
            //使用對調方法
            Swap<bool>(ref boolA, ref boolB);
            LogWithColor.LogWithColors($"{boolA} {boolB}", "#f93");
            #endregion

            #region 使用泛型的類別
            //在建立物件時 <>括號內決定泛型的型別
            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);
            #endregion

        }
        
        private void Start()
        {
            #region 使用複數的泛型
            var player = new player();
            var enemy = new Enemy();
            var attackEvent = new AttackEvent<player, Enemy>();
            attackEvent.Attack(player, enemy);
            #endregion

            #region 泛型介面
            var hp = new Hp();
            var attack = new Attack();
            hp.Increase(10.5f);
            attack.Increase(50);
            hp.Increase(3.5f);
            #endregion

            #region 泛型約束
            var checker = new CheckValue<Hp, float>();
            //hp出自泛型介面裡的var hp = new Hp();
            checker.Check(hp); 
            #endregion

        } 
        

        #region 數字對調
        public void SwapNumber(ref int a, ref int b)
        {
            //要相反的看 等號前面代表目的地 等號後面代表目前起手操作的值
            int temp = a; //將a的值暫時存放到一個變數內
            a = b;         //a空了後 把b的值給a
            b = temp;     //最後把a的值從暫存變數中取出來放到b 
        }
        #endregion

        #region 字元對調
        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region 物件對調
        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region 使用泛型對調
        //把資料類型改為T (Type) 建立物件時才決定實際資料型別(string int等)
        //C# 會自動把所有 T 換成對應的型別
        //要使用<T>括號內加上T
        public void Swap<T>(ref T a, ref T b)
        {

            T temp = a;
            a = b;
            b = temp;

        }
        #endregion

        #region 使用泛型的類別
        public class DataPlayer<T>
        {
            // T 是泛型型別 代表一個尚未決定的資料型別
            // 建立一個名為 data 的欄位
            // 等到建立物件時才決定 T 是 int string float 等型別
            public T data;
            public void LogData(T data)
            {
                LogWithColor.LogWithColors(data, "#3ff");
            }

        }
        #endregion

        #region 使用複數泛型的類別
        #region 說明
        //使用複數的泛型建立一個玩家和敵人互相攻擊的方法

        //將玩家和敵人放在同一個方法裡面可以精簡程式碼
        //而不需要拆開寫成兩種方法如 玩家攻擊敵人PlayerAttackEnemy();和敵人攻擊玩家EnemyAttackPlayer();

        //使用泛型可以把類別抽象化 而不用重複寫各種角色攻擊對方的方法 如以下
        // public class AttackPlayerEnemy 玩家攻擊敵人
        //{
        //    public void Attack(Player player, Enemy enemy)
        //    {

        //    }
        //}
        //public class AttackEnemyPlayer 敵人攻擊玩家
        //{
        //    public void Attack(Enemy enemy, Player player)
        //    {

        //    }
        //}
        // public void Attack(T attacker, U defender) 泛型的T和U就可以代表任何攻擊者和防禦者
        // U位置放任何防禦者的類別如Enemy類別 defender是變數名稱 意思是當要執行攻擊或扣血等行為時
        // 就使用例如defender.HP -= 10; defender就可以直接代表任何角色的類別
        // 建立物件時再決定：AttackEvent<Player, Enemy> 或著 AttackEvent<Enemy, Player> 也可以AttackEvent<NPC, Boss> 
        #endregion
        public class player { }
        public class Enemy { }
        //習慣的泛型代號 T, U, V
        public class AttackEvent<T, U>
        {
            public void Attack(T attacker, U defender)
            {
                LogWithColor.LogWithColors($"{attacker}攻擊{defender}", "#f3f");
            }
        }
        #endregion

        #region 泛型介面
        public interface IStat<T>
        {
            //該狀態的值 T是暫代型別 之後實作再帶入如int float等數字型別
            //value 變數名稱
            //{ get; set; } 可以被讀取（get）也可以被修改（set）
            public T value { get; set; }
            //如果在 set { ... } 裡面有 value  那是 C# 保留的特殊變數 其他地方的 value 則只是一般名稱 你可以自由命名
            //增加該狀態數值 increase方法 T是暫代型別 amount變數名稱
            public void Increase(T amount);
        }

        public class Attack : IStat<int>
        {
            //定義T為int value是變數名稱
            //介面（interface）不能宣告欄位（Field）不能用public int value;  因此要使用{ get; set; }
            //C# 的開發習慣也會優先使用屬性而非公開欄位 因為保留未來加入驗證 通知或其他邏輯的彈性
            public int value { get; set; }
            //沿用Istate介面的方法 將T帶入int
            public void Increase(int amount)
            {
                //int的值 加上之後在Start裡面帶入的值到amount中
                //int的值可指定預設值 目前無
                //+=代表 value值加上amount值產生的結果
                value += amount;
                LogWithColor.LogWithColors($"攻擊力：{value}", "#f3f");
            }
        }     

        public class Hp : IStat<float>
        {
            public float value { get; set; }
            public void Increase(float amount)
            {
                value += amount;
                LogWithColor.LogWithColors($"血量：{value}", "#f3f");
            }

        }
        #endregion

        #region 泛型的約束
        //限制 T 必須是一個有實作 IStat<U> 介面的型別
        //當你使用 CheckValue<某個型別>時 編譯器會檢查那個型別是否符合這個限制
        //如果符合就允許，不符合就直接編譯錯誤

        //CheckValue<T, U>裡面的T和U 代表public class Hp : IStat<float>裡面的Hp和float
        //現在要檢查的是型別 相對位置是第二個即U(float) 因此where T : IStat<U> 括號內要填U
        public class CheckValue<T, U> where T : IStat<U>
        {
            public void Check(T stat)
            {
                LogWithColor.LogWithColors($"狀態的值：{stat.value}", "#f3d3");
            }
        } 
        #endregion
    }

}
