using System;
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

        #region **Func委派 Action委派 Predicate委派
        //三種委派的好處是這三種狀況涵蓋大部分 可以直接使用

        //Func委派
        //存放有傳回 有0個以上的參數的方法
        //以下範例為 宣告一個委派 有一個參數float 傳回值為float
        //<參數,傳回值>
        private Func<float, float> funcCalc;
        //不用詳細寫如 private delegate float Calculate(float numberA, float numberB);

        //Action委派
        //存放無傳回 有0個以上的參數的方法
        //以下範例為 宣告一個委派 沒有參數也沒有傳回值
        private Action actionMethod;
        //不用詳細寫如 private delegate void DelegateMathod();

        //Predicate委派
        //存放有布林值傳回 有1個參數方法
        //以下範例為 宣告一個委派 有一個參數float 傳回值為bool
        private Predicate<float> predicate; 
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

            #region 多播委派
            //把三種運算方法加入一個委派中
            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            //帶入數字就可以同時進行三種運算
            calculate(10, 3);
            //也可以增加不同組別數字 會同時顯示六種運算
            calculate(100, 70);
            #endregion

            #region 委派匿名方法
            //不另外定義方法加入其中 就可使用匿名委派
            //標準寫法如下 delegate (參數) {陳述式}
            DelegateMathod anonymousMathod = delegate () { };
            //也可把有參數的委派進行匿名 
            //因為上面private delegate float Calculate(float numberA, float numberB);
            //是有回傳float 所以後面要加回傳結果 例如{ return a + b; };
            Calculate anonymousCalc = delegate (float a, float b) { return a + b; };
            #endregion

            #region 委託匿名和簡寫方式
            //標準簡寫寫法如下
            DelegateMathod anonymousMathod2 = () => { };
            //Calculate委派的簡寫如下 直接省略float型別
            Calculate anonymousCalc2 = (a, b) => { return a + b; };

            //呼叫的時候：
            //喚出時指定 Calculate 委派中 具體要使用裡面哪一個的方法和哪兩個數字
            CalculateNumber(Add, 3, 7);
            //直接將匿名方法當作參數
            CalculateNumber(anonymousCalc, 3, 7);

            //參數上使用匿名方法 根據參數的數量和順序來對應 所以不須方法名稱
            //delegate就是匿名時都使用的名稱
            //以CalculateNumber(Calculate calculate, float a, float b) 方法來說
            //第一個參數是calculate為尚未決定的計算函式本身 此參數在var result = calculate(a, b);
            //a和b則是另外兩個數字參數
            CalculateNumber(delegate (float a, float b) { return a / b; }, 9, 3);
            //參數上使用匿名方法 簡寫：
            CalculateNumber((a, b) => { return a / b; }, 9, 3);
            #endregion

            #region Lambda 運算子 (匿名方法的簡寫)
            //(參數) => {陳述式}

            //Action匿名方法
            Action action = () => { LogWithColor.LogWithColors("Lambda 運算子", "#f33"); };
            //無傳回要搭配action();執行
            action();

            //Func匿名方法
            Func<int, string> func = (x) => { return $"Lambda 運算子 {x}"; };
            //將77帶入x裡面 使用func方法
            LogWithColor.LogWithColors($"{funcCalc(77)}", "#f33");

            //Predicate匿名方法
            Predicate<string> predicateTest = (x) => { return x.Length > 0; };
            //將Evan帶入x裡面 使用predicateTest方法 看是否文字長度大於0 一定要有布林值傳回
            LogWithColor.LogWithColors($"{predicateTest("Evan")}", "#f33"); 
            #endregion

            #region **Func委派 Action委派 Predicate委派 的應用
            //Func委派
            //詳細定義運算的方式
            funcCalc = delegate (float x) { return x * 10; };
            //將3.5帶入x裡面運算產生結果
            LogWithColor.LogWithColors($"Func委派 {funcCalc(3.5f)}", "#f33");

            //Action委派
            //沒有參數沒有回傳 因此Action純粹直接執行一個指令
            actionMethod = delegate () { LogWithColor.LogWithColors("Action委派", "#f33"); };

            //Predicate委派
            predicate = delegate (float x) { return x > 10; };
            //將7帶入x裡面運算 運算結果會傳回布林值
            LogWithColor.LogWithColors($"Func委派 {predicate(7)}", "#f33");
            #endregion

            #region 將委派方法當作參數
            //喚出 CalculateNumber 方法
            //因為先前將 Add Sub Mul 加入 Calculate 中
            //所以喚出時指定 Calculate 委派中 具體要使用裡面哪一個的方法和哪兩個數字
            CalculateNumber(Add, 3, 7);
            #endregion

            #region 無傳回有參數的泛型委派
            //有一個存放 float 方法的變數後 才能將符合型別的方法放入變數中並執行
            //Combine方法是泛型<T>(T a) 把float帶入T a則是3.5
            delegateCombineFloat = Combine<float>;
            delegateCombineFloat(3.5f);
            delegateCombineInt = Combine<int>;
            delegateCombineInt(3); 
            #endregion



        }

        // 3e. 將委派方法當作參數
        // 任何有兩個 float 參數的方法 都可當作 Calculate

        #region 將委派方法當作參數
        //建立一個 CalculateNumber 方法
        private void CalculateNumber(Calculate calculate, float a, float b)
        {
            //執行傳進來的方法 並把結果存到 result
            //加()是因為寫法是像方法一樣呼叫 a和b為兩個 float 數字
            var result = calculate(a, b);
            LogWithColor.LogWithColors(result, "#ff3");
        } 
        #endregion
    }
}
