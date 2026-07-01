using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static Evan.Class_15_2_Generices;
using static UnityEditor.Progress;
namespace Evan
{
    /// <summary>
    /// 資料結構 (DataStruct)
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        #region 泛型清單
        //一般陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };

        //清單：泛型集合
        //修飾詞 關鍵字List <型別> 清單名稱
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playerDefens;
        #endregion
        private void Awake()
        {
            #region 泛型清單
            //清單存取與陣列相同 但陣列初始化後就無法增減長度
            //顯示第三筆資料 
            LogWithColor.LogWithColors($"第三筆{speeds[2]}", "#3f3");
            //數值改成10
            speeds[0] = 10;
            LogWithColor.LogWithColors($"第三筆{speeds[0]}", "#3f3");
            //添加一筆道具
            props.Add("寶劍");
            //刪除第一筆道具
            props.RemoveAt(0);
            //添加頭盔到編號1上
            props.Insert(1, "頭盔");

            //foreach 依序取得資料 取得一筆執行一次 var 不指定型別 prop單筆資料從props清單內各筆拿出
            foreach (var prop in props)
            {
                LogWithColor.LogWithColors($"道具{prop}", "#3f3");
            }

            //將建構子帶入陣列
            //建立一個新的List<float> 並把defens裡面的所有資料複製到新的清單中
            playerDefens = new List<float>(defens);
            //排序 由小到大
            playerDefens.Sort();
            //反排序 由大到小
            playerDefens.Reverse();

            //foreach 直接取出每一個元素
            foreach (var item in playerDefens)
            {
                LogWithColor.LogWithColors($"資料{item}", "#f93");
            }

            //Count 查詢數量的關鍵字 指清單內的資料 根據Add或Remove改變
            LogWithColor.LogWithColors($"數量{props.Count}", "#77f");
            //Capacity 指清單內的容量 系統自動分配 預設為4 並以倍數成長(C#各版本不同)
            LogWithColor.LogWithColors($"容量{props.Capacity}", "#77f");

            List<int> numbers = new List<int>();

            //for 自己控制次數或索引
            //當i等於0 小於20時 從0開始 不斷遞增 每次加1 直到19 總共執行20次
            //i++ 增加1
            for (int i = 0; i < 20; i++)
            {
                //每次都會把i加進numbers清單內 會加19次 所以從0開始 0+1=1 1+1=2 以此類推19次
                numbers.Add(i);
                LogWithColor.LogWithColors($"數量{numbers.Count}", "#77f");
                LogWithColor.LogWithColors($"容量{numbers.Capacity}", "#77f");
            }
            #endregion

            #region 泛型堆疊
            //關鍵字Stack
            //適合用在遊戲選單 或是行為undo上面 永遠都是最後做的先取消

            Stack<string> enemys = new Stack<string>();
            //Push是Stack專用的方法 把一個元素放到 Stack 的最上面
            enemys.Push("史萊姆");
            //Stack 是最後放進去的東西 要最先拿出來 新的資料一定放在最上面 
            //所以哥布林在Debug.Log裡面會先行顯示
            enemys.Push("哥布林");
            //執行下面LogStack方法
            LogStack<string>(enemys);

            //拿資料並且不移除 用Peek
            var peek = enemys.Peek();
            LogStack<string>(enemys);

            //拿資料移除 用Pop
            var pop = enemys.Pop();
            LogStack<string>(enemys);

            //判斷是否包含某筆資料 用Contains
            LogWithColor.LogWithColors($"{enemys.Contains("哥布林")}", "#36f");

            //清除所有資料
            enemys.Clear();
            LogStack<string>(enemys);
            #endregion

            #region 泛型佇列
            //關鍵字 Queue
            //先進先出 先放進來的資料先被拿出來
            Queue<string> player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("法師");
            player.Enqueue("戰士");
            LogQueue<string>(player);

            //拿出來不刪除 用Peek
            LogWithColor.LogWithColors(player.Peek(), "#f33");
            LogQueue<string>(player);

            //拿出來並刪除 用Dequeue 與pop相同
            LogWithColor.LogWithColors(player.Dequeue(), "#f33");
            LogQueue<string>(player);
            #endregion

            #region 泛型鏈結串列
            //鏈結串列可以自由的決定將資料加到哪一個位置
            //建立一個字串陣列 0是火球 1是冰錐
            string[] skillsArray = new string[] { "火球", "冰錐" };
            //建立一個名為skills的LinkedList<string> 並把skillsArray的資料放進去
            LinkedList<string> skills = new LinkedList<string>(skillsArray);
            LogLinkedList<string>(skills);

            //把落雷加到字串陣列的最後
            skills.AddLast("落雷");
            LogLinkedList<string>(skills);
            //把岩石加到字串陣列的最前
            skills.AddFirst("岩石");
            LogLinkedList<string>(skills);

            //可以將資料加在另筆資料的前面或後面
            //在火球後面加一個毒霧
            LinkedListNode<string> skillFire = skills.Find("火球");
            skills.AddAfter(skillFire, "毒霧");
            ////在火球前面加一個順移
            skills.AddAfter(skillFire, "順移");
            LogLinkedList<string>(skills);
            #endregion

            #region 泛型自動排序集合
            SortedSet<int> counts = new SortedSet<int> { 9, 2, 80, 1 };
            LogSortedSet<int>(counts);
            //加入的資料也會自動排序進去
            counts.Add(77);
            counts.Add(123);
            LogSortedSet<int>(counts);
            //顯示最大值 關鍵字Max
            LogWithColor.LogWithColors($"最大值{counts.Max}", "#f33");
            //顯示最小值 關鍵字Min
            LogWithColor.LogWithColors($"最大值{counts.Min}", "#f33");

            #region 泛型自動排序的交集和差集
            SortedSet<int> lv = new SortedSet<int> { 7, 3, 75, 123, 5, 80 };
            //交集和差集等會永久改變集合內的數字
            //交集 關鍵字IntersectWith counts表單和lv表單中的相同的數字
            counts.IntersectWith(lv); //結果會是80, 123 這兩個以外的數字皆會刪除
            LogSortedSet<int>(counts);
            //差集 關鍵字ExceptWith 可以理解為counts = counts - lv 剩下的數字
            //如果lv有些數字是counts沒有的 例如7, 3, 75會直接忽略 只看counts既有的數字是否重疊
            counts.ExceptWith(lv); //交集結束後剩下的80和123 會因為差集也有相同數字而都刪除變成空值
            LogSortedSet<int>(counts);

            //差集 counts1 = counts1 - couns2 剩下的數字
            SortedSet<int> counts1 = new SortedSet<int> { 9, 2, 80, 1 };
            SortedSet<int> counts2 = new SortedSet<int> { 9, 2 };
            counts1.ExceptWith(counts2); //結果剩下80和1
            LogSortedSet<int>(counts1);
            #endregion
            #endregion

            #region 泛型字典
            //需輸入鍵(key)和值(value)
            Dictionary<int, string> deck = new Dictionary<int, string>()
            {
                {10, "真紅眼黑龍"}, {3, "落穴"}, {1, "黑魔導"}
            };
            LogDictionary<int, string>(deck);
            //添加一筆資料
            deck.Add(7, "死者甦醒");
            //查詢是否有特定資料 查詢編號 關鍵字ContainsKey
            LogWithColor.LogWithColors($"是否有編號3資料 {deck.ContainsKey(3)}", "#f33");
            //查詢資料 關鍵字ContainsValue
            LogWithColor.LogWithColors($"是否有羽毛掃資料 {deck.ContainsValue("羽毛掃")}", "#f33");
            #endregion

            #region 泛型自動排序清單 (結合自動排序和字典之功能)
            SortedList<string, int> board = new SortedList<string, int>();
            board.Add("Evan", 90); //鍵(string)不能重複 不然會報錯
            board.Add("Andy", 85);
            LogSortedList<string, int>(board);
            #endregion

            #region 泛型自動排序字典 (結合自動排序和字典之功能)
            SortedDictionary<string, int> scores = new SortedDictionary<string, int>();
            scores.Add("Evan", 90); //鍵(string)不能重複 不然會報錯
            scores.Add("Andy", 85);
            LogSortedDictionary<string, int>(scores);
            #endregion

            //自動排序清單和自動排序字典的差異：
            //1. SortedList是使用陣列方式儲存 比較省記憶體
            //2. SortedDictionary是使用樹狀結構儲存 比較占記憶體
            //3. SortedList可以用索引值存取或讀取 即[0]
            LogWithColor.LogWithColors($"排行榜第一筆資料{board.Keys[0]}", "#f93");
            //4. SortedDictionary沒辦法使用索引值存取或讀取
            //5. SortedList大量資料時比較占記憶體 如資料不須頻繁增減建議使用SortedList 反之使用SortedDictionary
        }

