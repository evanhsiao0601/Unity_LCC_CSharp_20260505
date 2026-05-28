using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 靜態類別 (Static Class}
    /// 靜態類別無法繼承 MonoBehaviour 不能放在unity物件上
    /// </summary>
    public static class Class_7_2_StaticClass
    {
        //靜態類別內只能有靜態成員 
        public static int lv = 1;
        public static float speed => 500;
        public static void Run()
        {
        }

        //常數(靜態)
        //常數無法修改 需要預設值
        public const string playerName = "Evan";
        //靜態值可以修改 不用預設值
        public static string playerWwapon;
    }
}
