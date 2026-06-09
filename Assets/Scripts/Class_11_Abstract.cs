using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 抽象(Abstrct)
    /// </summary>
    public class Class_11_Abstract : MonoBehaviour
    {
        private void Awake()
        {
            //抽象類別：
            //1. 必須使用關鍵字 abstract
            //2. 不能被實體化 (new)
            //3. 如果有抽象方法成員 其方法不需要主體 大括號{}
            //4. 抽象成員必須被子類別實作 (override)
            var flyDragon = new FlyDragon();
            var threeHornDragon = new ThreeHornDragon();
            flyDragon.Attack();
            threeHornDragon.Attack();

            //向上轉型(Upcasting)
            //實體化後存放到父類別 向上轉型可以使用多型 C#會使用FlyDragon的Track
            //這個方式也可以讓多個實體化子類別歸類到同一個父類別內方便管理
            //Monster(父類別) new FlyDragon (新的子類別物件)
            Monster flyDragon2 = new FlyDragon();
            flyDragon2.Track();
            //用原本的類別建立新的實體化物件
            FlyDragon flyDragon3 = new FlyDragon();
            //有無參數的兩種方法都可以使用
            flyDragon3.Track();
            flyDragon3.Track(100);
            //不指定類別建立新的實體化物件
            var flyDragon4 = new FlyDragon();
            //有無參數的兩種方法都可以使用
            flyDragon4.Track();
            flyDragon4.Track(100);

        }

    }

    //抽象類別
    public abstract class Monster
    {
        public float hp;
        public float moveSpeed;
        //抽象方法不需要主體 大括號{}及其內容 子類別在使用override去寫
        public abstract void Attack();

        public void Track()
        {
            LogWithColor.LogWithColors("追蹤", "#f93");
        }

    }

    //如繼承抽象父類別中有寫抽象方法 那子類別就一定要放入
    public class FlyDragon : Monster 
    {
    //繼承抽象方法都要用override
        public override void Attack()
        {
            LogWithColor.LogWithColors("飛龍攻擊", "#f77");
        }
        public void Track(int speed)
        {
            LogWithColor.LogWithColors($"追蹤速度{speed}", "#f93");
        }


    }

    public class ThreeHornDragon : Monster
    {
        //繼承抽象方法都要用override
        public override void Attack()
        {
            LogWithColor.LogWithColors("三角龍攻擊", "#f77");
        }

    }
}