using Unity.VisualScripting;
using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 第七堂練習
    /// </summary>
    public class Class_7_Practice : MonoBehaviour
    {
        #region 有回傳值的寫法
        //先定義一個數字暫存值 並可在屬性面板控制數值
        //[SerializeField]
        //private float _hp = 100;

        //public float hp
        //{
        //  get
        //  {
        //     if(_hp <= 0) Debug.Log($"<color=#77f>死亡</color>");
        //     return _hp;
        //  }
        //}
        //
        //private void Update()
        //{
        //     Debug.log(hp);
        //} 
        #endregion

        #region 第二種寫法
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
        #endregion
        }


    }

}
