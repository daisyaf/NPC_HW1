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
    /// ���
    /// </summary>
    /// <param name="chatAlpha">��g��ܤ��e</param>
    private void chat(string chatAlpha)
    {
        print("Apha:" + chatAlpha);
    }

   /// <summary>
   /// �}�Ұө�
   /// </summary>
   /// <returns>��g�O�Χ_</returns>
    public bool openStore()
    {
        return true;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="buyWhat">�R���F����</param>
    public int buyObject(int buyWhat=100)
    {
        return buyWhat;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="MissionNumber">���Ƚs��</param>
    public void getMission(int MissionNumber)
    {
        print("���Ƚs����:" + MissionNumber);
    }

    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="MissionObject">��o���ȹD��ƶq</param>
    /// <returns></returns>
    private int missionUpdate(int MissionObject=1)
    {
        return MissionObject;
    }
    
    /// <summary>
    /// ��������
    /// </summary>
    /// <returns>���Ƚs�����Ѽ�</returns>
    private bool completeMission()
    {
        return false;
    }

}
