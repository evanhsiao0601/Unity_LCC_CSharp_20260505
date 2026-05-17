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

}
