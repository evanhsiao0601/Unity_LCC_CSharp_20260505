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
            #region 例外處理
            //可在Log內使用運算方法
            LogWithColor.LogWithColors($"{Division(8, 4)}", "#f33");
            LogWithColor.LogWithColors($"{Division(3, 9)}", "#f33");
            LogWithColor.LogWithColors($"{Division(7, 0)}", "#f33");

            //喚出Getscores方法 顯示陣列中第九個數字
            LogWithColor.LogWithColors($"{Getscores(9)}", "#f33");

            SetEnemy();
            #endregion

            #region 自訂例外 傷害
            try
            {
                Damage(35);
                Damage(70);
            }
            //當執行時抓出錯誤後 不執行錯誤指令 因扣血70已低於0
            catch (Exception e)
            {
                LogWithColor.LogWithColors(e, "#93f");
            }
            #endregion

            #region 自訂例外 補血
            try
            {
                Cure(30); //加血
                Cure(-10); //扣血
            }
            catch (CureValueLowerZeroException e) //自訂例外
            //由於 CureValueLowerZeroException 繼承了 Exception父類別 而下方Message已經放在父類別了
            //所以e.Message可以抓到"治療值低於零"的訊息
            {
                LogWithColor.LogWithColors(e.Message, "#73f");
            } 
            #endregion
        }

        #region 例外處理
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
        #endregion

        #region 自訂例外 傷害
        private float hp = 100;
        private void Damage(float damage)
        {
            hp -= damage;

            if (hp < 0)
            {
                //自訂例外
                throw new Exception("血量小於零");
            }
            else
            {
                LogWithColor.LogWithColors($"血量 {hp}", "#93f");
            }
        }
        #endregion

        #region 自訂例外 補血
        private void Cure(float cure)
        {
            if (cure < 0)
            {
                //throw 丟出的物件必須是 Exception 類別或它的子類別
                //之所以不直接 throw new Exception() 是因為細分出來可以攔截特定的例外
                throw new CureValueLowerZeroException("治療值低於零");
            }
            else
            {
                hp += cure;
            }
        } 
    }

    //治療低於零的例外
    //所有自訂例外都要繼承 Exception 因為 CureValueLowerZeroException 本身就是一種例外
    public class CureValueLowerZeroException : Exception
    {
        //C#規定繼承了 Exception 才能輸入message
        //(string message)表示括號的文字內容會交到base(message)的括號內
        public CureValueLowerZeroException(string message) : base(message) { }
    }
    #endregion

}
