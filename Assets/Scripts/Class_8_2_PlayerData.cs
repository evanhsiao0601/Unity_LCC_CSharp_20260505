using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 結構(Struct)：通常用來保存資料 不能繼承MonoBehaviour
    /// 寫法除了開頭public struct外 都與建構子相同
    /// </summary>
    public struct Class_8_2_PlayerData
    {
        //先定義等級lv和血量hp兩個欄位
        public int lv;
        public float hp;

        //_lv和_hp為參數 暫時允許外部傳進來的值
        public Class_8_2_PlayerData(int _lv, float _hp) 
        {
            //把外部傳進來的值存入struct的欄位內
            lv = _lv;
            hp = _hp;

        }

    }
}
