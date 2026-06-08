using System;
using UnityEngine;
namespace Evan
{
    public class Class_9_Practice : MonoBehaviour
    {
        private void Awake()
        { 

                    float a = -999.321f;
                    var floatToSbyte = Convert.ToSByte(a);
            LogWithColor.LogWithColors(floatToSbyte, "#f93");
        }
    }
    
}