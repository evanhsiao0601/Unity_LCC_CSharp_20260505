using System;
using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 事件 Event
    /// 當一件事發生後會通知所有系統
    /// 範例：死亡事件
    /// 玩家系統 > 死亡事件 當玩家死亡會執行死亡事件通知其他系統
    /// 控制系統 > 訂閱死亡事件 > 停止控制系統
    /// 音樂系統 > 訂閱死亡事件 > 變更BGM
    /// </summary>
    public class Class_19_Event : MonoBehaviour
    {
        //Delegate（委派）：可以把方法當成變數 誰都可以呼叫
        //Action / Func：內建的委派型別 方便不用自己宣告 delegate
        //Event（事件）：建立在委派之上 用來發布通知 外部只能訂閱（+=）或「取消訂閱（-=）
        //不能直接觸發事件 因此適合用在 Unity 中像是玩家死亡 血量改變 按鈕點擊 場景切換等某件事情發生了的情境

        //Event 事件使用步驟：
        // 1. 宣告事件(委派)
        // 2. 呼叫事件
        // 3. 其他系統訂閱事件

        private float hp = 10;

        // 1. 宣告事件
        //無傳回無參數的委派方法 可以把delegate改用action
        //宣告一個delegate 名稱為Usingdelegate
        public delegate void Usingdelegate();
        //事件關鍵字 event 可以改為 public event action onDead
        public event Usingdelegate onDead;
        //有參數的委派方法
        public event Action<string, float> onDeadAction;

        //可以寫很多玩家死亡後的方法 加進onDead 例如：
        //onDead += GameOver;
        //onDead += PlayDeadSound;
        //onDead += ShowUI;
        //呼叫事件 onDead.Invoke();的時候 就會依序執行這些方法

        //C#內建Event事件：
        //Action和Event的區別：
        //Action外部可以隨意清空或觸發修改　Event只能用來訂閱
        //無參數
        public event EventHandler onEvent;
        //有參數
        public event EventHandler<float> onEventHp;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) 
                Damage(5);
        }

        private void Damage (float damage)
        {
            hp -= damage;

            if (hp <= 0)
            {
                #region 委派方法(訂閱)
                LogWithColor.LogWithColors("玩家死亡", "#f99");

                // 2. 呼叫事件
                //在玩家死亡後放入onDead 像一個標記
                //利用問號判斷是否有訂閱者 有的話才會呼叫
                //delegate的Invoke是立即執行的意思
                //onDead沒有加入任何方法的話 執行後不會發生任何事
                onDead?.Invoke();

                //參數是string和float
                //玩家和HP帶入到Class_19_BGM_Manager的ChangeBgmActon方法中
                onDeadAction?.Invoke("玩家", hp);
                #endregion

                #region 事件(訂閱)
                //event第一個參數永遠是誰發出的事件（Sender） EventArgs.Empty為沒有資料
                onEvent?.Invoke(this, EventArgs.Empty);
                //hp對應上面EventHandler<float>的float
                onEventHp?.Invoke(this, hp); 
                #endregion
            }
        }
    }
}
