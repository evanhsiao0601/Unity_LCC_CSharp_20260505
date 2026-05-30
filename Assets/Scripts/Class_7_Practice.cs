using Unity.VisualScripting;
using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 第七堂練習
    /// </summary>
    public class Class_7_Practice : MonoBehaviour
    {
        public int hp { get; } = 0;

        private void Update()
        {
            if (hp <= 0)
            {
                Debug.Log($"<color=#77f>血量：{hp}</color>");
                Debug.Log($"<color=#77f>你已經死了</color>");
            }
            else
            {
                Debug.Log($"<color=#77f>血量：{hp}</color>");
                Debug.Log($"<color=#77f>你還活著</color>");
            }
        }


    }

}
