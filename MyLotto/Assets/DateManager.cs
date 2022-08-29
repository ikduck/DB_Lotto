using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// DB 가져오는 법 1
using System.Text.RegularExpressions;
using UnityEngine.Networking;

public class DateManager : MonoBehaviour
{
    // DB 가져오는 법 1
    private string URL = "https://docs.google.com/spreadsheets/d/1mYQKNjp73JyKxDIm-L0PC86yFQ6_tYgYIJkVyxJD-jc/export?format=tsv&range=Q5:W"; // edit?usp=sharing
    static string LINE_SPLIT = @"\r\n|\n\r|\n|\r\t";

    private Test t = new Test();

    // IEnumerator 란?
    private IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(URL);

        // 신호를 받아옴
        yield return www.SendWebRequest();

        // 다운받음
        string Data = www.downloadHandler.text;

        // Data내부의 LINE_SPLIT를 제거
        string[] lines = Regex.Split(Data, LINE_SPLIT);

        // 출력
        t.Initialized(lines);
    }
}

// 웹크롤링 -> API를 지원하지 않을때 사용 , C#언어에서는 승인작업을 받지 않아서 매우 쉬움