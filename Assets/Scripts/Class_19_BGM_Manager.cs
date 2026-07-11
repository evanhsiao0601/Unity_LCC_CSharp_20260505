using UnityEngine;
using static Evan.Class_15_2_Generices;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;
namespace Evan
{
    /// <summary>
    /// 音樂系統
    /// </summary>
    public class Class_19_BGM_Manager : MonoBehaviour
    {
        //連結到Class_19_Event腳本
        [SerializeField]
        private Class_19_Event class_19_event;

        // 3. 訂閱事件(unity習慣在Awake或Start訂閱)
        private void Awake()
        {
            //將這裡的ChangeBgm加進onDead委派方法中
            class_19_event.onDead += ChangeBgm;
            //把ChangeBgmAction加進onDeadAction委派方法中
            class_19_event.onDeadAction += ChangeBgmAction;
            class_19_event.onEvent += ChangeBgmEvent;
            class_19_event.onEventHp += ChangeBgmEventHp;
        }
            private void ChangeBgm()
            {
              LogWithColor.LogWithColors("變更音樂", "#f99");
            }

            private void ChangeBgmAction(string PlayerName, float PlayerHp)
            {
              LogWithColor.LogWithColors($"{PlayerName}{PlayerHp}", "#f99");
              if (PlayerHp <= 0) 
                LogWithColor.LogWithColors($"變更遊戲結束音樂", "#f99");
            }

            //對應Class_19_Event的 事件(訂閱) 函式
            //_hp帶入Class_19_Event 內 onEventHp?.Invoke(this, hp); 的hp
            private void ChangeBgmEventHp(object sender, float _hp)
            {
              LogWithColor.LogWithColors($"{sender}{_hp}", "#f99");
            }
              private void ChangeBgmEvent(object sender, System.EventArgs none)
            {
              LogWithColor.LogWithColors($"{sender}{none}", "#f99");
            }
      }
    }
