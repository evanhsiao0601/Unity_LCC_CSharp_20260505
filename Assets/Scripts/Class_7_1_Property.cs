using UnityEngine;
namespace Evan
{
        /// <summary>
        /// 屬性(Property)
        /// </summary>
    public class Class_7_1_Property : MonoBehaviour
    {

    #region 基本屬性

        //公開的變數：可以讓外部讀取和寫入
        public float moveSpeed = 3.5f;
        //私人的變數：不允許讓外部讀取和寫入
        public float turnSpeed = 1.7f;

        //屬性快捷鍵：prop + Tab 
        //公開的屬性：允許外部讀取和修改 get是讀取 set是修改
        public float runSpeed { get; set; }
        //私人的屬性：不允許外部讀取和修改
        private float sprintSpeed { get; set; }
        //唯讀的公開屬性：允許外部讀取 但沒有set的話 不管內部或外部都無法修改
        public float jumpSeed { get; }
        //有預設值的屬性
        public byte lv { get; set; } = 1;

        private void Awake()
        {
            Debug.Log("----取得變數和屬性----");
            Debug.Log(moveSpeed);
            Debug.Log(turnSpeed);
            Debug.Log("----設定變數和屬性----");
            //可以直接在類別內修改值
            moveSpeed = 11.1f;
            turnSpeed = 2.5f;
        }
        #endregion

        #region 屬性縮寫
        public float hp { get; set; } = 100;
        //屬性標準寫法
        //_mp是用來裝屬性mp的容器 預設為50
        private float _mp = 50;
        //屬性是給予外部存取權限的窗口
        public float mp
        {
            //取得_mp的預設值
            get
            {
                return _mp;
            }
            //可修改_mp的預設值
            set
            {
                _mp = value;
            }
        }
        #endregion

        #region 唯獨屬性縮寫
        //取得屬性的簡寫(箭頭 => Lambda)
        //唯獨屬性一般簡寫
        public int def { get; } = 30;
        //唯獨屬性更簡易寫法
        public int atk => 50; 
        #endregion


        private void Start() 
        {
            Debug.Log($"<color=#77f>魔力：{mp}</color>");
            //修改mp的值為500
            mp = 500;
            Debug.Log($"<color=#77f>魔力：{mp}</color>");
        }

    }
}


