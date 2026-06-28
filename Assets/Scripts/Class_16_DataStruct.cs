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

        }

        #region 泛型堆疊
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
    }
}
