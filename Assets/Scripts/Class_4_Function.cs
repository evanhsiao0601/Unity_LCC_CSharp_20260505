using UnityEngine;
/// <summary>
/// 方法
/// 中文：方法、函式、函數、功能
/// 英文：function、method(unity使用)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    private void Awake()
    {
        #region 方法基本語法和參數的呼叫
        //需要呼叫下面完成的方法才會執行
        //方法名稱();
        FirstFunction();
        FirstFunction();
        FirstFunction();
        //輸入幾次方法就會執行幾次方法

        //呼叫有參數的方法：小括號內要放入引數 會引導到skillName 不然會錯誤
        //因下面skillName沒有預設文字 所以需要在呼叫的時候填入
        UseSkill("火球術");

        //呼叫技能和技能消耗顯示 須填入技能名稱和消耗數值
        UseSkill2("冰錐術", 50);

        //呼叫有預設值的參數方法：選填式參數 可以不用在呼叫時填入 因為有預設 也可以填入取代原本的
        SpawnEnemy();
        SpawnEnemy("史萊姆");

        //呼叫複數參數 一個有預設值 一個無預設值的方法：speed要填 weapon選填
        Fire(800);
        Fire(700, "保齡球"); //weapon可填入

        //多個參數有預設值的方法：
        BuyItem();
        BuyItem(count: 30); //如果兩個都有預設值的狀況 直接指定參數就好 就不會產生錯誤
        BuyItem("藍水", 30); //不使用預設值 兩個都填入新的
        #endregion

        #region 呼叫有傳回的方法
        //第一種：把結果放到區域變數內
        //先定義類型變數 取得結果後 再放入程式碼
        int number9 = Square(9);
        Debug.Log($"<color=#a33>9的平方是{number9}</color>");
        //第二種：把傳回方法當作傳回類型使用 
        //例如 int為類型 但在下面語法中不需要再定義類型變數 而是直接把方法放進程式碼 就會取得結果
        Debug.Log($"<color=#a33>7的平方是{Square(7)}</color>");

        //練習BMI算法有傳回的呼叫
        float result = BMI();
        Debug.Log($"<color=#a33>您的BMI是{result}</color>");
        float result2 = BMI(1.65f, 64f);
        Debug.Log($"<color=#a33>您的BMI是{result2}</color>");

        #endregion

        #region 方法多載的方法
        Move();
        Move(50.5f);
        #endregion
    }

    //範圍選取群組程式碼：Ctrl+K+S 選擇#region
    #region 方法基本語法和參數
    #region 方法
    //方法：包含一系列的程式區塊
    //方法(function)語法：修飾詞 傳回資料類型(同資料類型) 定義方法名稱(參數1, 參數2, 無限制數) {程式區塊}
    private void FirstFunction()
    //無傳回(void)：使用此方法不會傳回資料
    //方法命名習慣：Unity習慣使用大寫開頭命名
    {
        Debug.Log("第一個方法");
    }
    #endregion

    #region 參數
    //參數(Parameter)語法：資料類型　定義方法名稱(定義參數名稱) 參數名稱習慣用小寫或著加底線開頭
    private void UseSkill(string skillName)
    //void[資料類型] UseSkill[方法名稱] 括號內為參數的資訊 定義字串變數名稱 但因該字串變數沒有預設值 所以需要在呼叫的時候填入
    {
        Debug.Log($"<color=#f93>施放技能：{skillName}</color>");
    }
    #endregion

    #region 複數參數
    //先定義技能字串skillName2 後面增加定義float變數名稱 兩者都沒有預設值 因此須在呼叫時填入
    private void UseSkill2(string skillName2, float cost)
    {
        Debug.Log($"<color=#f93>施放技能：{skillName2}</color>");
        Debug.Log($"<color=#f93>技能消耗：{cost}</color>");
    }
    #endregion

    #region 參數有預設值的狀況
    //在定義的字串名稱後加上預設值哥布林
    private void SpawnEnemy(string enemyName = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人：{enemyName}</color>");
    }
    #endregion

    #region 複數參數 一個有預設值 一個無預設值的狀況
    //沒有預設值稱為必要參數 有預設值稱為選填式參數
    //必要參數必須放在選填式參數的前面 所以speed會放在weapon前面
    private void Fire(int speed, string weapon = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件：{weapon}，速度：{speed}</color>");
    }
    #endregion

    #region 多個參數有預設值的狀況
    //可使用summary標註變數的用意
    /// <summary>
    /// 使用道具
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品：{item}，數量：{count}</color>");
    }
    #endregion
    #endregion

    #region 有傳回的方法的基本語法
    //傳回方法：傳回類型如果不是void 呼叫方法時會取得結果
    //傳回方法必須在{}內使用retrun才會傳回

    /// <summary>
    /// 平方
    /// </summary>
    /// <param name="number">要平方的數字</param>
    /// <returns>數字平方的結果</returns>
    private int Square(int number)
    {
        return number * number;
    }

    //練習BMI的方法
    //也可以加個方法 去計算身高的平方 再代入下面BMI的return
    //private float Square(float number)
    //{return number * number;}
   
    /// <summary>
    /// BMI計算
    /// </summary>
    /// <param name="height">身高</param>
    /// <param name="weight">體重</param>
    /// <returns>BMI結果</returns>
    private float BMI(float height = 1.68f, float weight = 60f) 
    {
        return weight / (height * height);
    }
    #endregion

    #region 方法多載
    // fumction overload 參數的類型或數量不同 就可以加載負數相同名稱的方法
    private void Move() 
    {
        Debug.Log($"<color=#19f>移動中</color>");
    }
    private void Move(float speed) 
    {
        Debug.Log($"<color=#19F>移動中，速度：{speed}</color>");
    }
    #endregion
}

