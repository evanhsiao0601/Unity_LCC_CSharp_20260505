using UnityEngine;
namespace Evan
{
    public class Class_8_Practice : MonoBehaviour
    {
        private void Awake()
        {
            Class_8_Practice_BossData Boss1 = new Class_8_Practice_BossData("利維坦", "鑽石冰塵", 500000);
            Class_8_Practice_BossData Boss2 = new Class_8_Practice_BossData("哈迪斯", "虛空煉獄", 500000);

            Boss1.ShowBossName();
            Boss1.ShowBossSkill();
            Boss1.ShowBossHp();

            Boss2.ShowBossName();
            Boss2.ShowBossSkill();
            Boss2.ShowBossHp();
        }

    }

}
