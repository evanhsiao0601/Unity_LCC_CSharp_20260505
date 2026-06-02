using Evan;
using UnityEngine;
namespace Evan
{ }
public class Class_8_2_Struct : MonoBehaviour 
{
    private void Awake()
    {

        Class_8_2_PlayerData player1 = new Class_8_2_PlayerData(2, 30);
        Class_8_2_PlayerData player2 = new Class_8_2_PlayerData(5, 100);

        //測試輸出工具 LogWithColors
        LogWithColor.LogWithColors("測試輸出工具", "#6f6");
    }

}
