using System;
using UnityEngine;
namespace Evan
{
    public class Class_9_2_DataSwitch : MonoBehaviour
    {
        private void Awake()
        {
            #region 隱式轉換
            //隱式轉換：不需要另外宣告轉換類型
            //將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            //將比較小的byte放到大的int內
            //寫法是相反的 目標類型寫在前面 要轉換的類型寫在後面
            int1 = byte1;
            LogWithColor.LogWithColors(int1, "#7f7");
            LogWithColor.LogWithColors(int1.GetType(), "#7f7"); //GetType顯示int1的資料類型 
            #endregion

            #region 顯式轉換
            //顯式轉換：需要另外宣告轉換類型
            //將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            //將比較大的int放到小的byte內
            //需要把(目標的資料類型)放在要轉換的類型前面
            byte2 = (byte)int2;
            LogWithColor.LogWithColors(byte2, "#7f7");
            LogWithColor.LogWithColors(byte2.GetType(), "#7f7");
            #endregion

            #region 浮點數轉為整數型別 小數點會遺失
            //浮點數轉為整數型別 小數點會遺失
            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogWithColor.LogWithColors(byte3, "#7f7");
            #endregion

            #region 有時大轉為小會導致溢位 無法顯示
            //有時大轉為小會導致溢位 無法顯示
            int int3 = 256;
            byte byte4 = 0;

            byte4 = (byte)int3;
            LogWithColor.LogWithColors(byte4, "#7f7"); 
            #endregion


        }
        private void Start()
        {
            #region 將整數轉為字串
            //將整數轉為字串 
            int count = 99; //定義整數的變數
            //var 不指定 儲存所有類型 intToString新變數名稱 = Convert.ToString轉成字串
            var intToString = Convert.ToString(count);
            LogWithColor.LogWithColors(intToString.GetType(), "#f96");
            #endregion

            #region 將布林值轉為字串
            //將布林值轉為字串
            bool isOver = false; //定義布林值變數
            var boolToString = Convert.ToString(isOver);
            LogWithColor.LogWithColors(boolToString.GetType(), "#f96");
            #endregion

            #region float轉成byte
            //float轉成byte
            float move = 3.5f;
            var floatToByte = Convert.ToByte(move);
            LogWithColor.LogWithColors(floatToByte.GetType(), "#f96");
            #endregion

            #region 將布林值轉為byte
            //將布林值轉為byte
            bool a = true;
            var boolToByte = Convert.ToByte(a);
            //布林值轉換的數字為 true = 1, false = 0
            LogWithColor.LogWithColors(boolToByte, "#f96");
            LogWithColor.LogWithColors(boolToByte.GetType(), "#f96"); 
            #endregion


        }

    }
}
