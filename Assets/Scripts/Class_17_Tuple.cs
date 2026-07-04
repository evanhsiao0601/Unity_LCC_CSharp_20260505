using System;
using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 元組 Tuple
    /// </summary>
    public class Class_17_Tuple : MonoBehaviour
    {
        private void Awake()
        {
            //元組：可同時儲存多筆不同類型的資料
            //宣告方式1：指定類型與名稱
            (string name, int cost, int index) card1 = ("史萊姆", 1, 7);
            LogWithColor.LogWithColors($"{card1.name} 消耗{card1.cost} 編號{card1.index}", "#f49");

            //宣告方式2：指定類型
            //取得元組資料時使用Item1 ~ ItemN
            (string, int, int) card2 = ("史萊姆", 2, 23);
            LogWithColor.LogWithColors($"{card2.Item1} 消耗{card2.Item2} 編號{card2.Item3}", "#f49");

            //宣告方式3：使用var 不指定類型
            //取得元組資料時使用Item1 ~ ItemN
            var card3 = ("樹精", 4, 50);
            LogWithColor.LogWithColors($"{card3.Item1} 消耗{card3.Item2} 編號{card3.Item3}", "#f49");

            //宣告方式4：使用var 以及指名
            var card4 = (name: "史萊姆", cost: 1, index: 7);
            LogWithColor.LogWithColors($"{card4.name} 消耗{card4.cost} 編號{card4.index}", "#f49");

            //可將宣告完成的元組放入方法
            UseCard(card1);
            UseCard(card2);
            //可直接帶入參數
            UseCard(("暴龍", 7, 199));

            //宣告一個回傳值可存放的變數cardUpdate 暫時產生一張修改版 存放於此不影響原始的卡牌資料
            //戰鬥結束後重新從原始資料建立
            var cardUpdate = UpdateCardCost(card1);
            LogWithColor.LogWithColors($"{cardUpdate.name} 消耗{cardUpdate.cost} 編號{cardUpdate.index}", "#f49");
            //只有加上 card = UpdateCardCost(card); 才會覆寫原本卡牌的資料

            //也可以用布林值判斷是否相同
            LogWithColor.LogWithColors($"{cardUpdate == card1}", "#79f");
            //也可以用布林值判斷是否不相同
            LogWithColor.LogWithColors($"{cardUpdate != card1}", "#79f");
        }

        //元組方法的參數 參數的型別及名稱(string name, int cost, int index)  card是前面整個參數的名稱
        //元組一定要寫參數名稱
        //這種寫法常用於卡牌 角色資料 道具資料等需要一次傳遞多個相關欄位的情境 比只傳一個值更方便
        private void UseCard((string name, int cost, int index) card)
        {
            LogWithColor.LogWithColors($"使用卡牌{card.name} 消耗{card.cost}", "#f49");
        }

        //更新卡牌狀態的方法
        private (string name, int cost, int index) UpdateCardCost((string name, int cost, int index) card)
        {
            card.name = card.name + "降低消耗版本";
            card.cost -= 1;
            return card;
        }
    }

}
