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
            //再把(目標的資料類型)放在要轉換的類型前面
            byte2 = (byte)int2;
            LogWithColor.LogWithColors(byte2, "#7f7");
            LogWithColor.LogWithColors(byte2.GetType(), "#7f7");
            #endregion

            //浮點數轉為整數型別 小數點會遺失
            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogWithColor.LogWithColors(byte3, "#7f7");

            //大轉為小會導致溢位 無法顯示
            int int3 = 256;
            byte byte4 = 0;

            byte4 = (byte)int3;
            LogWithColor.LogWithColors(byte4, "#7f7");


        }

    }
}
