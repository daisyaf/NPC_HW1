using UnityEngine;

public class NPC : MonoBehaviour
{
    private void Start()
    {
        string chatAlpha;
        bool openMarket = true;
        int buyWhat = 0;
        int MissionNumber = 0;
    }
    
    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="chatAlpha">填寫對話內容</param>
    private void chat(string chatAlpha)
    {
        print("Apha:" + chatAlpha);
    }

   /// <summary>
   /// 開啟商店
   /// </summary>
   /// <returns>填寫是或否</returns>
    public bool openStore()
    {
        return true;
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="buyWhat">買的東西整數</param>
    public int buyObject(int buyWhat=100)
    {
        return buyWhat;
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="MissionNumber">任務編號</param>
    public void getMission(int MissionNumber)
    {
        print("任務編號為:" + MissionNumber);
    }

    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="MissionObject">獲得任務道具數量</param>
    /// <returns></returns>
    private int missionUpdate(int MissionObject=1)
    {
        return MissionObject;
    }
    
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <returns>任務編號為參數</returns>
    private bool completeMission()
    {
        return false;
    }

}
