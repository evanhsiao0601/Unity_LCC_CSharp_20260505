using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 委派 Delegate
    /// </summary>
    public class Class_19_Delegate : MonoBehaviour
    {
        private void Awake()
        {
            // 1. 將float當作參數
            Cure(10);
            // 2. 將元組當作參數
            //兩層括號是因為元組方法就是用兩層 因此在這也會一致
            Card(("史萊姆", 7));
        }

        //各種參數：

        // 1. 將float當作參數
        private void Cure(float cure)
        {
            LogWithColor.LogWithColors($"治療{cure}", "#f3f");
        }

        // 2. 將元組當作參數
        private void Card((string name, int index) card)
        {
            LogWithColor.LogWithColors($"卡片{card.name} 編號{card.index}", "#f3f");
        }

        // 3. 委派 Delegate：將方法當作參數
        // 委派特色是可以一次喚出多個相同簽章的方法 簽章包含傳回和參數兩者
        // 關鍵字 delegate 是一種專門用來儲存方法的型別 不是類別

        // 3a. 宣告委派

        #region 無傳回無參數的委派方法
        // 在此為無回傳void 和無參數()
        // 宣告一個無傳回與參數的委派  DelegateMathod是委派型別命名的名稱
        private delegate void DelegateMathod();
        #endregion

        #region 有傳回有參數的委派方法
        //宣告一個有傳回有參數的委派  Calculate是委派型別命名的名稱
        private delegate float Calculate(float numberA, float numberB);
        #endregion

        #region 無傳回有參數的泛型委派
        //宣告一個無傳回有參數的泛型委派  DelegateCombine是委派型別命名的名稱
        private delegate void DelegateCombine<T>(T a);
        #endregion

        // 3b. 目標方法
        // 簽章必須與委派相同 所以必須是無回傳和無參數

        #region 無傳回無參數的委派方法
        private void Test()
        {
            LogWithColor.LogWithColors("測試", "#f3f");
        }

        private void Talk()
        {
            LogWithColor.LogWithColors("嗨", "#f3f");
        }
        #endregion

        #region 有傳回有參數的委派方法
        private float Add(float numberA, float numberB)
        {
            float result = numberA + numberB;
            LogWithColor.LogWithColors(result, "#f3f");
            return result;
        }
        private float Sub(float numberA, float numberB)
        {
            float result = numberA - numberB;
            LogWithColor.LogWithColors(result, "#f3f");
            return result;
        }
        private float Mul(float numberA, float numberB)
        {
            float result = numberA * numberB;
            LogWithColor.LogWithColors(result, "#f3f");
            return result;
        }
        #endregion

        #region 無傳回有參數的泛型委派
        private void Combine<T>(T a)
        {
            LogWithColor.LogWithColors(a, "#ff3");
        }
        #endregion

        // 3c. 宣告變數存放方法 (預設為空值)

        #region 無傳回無參數的委派方法
        //宣告一個可以符合 DelegateMethod 委派規則方法的變數 
        private DelegateMathod delegateMathod;
        #endregion

        #region 有傳回有參數的委派方法
        //宣告一個可以符合 Calculate 委派規則方法的變數
        private Calculate calculate;
        #endregion

        #region 無傳回有參數的泛型委派
        //要先建立一個可以存放 float 方法的變數
        private DelegateCombine<float> delegateCombineFloat;
        //要先建立一個可以存放 int 方法的變數
        private DelegateCombine<int> delegateCombineInt; 
        #endregion

        // 3d. 呼叫委派
        private void Start()
        {
            #region 基本委派
            // 把 Test 方法交給 Delegate
            delegateMathod = Test;
            //可以同時加入複數相同簽章的方法 喚出時一起執行
            delegateMathod += Talk;
            //也可以刪除方法
            delegateMathod -= Talk;

            // 透過 Delegate 執行 Test 方法
            delegateMathod();
            #endregion

            #region 運算的委派
            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            //帶入數字就可以同時進行三種運算
            calculate(10, 3);
            //也可以增加不同組別數字 會同時顯示六種運算
            calculate(100, 70);
            #endregion

            #region 將委派方法當作參數
            //喚出CalculateNumber 同時指定具體使用的方法和其數字
            CalculateNumber(Add, 3, 7);
            #endregion

            #region 無傳回有參數的泛型委派
            //有一個存放 float 方法的變數後 才能將符合型別的方法放入變數中並執行
            delegateCombineFloat = Combine<float>;
            delegateCombineFloat(3.5f);
            delegateCombineInt = Combine<int>;
            delegateCombineInt(3); 
            #endregion

        }

        // 3e. 將委派方法當作參數
        // 任何回傳 float 且有兩個 float 參數的方法 都可當作 Calculate

        #region 將委派方法當作參數
        private void CalculateNumber(Calculate calculate, float a, float b)
        {
            //執行傳進來的方法 並把結果存到 result
            //加()是因為寫法是像方法一樣呼叫
            var result = calculate(a, b);
            LogWithColor.LogWithColors(result, "#ff3");
        } 
        #endregion
    }
}
