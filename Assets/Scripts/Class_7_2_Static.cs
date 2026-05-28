using UnityEngine;
using UnityEngine.SceneManagement;
namespace Evan
{
    /// <summary>
    /// 靜態(Static)
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour

    {
        //變數 屬性 方法 三個是屬於成員

        //非靜態變數
        public int inventoryWater = 10;
        //非靜態屬性
        public string skillMain => "火球術";
        //非靜態方法
        public void Punch()
        {
            Debug.Log($"<color=#3f3>普攻</color>");
        }

        //靜態變數：修飾詞後加上Static
        //靜態變數不會顯示在unity屬性面板上
        public static int inventoryProp = 20;
        //靜態屬性
        public static string skillSecond => "治癒術";
        //靜態方法
        public static void kick()
        {
            Debug.Log($"<color=#3f3>踢</color>");
        }

        private void Awake()
        { 
            //非靜態變數修改數值
            //inventoryWater = 7;
            //inventoryProp = 15;
            Debug.Log($"<color=#f31>藥水{inventoryWater}</color>");
            Debug.Log($"<color=#f31>藥水{inventoryProp}</color>");

        }
        private void Start()
        {

            //靜態與非靜態成員在Unity內的差異 主要在場景切換時 
            //非靜態成員會被釋放 即切換場景後 資料會歸零重來
            //靜態成員不會被釋放 即切換場景後 資料會持續保留 如用在保留遊戲道具上
            inventoryWater++; //藥水加一
            Debug.Log($"<color=#3f3>藥水 {inventoryWater}</color>");
            inventoryProp++; //道具加一
            Debug.Log($"<color=#3f3>藥水 {inventoryProp}</color>");

        }
        private void Update()
        {
            //在game畫面按下左邊數字1 會重新載入場景 
            //如果 輸入 按下鍵盤 按鍵 左邊數字1(Alpha1)
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程7_1_屬性_靜態");
            }
        }

    }

}