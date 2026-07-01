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
        }

        private void UseCard((string name, int cost, int index) card)
        {
            LogWithColor.LogWithColors($"使用卡牌{card.name} 消耗{card.cost}", "#f49");
        }
    }

}
