using UnityEditor;
using UnityEngine;

//常用快捷鍵：
// 1. 格式化(排版) Ctrl + K D
// 2. 程式碼片段 Ctrl + K S 選 region

//命名空間(name space)：將類別分類　不同空間可以有相同名稱類別　不會互相影響
namespace Evan 
{
    /// <summary>
    /// 選取陳述式(selection statement)
    /// 1. if判斷式
    /// 2. switch判斷式
    /// </summary>
    public class Class_5_1_selectiont : MonoBehaviour
    {

        private void Awake()
        {
            //1. 判斷式(if)
            //寫法：if(布林值) {陳述式}
            if (true)
            {
                Debug.Log($"<color=#f39>當布林值為True，會執行這裡");
            }

            if (false)
            {
                Debug.Log($"<color=#f39>當布林值為false，不會執行，會有綠蚯蚓錯誤");
            }
        }

        //定義一個布林值 在顯示面板增加勾選框(布林值顯示的是勾選框) 和標題 
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        //定義預設分數為100 如果在SerializeField中加上Range就會產生滑桿
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        //定義一個字串 武器及其標題
        [SerializeField, Header("武器")]
        private string weapon;
        //定義一個血量 預設為100
        [SerializeField, Header("血量"), Range(0, 100)]
        private int HP = 100;

        //更新事件(update)：一秒鐘執行60次(60 FPS)
        private void Update()
        {
            #region 判斷式 if
            Debug.Log($"<color=#f39>更新中</color>");

            //如果勾選框打勾 布林值是true
            if (isOpen)
            {
                Debug.Log($"<color=#f93>已經開門</color>");
            }
            else
            {
                Debug.Log($"<color=#f93>門關了</color>");
            }
            //如果 分數>=60裝況
            if (score >= 60)
            {
                Debug.Log($"<color=#f93>你通過了</color>");
            }
            //否則如果 分數>=40的莊況
            else if (score >= 40)
            {
                Debug.Log($"<color=#f93>你需要補考</color>");
            }
            //否則如果 分數>=20裝況
            else if (score >= 20)
            {
                Debug.Log($"<color=#f93>你需要補考並做報告</color>");
            }
            //否則 沒有符合以上被當
            else
            {
                Debug.Log($"<color=#f93>你被當了</color>");
            }
            #endregion

            #region 判斷式 switch
            switch (weapon)
            {
                //case weapon值等於以下預設值會執行 break是跳出判斷式
                //如果武器等於小刀 攻擊力等於20
                //相同內容的case置於原本case之上 就可以不用打重複的敘述式
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log($"<color=#ff3>攻擊力：20</color>");
                    break;
                case "美工刀":
                    Debug.Log($"<color=#ff3>攻擊力：10</color>");
                    break;
                case "屠龍刀":
                    Debug.Log($"<color=#ff3>攻擊力：999</color>");
                    break;
                //當weapon值不等於以上預設值會執行
                default:
                    Debug.Log($"<color=#ff3>無法使用該武器</color>");
                    break;

            }
            #endregion

            #region if 練習
            //血量 if寫法
            if (HP >= 80)
            {
                Debug.Log("<color=#93>安全</color>");
            }
            else if (HP >= 60)
            {
                Debug.Log("<color=#93>注意</color>");
            }
            else if (HP >= 40)
            {
                Debug.Log("<color=#93>警告</color>");
            }
            else if (HP >= 10)
            {
                Debug.Log("<color=#93>危險</color>");
            }
            else if (HP == 0)
            {
                Debug.Log("<color=#93>死亡</color>");
            }

            //血量 搭配邏輯運算子寫法 if加上&&(如果加上並且)
            //else if (HP >= 10 && HP < 40)
            //{
            //    Debug.Log("<color=#93>危險</color>");
            //}
            //else if (HP >= 40 && HP < 60)
            //{
            //    Debug.Log("<color=#93>警告</color>");
            //}
            //else if (HP >= 60 && HP < 80)
            //{
            //    Debug.Log("<color=#93>注意</color>");
            //}
            // else if (HP >= 80)
            //{
            //    Debug.Log("<color=#93>安全</color>");
            //}
            //else if (HP == 0)
            //{
            //    Debug.Log("<color=#93>死亡</color>");
            //} 
            #endregion
        }
    }
}
