
//單行註解

/*多行註解
 * 2
 * 3*/

//引用Unity函式庫
using UnityEngine;

//修飾詞 宣告要建立一個類別(腳本) 類別名稱(腳本名稱) 最後須加上MonoBehaviour
//MonoBehaviour能讓Unity的物件掛載腳本 沒有的話無法掛載
public class Class_1_Variable : MonoBehaviour 
{
    //修飾詞語法：
    //1. public(公開) 可讓其他類別存取 會顯示在屬性面板上
    //2. private(私人) 無法讓其他類別存取 不會顯示在屬性面板上 一開始預設皆為private

    //變數語法：
    //定義變數語法的規則：告訴記憶體該變數的[資料類型] 自己定義的[變數名稱] 最後加上;符號表示結束
    //在[資料類型]和[變數名稱]後 可指定或不指定[預設值]
    //例如public(修飾詞) int(資料類型) coin(變數名稱) =(指定) 500(預設值);

    //1. int(整數 可放沒有小數點的數值) coin(定義的變數名稱是金幣)
    public int coin = 500;
   private int level = 3;

}
