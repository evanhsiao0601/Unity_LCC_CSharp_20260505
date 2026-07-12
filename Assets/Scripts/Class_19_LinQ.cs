//要先加入LinQ的系統才能使用
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
namespace Evan
{
    /// <summary>
    /// 整合查詢語言 LinQ
    /// 用來查詢資料庫的語言(如同橋梁) 所有程式語言的共用技術
    /// </summary>
    public class Class_19_LinQ : MonoBehaviour
    {
        //宣告測試用的陣列
        public int[] scores = { 90, 80, 77, 88, 93, 1, 5, 10, 45 };
        public string[] items = { "紅色藥水", "藍色藥水", "地圖", "回家卷軸", "匕首", "紅色炸彈" };
        public int[] numbers = { 1, 23, 77, 34, 42, 56, 80 };

        private void Awake()
        {
            #region LinQ基本用法
            //使用LinQ的關鍵字查詢資料
            //起手式：
            //from資料來源單筆資料 in整個陣列資料 select選取結果 score是自己取的變數名稱
            //從scores集合中 一個一個取出資料 選取scores內的每一筆分數
            var queryAllData = from score in scores select score;

            //逐一檢視每筆資料
            foreach (var item in queryAllData)
            {
                LogWithColor.LogWithColors(item, "#3f3");
            }

            //情境：希望找到大於60分的玩家分數並排序
            //where 篩選的條件 orderby 排序(預設從小到大) descending 由大到小
            var querysixty = from score in scores
                             where score >= 60
                             orderby score descending
                             select score;

            foreach (var item in querysixty)
            {
                LogWithColor.LogWithColors(item, "#3f3");
            }

            //情境：篩選出分數為偶數的資料與奇數
            //group by   %是取餘數 %2就是如90%2 結果是0或1會分在不同組
            var queryGroup = from score in scores
                             group score by score % 2;

            //取得每個組別的資料 而非單筆資料
            foreach (var group in queryGroup)
            {
                //檢視哪幾個組別 結果會分別是0和1 Key 獲得分組名稱
                LogWithColor.LogWithColors(group.Key, "#3f3");

                //逐一執行每個群組內的單筆資料
                foreach (var item in group)
                {
                    LogWithColor.LogWithColors(item, "#3f3");
                }
            }
            #endregion

            #region LinQ延伸用法
            //取得每個詞的第一個字 並指定要找出哪個第一個字
            var queryRed = from item in items
                           //let 宣告一個中間變數 可以取得特定資料且儲存於變數內
                           //先取得每個詞的第一個字
                           let firstWord = item[0]
                           //指定第一個字是紅
                           where firstWord == '紅'
                           select item;

            foreach (var item in queryRed)
            {
                LogWithColor.LogWithColors($"第一個字是紅的道具{item}", "#3f3");
            }

            //用每個詞的第一個字去做分組
            var queryRedGroup = from item in items
                                //into 將資料分組
                                //根據每個詞的第一個字去做分組 例如紅一組包含紅色藥水 紅色炸彈
                                group item by item[0] into newGroup
                                select newGroup;

            foreach (var group in queryRedGroup)
            {
                //在獲得資料時可透過 Key 獲得分組名稱
                LogWithColor.LogWithColors($"群組{group.Key}", "#3f3");
                foreach (var item in group)
                {
                    //取得每筆道具名稱
                    LogWithColor.LogWithColors($"道具{item}", "#3f3");
                }
            }

            //比較兩組陣列數字
            //將每筆score資料加入每筆 number資料
            var queryEquals = from score in scores
                              join number in numbers
                              // 比較equals 兩組陣列數字
                              on score equals number
                              select number;

            foreach (var item in queryEquals)
            {
                //找出兩組陣列中相同數字
                LogWithColor.LogWithColors($"兩組相同數字{item}", "#3f3");
            }
            //用內建的方法去計算兩組陣列的數字
            LogWithColor.LogWithColors($"最大值{queryEquals.Max()}", "#3f3");
            LogWithColor.LogWithColors($"最小值{queryEquals.Min()}", "#3f3");
            LogWithColor.LogWithColors($"平均值{queryEquals.Average()}", "#3f3");
            LogWithColor.LogWithColors($"總和{queryEquals.Sum()}", "#3f3");

            #endregion

        }
    }
}
