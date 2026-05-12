using UnityEngine;
/// <summary>
/// 課程三：運算子
/// 補充Unity欄位屬性、事件
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    //變數的三大類型 區域變數(Local Variable) 參數(Parameter) 欄位(Field)
    //這三大類型底下各可定義不同的資料類型 例如int string等

    //欄位(Field)的意思：
    //例如 public int hp = 100;
    //其中int是變數的類型 hp則是定義的變數名稱 只要hp這個變數是在[class底下定義的] 它屬於欄位

    //欄位屬性 Field attribute
    //[標題(標題文字)] 在屬性面板上直接顯示標題文字
    [Header("等級")]
    public int LV = 1;
    //[提示(提示文字)] 在屬性面板的欄位停留時顯示提示文字
    [Tooltip("這是角色的移動速度，無法超過100。")]
    public float moveSpeed = 7.5f;
    //[範圍(最小值, 最大值)] 在屬性面板上增加範圍數值的滑桿
    [Range(1, 100)]
    public byte count = 10; //起始預設值是10 但滑桿可拉到100 滑桿無法用在文字上
    //[文字數量(最小行, 最大行)] 設定顯示在面板上的字串最少到最多可以有幾行文字
    [TextArea(2, 5)]
    public string itemDescription = "這是道具描述 這是道具描述 這是道具描述";
}