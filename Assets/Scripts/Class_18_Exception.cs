using System;
using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 例外處理 Exception
    /// </summary>
    public class Class_18_Exception : MonoBehaviour
    {
        private void Awake()
        {
            //可在Log內使用運算方法
            LogWithColor.LogWithColors($"{Division(8, 4)}", "#f33");
            LogWithColor.LogWithColors($"{Division(3, 9)}", "#f33");
            LogWithColor.LogWithColors($"{Division(7, 0)}", "#f33");

            //喚出Getscores方法 顯示陣列中第九個數字
            LogWithColor.LogWithColors($"{Getscores(9)}", "#f33");

            SetEnemy();
        }

        //只要方法有return某個值 前面就必須寫對應的型別 所以要寫要指定int為回傳的型別
        //int? 允許傳回空值 因為運算沒有結果
        private int? Division(int numberA, int numberB)
        {
            //可能發生例外的區域
            try
            {
                return numberA / numberB; //發生例外
            }
            //捕捉到例外 除以零 DivideByZeroException 時會執行此區域
            catch (DivideByZeroException e)
            {
                //Message 例外官方訊息
                LogWithColor.LogWithColors($"分子不能為零 {e.Message}", "#f99");
                return null;
            }
            //最後區域
            finally
            {
                LogWithColor.LogWithColors("例外處理完畢", "#f73");
            }
        }

        //宣告一個陣列
        private int[] scores = { 70, 91, 64, 53, 88 };

        //回傳陣列中數值的方法
        private int? Getscores(int index)
        {
            try
            {
                return scores[index];
            }
            //如果產生 除以零 發生例外則回傳空值
            catch (DivideByZeroException)
            {
                LogWithColor.LogWithColors("發生例外", "#f73");
                return null;
            }
            //繼續檢查 如果檢查出 因超出範圍的值 而發生的例外則回傳空值
            catch (IndexOutOfRangeException e)
            {
                LogWithColor.LogWithColors($"發生例外{e.Message}", "#f73");
                return null;
            }
        }

        [SerializeField]
        private GameObject enemy;
        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true); //顯示敵人物件
            }
            catch (Exception e) //Exception可以處理所有例外     
            {
                LogWithColor.LogWithColors($"發生例外{e.Message}", "#f73");
            }
        }
    }

}
