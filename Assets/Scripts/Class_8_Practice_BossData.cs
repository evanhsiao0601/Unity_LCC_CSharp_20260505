using JetBrains.Annotations;
using UnityEngine;

public class Class_8_Practice_BossData
{
    public string bossName;
    public string bossSkill;
    public int bossHp;

    public Class_8_Practice_BossData(string _bossName, string _bossSkill, int _bossHp) 
    {

        bossName = _bossName;
        bossSkill = _bossSkill;
        bossHp = _bossHp;

    }

    #region 不用定義方法就能顯示在Log內
    public void ShowBossName()
    {
        Debug.Log($"<color=#f393>-----頭目現身-----");
        Debug.Log($"<color=#f393>名稱：{bossName}");
    }
    public void ShowBossSkill()
    {
        Debug.Log($"<color=#f393>招式：{bossSkill}");
    }
    public void ShowBossHp()
    {
        Debug.Log($"<color=#f393>血量：{bossHp}");
    } 
    #endregion

}
