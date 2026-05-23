using UnityEngine;
namespace Evan
{
public class Class_5_1_Practice : MonoBehaviour
{
        [SerializeField, Header("血量")]
        int HP = 100;
        private void Update()
        {
            switch (HP)
            {
                case >=80:
                    Debug.Log("<color=#f93>安全</color>");
                    break;
                case >=60:
                    Debug.Log("<color=#f93>狀況</color>");
                    break;
                case >=40:
                    Debug.Log("<color=#f93>警告</color>");
                    break;
                case >= 10:
                    Debug.Log("<color=#f93>危險</color>");
                    break;
                case  0:
                    Debug.Log("<color=#f93>死亡</color>");
                    break;
            }
        }
    }

}