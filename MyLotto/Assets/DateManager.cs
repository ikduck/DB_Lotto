using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// DB �������� �� 1
using System.Text.RegularExpressions;
using UnityEngine.Networking;

public class DateManager : MonoBehaviour
{
    // DB �������� �� 1
    private string URL = "https://docs.google.com/spreadsheets/d/1mYQKNjp73JyKxDIm-L0PC86yFQ6_tYgYIJkVyxJD-jc/export?format=tsv&range=Q5:W"; // edit?usp=sharing
    static string LINE_SPLIT = @"\r\n|\n\r|\n|\r\t";

    private Test t = new Test();

    // IEnumerator ��?
    private IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(URL);

        // ��ȣ�� �޾ƿ�
        yield return www.SendWebRequest();

        // �ٿ����
        string Data = www.downloadHandler.text;

        // Data������ LINE_SPLIT�� ����
        string[] lines = Regex.Split(Data, LINE_SPLIT);

        // ���
        t.Initialized(lines);
    }
}

// ��ũ�Ѹ� -> API�� �������� ������ ��� , C#������ �����۾��� ���� �ʾƼ� �ſ� ����