using System;
using UnityEngine;
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

    }
