using UnityEngine;
/// <summary>
/// 課程三：運算子
/// 補充Unity欄位屬性、事件
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    //變數的三大類型 欄位(Field) 區域變數(Local Variable) 參數(Parameter) 
    //這三大類型底下各可定義不同的資料類型 例如int string等

    #region 欄位屬性
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

    //多個欄位屬性的應用
    [Header("血量")]
    [Range(1, 999)]
    public int HP = 100;
    [Header("攻擊力")]
    [Range(1, 999)]
    public float ATK = 30.5f;
    //[在屬性面板隱藏] 將公開的變數隱藏
    [HideInInspector]
    public string passward = "passward";
    //[序列化欄位] 將私人的變數公開
    [SerializeField]
    private float MP = 50.5f;
    #endregion

    //使用Unity事件
    //1.必須在腳本後面添加MonoBehaviour(繼承)
    //2.使用關鍵字快速選取事件 例如輸入Awake挑選後按Enter完成

    //喚醒事件(Awake) 播放遊戲第一個執行的事件 一般為藍色有時有bug非藍色也不影響
    private void Awake()
    {
        #region Debug輸出訊息 
        //將小括號內的訊息輸出到Unity的Consolo控制台面板
        //Ctrl+Shift+C 開啟控制台面板
        Debug.Log("Hello World!"); //輸出文字
        Debug.Log(HP); //輸出變數
        Debug.Log($"攻擊力:{ATK}"); //$號格式(Rich Text)的字串加變數
        Debug.Log("攻擊力:"+ATK); //沒有$號的字串加變數

        Debug.Log("<b>粗體</b>"); //設成粗體字
        Debug.Log("<color=orange>橘色</color>"); //字改橘色
        Debug.Log("<color=#66aaff>藍色</color>");
        //字改藍色 66aaff也可以簡寫成#6af 66aaff的意思為紅紅綠綠藍藍 0~9 a~f 越右邊越白越亮
        #endregion

        //運算子：
        #region 運算子 區域變數
        //1. 算術運算子：
        //加(+) 減(-) 乘(*) 除(/) 餘(%)
        Debug.Log("<color=#f93>---算術運算子--- </color>");
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3); //餘數為先進行除法後再相減剩下的數字

        //區域變數(Local Variable)：僅在此事件的包括內存取 所以不需要修飾詞
        Debug.Log("<color=#f93>---算術運算子：區域變數---</color>");
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);
        #endregion

        //2. 比較運算子：
        //大於(>) 小於(<->) 大於等於(>=) 小於等於(<=> 等於(==) 不等於(!=)
        Debug.Log("<color=#f93>---比較運算子---</color>");
        int numberC = 100, numberD = 1;
        
        //結果會得到布林值 true或false
        Debug.Log(numberC > numberD);
        Debug.Log(numberC < numberD);
        Debug.Log(numberC >= numberD);
        Debug.Log(numberC <= numberD);
        Debug.Log(numberC == numberD);
        Debug.Log(numberC != numberD);
    }

}