using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 練習取得和設定靜態資料
    /// </summary>
    public class Class_7_2_GetStaticData : MonoBehaviour
    {
        //取得非靜態資料(成員)
        //先定義要獲得的資料類別變數(class_7_2) 透過變數取得非靜態資料(成員)
        public Class_7_2_Static class_7_2;
        private void Awake()
        {
            //變數名稱 非靜態成員
            //取得非靜態變數
            Debug.Log($"<color=#f3d>非靜態變數 {class_7_2.inventoryWater}</color>");
            //取得非靜態屬性
            Debug.Log($"<color=#f3d>非靜態屬性 {class_7_2.skillMain}</color>");
            //呼叫非靜態方法
            class_7_2.Punch();

            //類別名稱 靜態成員 (不用定義變數 可以直接取得)
            //取得靜態變數
            Debug.Log($"<color=#f3d>靜態成員 {Class_7_2_Static.inventoryProp}</color>");
            //取得靜態屬性
            Debug.Log($"<color=#f3d>靜態成員 {Class_7_2_Static.skillSecond}</color>");
            //呼叫靜態方法
            Class_7_2_Static.kick();

        }

        //取得史萊姆的資料
        //需要在屬性面板上把畫面中的物件拖曳到Script裡定義的變數裡面(slimeGreen SlimeBlue)
        public Class_7_2_Slime slimeGreen, slimeBlue;
        private void Start()
        {
            //非靜態成員
            slimeGreen.hp -= 10; slimeBlue.hp -= 10;
            Debug.Log($"<color=#f3d>綠史萊姆 HP{slimeGreen.hp}</color>");
            Debug.Log($"<color=#f3d>藍史萊姆 HP{slimeBlue.hp}</color>");

            //靜態成員
            //修改史萊姆移動速度
            Class_7_2_Slime.moveSpeed = 3.5f;
            Debug.Log($"<color=#f3d>史萊姆移動速度{Class_7_2_Slime.moveSpeed}</color>");
        }

    }

}
