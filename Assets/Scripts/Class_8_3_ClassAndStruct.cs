using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 類別和結構的差異
    /// </summary>
    public class Class_8_3_ClassAndStruct : MonoBehaviour
    {
        #region 類別和結構的空值測試 類別可以有空值 結構無法有空值
        private void Awake()
        {
            Class_8_3_Class class1 = new Class_8_3_Class(); // 新增一個物件/結構並初始化
            Class_8_3_Class class2; //類別可以空值
                                    // Class_8_3_Class class2 = null; //如上另一種寫法 null為空值

            Class_8_3_Struct struct1 = new Class_8_3_Struct(); // 新增一個物件/結構並初始化
            Class_8_3_Struct struck2; //結構不能有空值 會報錯
            //Class_8_3_Struct struck2 = null; //如上另一種寫法 null為空值

        } 
        #endregion

        private void Start()
        {
            //var 不指定類型 可以儲存所有資料
            var testClass = new Class_8_4_Class("我是類別");
            var testStruct = new Class_8_4_Struct("我是型別");
            var testClass2 = new Class_8_4_Class("我是類別2");
            var testStruct2 = new Class_8_4_Struct("我是型別2");

            //一般狀況 類別和結構皆正常顯示
            LogWithColor.LogWithColors(testClass.name, "#79f ");
            LogWithColor.LogWithColors(testClass2.name, "#79f ");
            LogWithColor.LogWithColors(testStruct.name, "#79f ");
            LogWithColor.LogWithColors(testStruct2.name, "#79f ");

            //類別的傳址：當Class和Class2指向同一個地址
            //Class指派給另一個變數時 不會複製物件而是複製位址
            //所以在此前提下修改testClass的數值 會讓testClass和testClass2都有相同的改變
            testClass2 = testClass;

            //結構的傳值：當Struct和Struct2指向同一個值
            //Struct指派給另一個變數時會複製一份新的資料 
            //所以在此前提下修改testStruct的數值 不會影響到原本的testStruct2的數值
            testStruct2 = testStruct;

            //修改Class和Class2的資料都會被同步
            testClass.name = "類別";
            LogWithColor.LogWithColors(testClass.name, "#79f ");
            LogWithColor.LogWithColors(testClass2.name, "#79f ");

            //修改Struct和Struct2的資料不會被同步
            testStruct.name = "結構";
            LogWithColor.LogWithColors(testStruct.name, "#79f ");
            LogWithColor.LogWithColors(testStruct2.name, "#79f ");

        }
    }

    #region 類別和參考型別的特色
    //類別(Class)：
    //1. 繼承：允許繼承
    //2. 建構子：可以有多個建構子
    //3. 空值：類別可以空值
    //4. [參考型別]的資料儲存類型方式為[類別]

    //參考型別(Reference Type)的特色：
    //1. 記憶體位置：Heap 堆
    //2. 資料：類別
    //3. 資料傳遞方式：傳址

    public class Class_8_3_Class : MonoBehaviour //允許繼承MonoBehaviour
    {
        public Class_8_3_Class() //建構子1  可以有多個建構子 且括號內可以不用參數
        {

        }
        public Class_8_3_Class(int test) //建構子2 
        {

        }
    }
    #endregion

    #region 結構和實值型別的特色
    //結構(Struct)：
    //1. 繼承：不允許繼承
    //2. 建構子：建構子一定要有參數 可以有多個建構子 但不同建構子的參數要不同才行 稱為建構子多載(Overload)
    //3. 空值：結構無法空值
    //4. [實值型別]的資料儲存類型方式為[結構]

    //實值型別(Value Type)的特色：
    //1. 記憶體位置：Stack 棧
    //2. 資料：結構
    //3. 資料傳遞方式：傳值
    public struct Class_8_3_Struct
    {
        public Class_8_3_Struct(int test)//建構子1 括號內一定要有參數
        {

        }
        public Class_8_3_Struct(int test, int hp)//建構子2 括號內參數要不同
        {

        } 
    #endregion

    }

}
