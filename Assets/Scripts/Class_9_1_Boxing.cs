using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 裝箱(Boxing) 拆箱(Unboxing)
    /// </summary>
    public class Class_9_1_Boxing : MonoBehaviour
    {
        //[實質型別]的資料類型：
        //結構 列舉 整數 浮點數 布林值 字元
        //實質型別的資料會儲存在Stack記憶體內
        private int number = 100; //int 整數

        //[參考型別]的資料類型：
        //物件 類別 字串
        //物件(Object)資料類型為[參考型別]
        private object box;

        private object boxNumber = 50;
        private int count;
        private void Awake()
        {
            //裝箱 (Boxing)
            //將int(實值型別)放進object(參考型別)資料內
            box = number;
            LogWithColor.LogWithColors(box.ToString(), "#33");

            //拆箱 (Unboxing)
            //將object(參考型別)資料放到int(實值型別)內
            //在前面加上(要轉換的資料類型)
            count = (int)boxNumber;
            LogWithColor.LogWithColors(count.ToString(), "#33");

        }

    }

}
