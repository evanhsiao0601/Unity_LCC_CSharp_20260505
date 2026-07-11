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

        private void Awake()
        {
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
                //檢視哪幾個組別 結果會分別是0和1
                LogWithColor.LogWithColors(group.Key, "#3f3");

                //逐一執行每個群組內的單筆資料
                foreach (var item in group)
                {
                    LogWithColor.LogWithColors(item, "#3f3");
                }
            }

        }
    }
}
