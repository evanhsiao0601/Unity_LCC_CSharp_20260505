using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 陣列(Array)
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {

        #region 一到三維陣列
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
        public string[,] inventory = { { "紅藥水", "藍藥水" }, { "炸彈", "金幣" } };

        //三維陣列的寫法：
        public string[,,] shop =
        {
            //第一頁
            { { "小刀", "美工刀" },{ "武士刀", "屠龍刀" }  },
            //第二頁
            { { "精靈球", "高級球" },{ "大師球", "巢穴球" }  }
        };
        #endregion

        #region //不規則和不規則多維陣列
        //不規則陣列用[][] new int [2]代表兩排 []個數為空 代表之後可以不規則定義
        private int[][] numbers = new int[2][];
        //不規則多維陣列用[][,] [2]是頁數
        private int[][,] numbersb = new int[2][,]; 
        #endregion

        private void Start()
        {

            //cards [0, 0, 0]內的數字代表[頁, 排, 第幾個] 從0開始起算第一頁/排/個
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

            #region 陣列長度與維度
            //獲得陣列的長度和維度
            //一維到多維陣列長度(有幾個值)的寫法：陣列名稱.Length
            Debug.Log($"<color=#3f3>牌組二的長度是{deck2.Length}</color>");
            //一維到多維陣列維度的寫法：陣列名稱.Rank
            Debug.Log($"<color=#3f3>牌組二的維度是{deck2.Rank}</color>");
            #endregion

            #region //不規則和不規則多維陣列
            //1. 不規則陣列
            //numbers[第幾排] new int[]定義個數和其代表的數值 { 1, 3, 5 }三個個數 數值為135
            numbers[0] = new int[] { 1, 3, 5 };
            numbers[1] = new int[] { 9, 8 };

            //numbers[0][1] 第一排第二個
            Debug.Log($"<color=#3ff>不規則陣列數字3：{numbers[0][1]}</color>");
            //numbers[1][0] 第二排第一個
            Debug.Log($"<color=#3ff>不規則陣列數字9：{numbers[1][0]}</color>");

            //把第二排第二個從8改成6
            numbers[1][1] = 6;
            Debug.Log($"<color=#3ff>不規則陣列數字9：{numbers[1][0]}</color>");

            //2. 不規則多維陣列
            numbersb[0] = new int[,] { { 1, 1 }, { 1, 1 } };
            numbersb[1] = new int[,] { { 2, 2, 2 }, { 2, 2, 2 } };
            Debug.Log($"<color=#3ff>不規則多維陣列第二頁的[0, 0]：{numbersb[1][0, 0]}</color>"); 
            #endregion

        }

    }

}