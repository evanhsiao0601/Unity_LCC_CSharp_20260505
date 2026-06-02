using UnityEngine;
namespace Evan
{
    /// <summary>
    /// 輸出訊息工具
    /// </summary>
    public class LogWithColor
    {
        /// <summary>
        /// 輸出訊息並指定顏色
        /// </summary>
        /// <paramn name="message">訊息</param>
        /// <paramn name="color">顏色</param>
        public static string LogWithColors(string message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result ;
        }

        public static string LogWithColors(object message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }

    }

}