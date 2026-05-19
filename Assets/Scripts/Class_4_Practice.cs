using UnityEngine;

public class Class_4_Practice : MonoBehaviour
{
    private void Awake()
    {
        //呼叫有傳回的方法
        bool BoolTrue = BoolMathsTrue();
        Debug.Log($"<color=#f39>結果是：{BoolTrue}</color>");

        bool boolfalse = BoolMathsfalse();
        Debug.Log($"<color=#f39>結果是：{boolfalse}</color>");

        //不用先定義 直接把方法放入 
        Debug.Log($"<color=#f93>{ReturnTrue()}</color>");
        Debug.Log($"<color=#f93>{ReturnFasle()}</color>");

    }

    //先定義出兩個數字變數
    private int a = 2, b = 3; 
    //再利用這兩個數字變數進行布林運算的比大小
    private bool BoolMathsTrue()
    {
        return (a < b);
    }
    private bool BoolMathsfalse() 
    {
        return (a > b);
    }

    //直接傳回true或fasle
    private bool ReturnTrue() 
    {
        return true;
    }

    private bool ReturnFasle() 
    {
        return false;
    }

}
