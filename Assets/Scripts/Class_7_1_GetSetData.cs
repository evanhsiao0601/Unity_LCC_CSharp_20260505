using UnityEngine;
namespace Evan
{
    public class Class_7_1_GetSetData : MonoBehaviour
    {
        //取得Class_7_1_Property檔案裡的資料
        public Class_7_1_Property property;
        private void Awake()
        {
            //取得一個公開的類別資料 無法取的私人資料
            Debug.Log(property.moveSpeed);
            //修改另一個檔案的類別資料的數值 僅限公開的
            property.moveSpeed = 7.7f;

            //取得一個公開的屬性類別資料 無法取的私人資料
            Debug.Log(property.runSpeed);
            //修改另一個檔案的屬性類別資料的數值 僅限公開的
            //不可修改只有原始檔案只有讀取{get;}的資料 要有set才能修改{ get; set; }
            property.runSpeed = 50.5f;

        }

    }

}