        #region 泛型堆疊

        //建立一個使用Stack<T>方法 其參數為(Stack<T> stack)
        private void LogStack<T>(Stack<T> stack)
        {
            //逐次取出在stack內的每筆資料
            foreach (var item in stack)
            {
                LogWithColor.LogWithColors($"堆疊資料 {item}", "#f77");
            }
        }
        #endregion

        #region 泛型佇列
        private void LogQueue<T>(Queue<T> queue)
        {
            {
                foreach (var item in queue)
                {
                    LogWithColor.LogWithColors($"佇列資料 {item}", "#7f7");
                }
            }

        }
        #endregion

        #region 泛型鏈結串列
        //建立一個給泛型鏈結串列使用的方法
        private void LogLinkedList<T>(LinkedList<T> linkedList)
        {
            //逐一執行linkedList內的資料
            foreach (var item in linkedList)
            {
                LogWithColor.LogWithColors(item, "#7f7");
            }
        }
        #endregion

        #region 泛型自動排序集合
        private void LogSortedSet<T>(SortedSet<T> set)
        {
            foreach (var item in set)
            {
                LogWithColor.LogWithColors(item, "#3f3");
            }
        }
        #endregion

        #region 泛型字典
        private void LogDictionary<T, U>(Dictionary<T, U> dict)
        {
            foreach (var item in dict)
            {
                //鍵的關鍵字 Key 值的關鍵字 Value
                LogWithColor.LogWithColors($"卡牌編號 {item.Key}", "#3f3");
                LogWithColor.LogWithColors($"卡牌編號 {item.Value}", "#3f3");
            }
        }
        #endregion

        #region 泛型自動排序清單
        private void LogSortedList<T, U>(SortedList<T, U> list)
        {
            foreach (var item in list)
            {
                LogWithColor.LogWithColors($"{item.Key}的分數{item.Value}", "#3f3");
            }
        }
        #endregion

        #region 泛型自動排序字典
        private void LogSortedDictionary<T, U>(SortedDictionary<T, U> dict)
        {
            foreach (var item in dict)
            {
                LogWithColor.LogWithColors($"{item.Key}的分數{item.Value}", "#3f3");
            }
        }
        #endregion

    }
}
