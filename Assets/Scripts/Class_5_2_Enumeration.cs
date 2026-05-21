using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 列舉(Enumeration) C#關鍵字縮寫為 enum
    /// </summary>
    public class Class_5_2_Enumeration : MonoBehaviour
    {
        #region 列舉基本用法
        //列舉通常是定義下拉式選單的選項(一般為單選)
        //語法：修飾詞　關鍵字　enum 列舉名稱 {列舉選項}
        //列舉都是數值 預設從0開始
        //定義一個列舉叫季節
        private enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        [SerializeField, Header("季節")]
        //宣告變數
        private Season season = Season.Summer;
        //修飾詞  類型  變數名稱   預設為夏天

        private void Awake()
        {
            //取得列舉值(get)抓出值
            Debug.Log(season); //顯示在Log裡
            //取的列舉的整數值(它的編號)
            Debug.Log((int)season); //顯示在Log裡

            //設定列舉的值(set)修改值 把預設的Summer改為Winter
            season = Season.Winter;
            Debug.Log(season); //顯示在Log裡
            //透過數值編號列舉 讓預設值顯示為該編號列舉
            season = (Season)2;
            Debug.Log(season); //顯示在Log裡
        }
        #endregion

        #region 指定各列舉的數值
        private enum Item
        {
            None = 0, Coin = 1, Red = 10, Blue= 15, Chicken = 20
        }

        [SerializeField, Header("道具")]
        //宣告列舉類型為Item 變數名稱是item 預設道具為Chicken
        private Item item = Item.Chicken;

        //執行順序：Awake > Start > Update
        //開始事件：在喚醒事件後執行一次(初始化 如同Awake)
        private void Start()
        {
            //未指定編號 顯示的就是預設的道具
            Debug.Log((int)item);

        #endregion

            #region switch加列舉的用法 (可以在下拉式選單中選取 並把訊息顯示在Log上 但要重新執行撥放)
            //switch + Tab兩次 >把switch on修改成列舉名稱> Enter兩次快速完成

            //用switch抓出先前定義的變數item
            switch (item)
            {
                case Item.None:
                    Debug.Log("沒有道具");
                    break;
                case Item.Coin:
                    Debug.Log("金幣");
                    break;
                case Item.Red:
                case Item.Blue:
                    Debug.Log("藥水道具");
                    break;
                case Item.Chicken:
                    Debug.Log("食物道具");
                    break;
                default:
                    Debug.Log("這不是道具");
                    break;
            }

	}

        #endregion
}
}