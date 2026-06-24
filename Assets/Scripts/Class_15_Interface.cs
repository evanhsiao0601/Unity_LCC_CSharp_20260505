using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 介面 Interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        //如果取得隨機物品 按下數字鍵1使用 會根據物品的種類自動執行相對的方式
        //模擬物品欄的第一格
        public object inventory_1;
        private void Awake()
        {
            //創造隨機變數 範圍0到3以內 (但Unity不會出現最大值 即3) 
            int random = Random.Range(0, 3);
            LogWithColor.LogWithColors($"隨機：{random}", "#f33");

            //根據不同的隨機數字 在道具欄第一格實體化不同的物件
            if (random == 0) inventory_1 = new Prop();
            else if (random == 1) inventory_1 = new Equipment();
            else if (random == 2) inventory_1 = new Map();

        }
        private void Update()
        {
            //當按下數字鍵1
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                //如果隨機的道具是Prop 就直接建立一個變數命名為prop
                if (inventory_1 is Prop prop)
                {
                    //就可以直接使用Prop類別底下的Use方法 如果沒有把inventory_1轉型為Prop就無法使用
                    prop.Use();
                }
                else if (inventory_1 is Equipment equip)
                {
                    equip.Use();
                }
                else if (inventory_1 is Map map)
                {
                    map.Use();
                }
                //第二種轉型寫法 if (inventory_1 is Prop prop)((Prop)inventory_1).Use();
                
                //以上兩種if式道具欄寫法不建議使用 因數量一多 容易造成混亂
                //建議方法在InterfaceObject腳本
            }
        }
    }

    public class Prop
    {
        public void Use()
        {
            LogWithColor.LogWithColors("使用道具 恢復體力", "#f96");
        }

    }
    
    public class Equipment
    {
        public void Use()
        {
            LogWithColor.LogWithColors("使用裝備 裝到對應位置", "#f9f6");
        }

    }

    public class Map
    {
        public void Use()
        {
            LogWithColor.LogWithColors("使用地圖 開啟地圖功能", "#96f");
        }
    }

}
