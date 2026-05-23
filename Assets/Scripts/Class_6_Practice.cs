using UnityEngine;

namespace Evan
{
public class Class_6_Practice : MonoBehaviour 
{
        public string[,,] shop =
        {
            {{"呆呆獸", "皮丘" },{"雷丘", "水箭龜"},{"妙蛙種子", "妙蛙花"},{"皮卡丘", "卡比獸"} },
            {{"地精", "史萊姆"},{"菇菇寶貝", "毒菇"},{"哥布林", "巨人"},{"獸人", "毒草"} },
            {{"魔法", "物理"},{"速度", "防禦"},{"蓋倫", "爆擊"},{"傷害", "魔防"} }
        };
        private void Start() 
        {

            Debug.Log($"<color=#f33>第一頁第四排的第一個是{shop[0, 3, 0]}</color>");
            Debug.Log($"<color=#f33>第二頁第二排的第一個是{shop[1, 1, 0]}</color>");
            Debug.Log($"<color=#f33>第三頁第三排的第一個是{shop[2, 2, 0]}</color>");

        }

}

}
