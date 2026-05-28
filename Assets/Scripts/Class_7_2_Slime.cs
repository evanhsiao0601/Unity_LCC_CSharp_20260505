using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 模擬史萊姆
    /// </summary>
    public class Class_7_2_Slime : MonoBehaviour
    {
        //非靜態成員是每個物件個別擁有 不共享 即每隻史萊姆有自己的血量 
        public float hp = 100;
        //靜態成員是整個類別共同擁有 即使萊姆的移動速度每隻都相同
        public static float moveSpeed = 1.5f;
    }
}
