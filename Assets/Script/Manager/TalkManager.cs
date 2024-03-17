using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData; 
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }
    void GenerateData()
    {
        talkData.Add(1, new string[] { "�ȳ� ¯����", "�׼ǰ����̾� !!", "������ �ٰ� ������?", "[E] �ޱ�, [Esc] �ȹޱ�" });
        talkData.Add(2, new string[] { "�ȳ� ¯����", "���丶�� !!", "������ �ٰ� ������?", "[E] �ޱ�, [Esc] �ȹޱ�" });
        talkData.Add(3, new string[] { "�ȳ� ¯����", "�Ǵ�κ��̾� !!", "������ �ٰ� ������?", "[E] �ޱ�, [Esc] �ȹޱ�" });
        talkData.Add(4, new string[] { "�ȳ� ¯����", "�θ��θ��븶���̾� !!", "������ �ٰ� ������?", "[E] �ޱ�, [Esc] �ȹޱ�" });
        talkData.Add(5, new string[] { "�ȳ� ¯����", "����̾� !!", "������ �ٰ� ������?", "[E] �ޱ�, [Esc] �ȹޱ�" });
    }
    public string GetTalk(int id, int talkText)
    {
        if(talkText >= talkData[id].Length)
            return null;
        else
            return talkData[id][talkText];
    }
}