using UnityEngine;
//三斜線為摘要 可用以簡短說明此腳本目的或進行程度
/// <summary>
/// 認識不同的資料類型
/// </summary>

//修飾詞 宣告要建立一個類別(腳本) 類別名稱(腳本名稱) 最後須加上MonoBehaviour
//MonoBehaviour能讓Unity的物件掛載腳本 沒有的話無法掛載
public class Class_2_DataType : MonoBehaviour
{
    //修飾詞語法：
    //1. public(公開) 可讓其他類別存取 會顯示在屬性面板上
    //2. private(私人) 無法讓其他類別存取 不會顯示在屬性面板上 一開始預設皆為private

    //變數語法：
    //定義變數語法的規則：告訴記憶體該變數的[資料類型] 自己定義的[變數名稱] 最後加上;符號表示結束
    //在[資料類型]和[變數名稱]後 可指定或不指定[預設值]
    //例如public(修飾詞) int(資料類型) coin(變數名稱) =(指定) 500(預設值);

    //常用資料類型有四種：
    //整數：儲存沒有小數點的數值 int 
    public int count = 10;
    //浮點數：儲存有小數點的數值 float
    public float moveSpeed = 3.5f; //數值最後須加上大或小寫的f才能成立
    //字串：儲存文字 須用雙引號把文字包在其中 string
    public string mainCharacter = "蓋倫"; 
    //布林值：儲存正與反 bool 他只有兩種值 true和false
    public bool isDead = false; //是否死亡=否
    public bool gameOver = true; //是否結束=是

    //整數資料類型：
    //byte：只有正數 0~255 大小8byte
    public byte level = 16;
    //uint：只有正數 比byte更大的數值 詳細參考微軟C#內建類型網頁 大小32byte
    public uint coin = 9999;
    //long：只有正數 比uint更大的數值 詳細參考微軟C#內建類型網頁 大小64byte
    public long item = 3000;

    //字串與字元類型：
    //string：儲存多個字元 用雙引號
    public string playername = "Evan";
    //char：儲存一個字元 用單引號
    public char a = 'a';

    //溢位：當指定的預設數值超過數字資料類型的限制時會產生錯誤
}
