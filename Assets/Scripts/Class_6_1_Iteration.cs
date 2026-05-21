using UnityEngine;

namespace Evan { }
/// <summary>
/// 反覆運算陳述式(迴圈 Iteration)
/// for foreach do while
/// </summary>
public class Class_6_1_Iteration : MonoBehaviour
{
    private void Awake()
    {

        #region 迴圈 while do for
        //迴圈需要在一次性事件使用 Awake Start
        //1. while迴圈：當布林值為true時會持續執行
        //語法：(布林值) {程式碼區塊}
        //無限迴圈：布林值一直是true

        //定義區域變數a是0
        //int a = 0;
        int a = 5;
        //當a < 5就執行{}內的程式碼 當a等於5就不會執行
        while (a < 5)
        {
            Debug.Log($"<color=#f33>while迴圈a={a}</color>");
            //a值遞增 a+1 ++為遞增符號
            //陳述式放在Debug.Log上面時 會從1開始顯示 放在Debug.Log下面時會從0開始
            a++;
        }

        //2. do迴圈：
        //語法：do{程式碼區塊} while(布林值)
        //do跟while的差異在 do在前面的話 一定會先執行一遍 即使b等於5 也會執行一次
        //如果只有while在前面 會先判斷是不是等於5 如果是就不會執行

        //定義區域變數b是0
        //int b = 0; 
        int b = 5; //一定會先執行一次 所以Log會顯示5
        do
        {
            Debug.Log($"<color=#f79>do迴圈b={b}</color>");
            b++;
        }
        while (b < 5);

        //3. for迴圈：
        //作用是把while的寫法濃縮進一個陳述式裡面 並有遞增的功能
        //語法：for (預設值; 布林值; 迭代器) {程式碼區塊}
        for (int c = 0; c < 5; c++)
        {
            Debug.Log($"<color=#f79>for迴圈c={c}</color>");
        }
        #endregion

        #region 迴圈 foreach
        //3. foreach 迴圈
        //語法：foreach (資料類型 資料名稱 in 資料結構) {程式碼區塊}
        //資料結構：陣列 清單 字串等
        //字串用來存放char陣列
        string dialogue = "嗨 你好";
        //foreach迴圈會抓出dialogue的每一個字並存放在區域變數的text內 每個字元個別顯示出來
        //var 無類型
        foreach (var text in dialogue)
        {
            Debug.Log($"<color=#f63>{text}</color>");
        }

        #endregion
    }

}
