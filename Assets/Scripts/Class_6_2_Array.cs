using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 陣列(Array)
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {
        //2*3*2 第幾頁數 第幾排 第幾個 第一個頁/排/個都是從0開始算 例如0123是四排

        //當碰到需要輸入大量且同類型的資料
        //不使用陣列的寫法：
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

        //使用陣列的寫法：
        //一維：由上而下一排 二維：由上而下二排 三維：除了多排外增加第二頁
        //陣列：用來儲存多筆相同類型的資料
        //第一種：不指定值 透過Unity面板輸入
        public string[] cards;
        //第二種：直接定義陣列數量
        public string[] deck1 = new string[5];
        //第三種：直接定義陣列的值
        public string[] deck2 = { "急凍鳥", "火焰鳥", "閃電鳥" };

        //二維陣列的寫法：             第一排第一個   第二個  第二排第一個  第二個
        public string[,] inventory = { { "紅藥水", "藍藥水" },{ "炸彈", "金幣" } };

        //三維陣列的寫法：
        public string[,,] shop =
        {
            //第一頁
            { { "小刀", "美工刀" },{ "武士刀", "屠龍刀" }  },
            //第二頁
            { { "精靈球", "高級球" },{ "大師球", "巢穴球" }  }
        };


        private void Start()
        {
            #region 一維陣列
            //存取陣列(Set Get)
            //Get 取得陣列資料
            //語法：陣列名稱[編號]
            Debug.Log($"<color=#f32>牌組的第三張卡牌是{cards[2]}</color>");
            //超出陣列會導致遊戲錯誤和閃退

            //Set 設定陣列資料
            //語法：陣列名稱[編號] 指定值
            //將閃電鳥換成傑尼龜
            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f32>牌組的第三張卡牌是{deck2[2]}</color>");
            #endregion

            #region 二維陣列
            //存取二維陣列
            Debug.Log($"<color=#3f3>編號[0, 1]的道具是{inventory[0, 1]}</color>");
            //替換[1, 1]的道具
            inventory[1, 1] = "復活藥";
            Debug.Log($"<color=#3f3>編號[1, 1]的道具是{inventory[1, 1]}</color>");
            #endregion

            #region 三維陣列
            //存取三維陣列
            //取得屠龍刀
            Debug.Log($"<color=#3f3>第一頁第二排第二個的道具是{shop[0, 1, 1]}</color>");

            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#3f3>第二頁第一排第二個的道具是{shop[1, 0, 1]}</color>");
            #endregion

            //獲得陣列的長度和維度
            //一維到多維陣列長度(有幾個值)的寫法：陣列名稱.Length
            Debug.Log($"<color=#3f3>牌組二的長度是{deck2.Length}</color>");
            //一維到多維陣列維度的寫法：陣列名稱.Rank
            Debug.Log($"<color=#3f3>牌組二的維度是{deck2.Rank}</color>");
        }

    }

}