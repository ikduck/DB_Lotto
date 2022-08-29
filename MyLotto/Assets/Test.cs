using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class MyUI
{
    public Text[] str = new Text[7];
}

// Parsing - 구문 분석
public class Test : MonoBehaviour
{
    // public List<Text>[] Numbers = new List<Text>[1030];
    public List<MyUI> Numbers = new List<MyUI>();
    public void Initialized(string[] _lines)
    {
        (new GameObject("NumberList")).transform.parent = GameObject.Find("Canvas").transform;

        for (int i =0; i < _lines.Length; ++i)
        {
            //_lines[i] 에 @"' '|\t" 가 있으면 삭제
            string[] lines = Regex.Split(_lines[i], @"' '|\t");

            GameObject obj = new GameObject((i + 1).ToString());
            obj.transform.parent = GameObject.Find("NumberList").transform;

            /*
            for (int j = 0; j < 7; ++j)
            {
                GameObject go = new GameObject();                
                go.transform.parent = GameObject.Find((i + 1).ToString()).transform;

                go.AddComponent<Text>();
                Text t = go.GetComponent<Text>();

                t.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
                t.fontSize = 500;
                t.rectTransform.sizeDelta = new Vector2(300.0f, 570.0f);
                t.text = lines[j].ToString();

            }
            */

            Debug.Log(
                lines[0] + ", " +
                lines[1] + ", " +
                lines[2] + ", " +
                lines[3] + ", " +
                lines[4] + ", " +
                lines[5] + " + " +
                lines[6]);

            // 통계학 , 과거의 통계로 미래를 예측할수 없다.
            // 많이나온 숫자는 나올 확률이 적다.
        }
    }

    // RectTransfrom

    void Start()
    {
        // 글자 크기 바꾸기
        // tString.text = "10";
        // 포지션 조정하기
        // tString.rectTransform.anchoredPosition = new Vector3(0, 0);
    }

    void Update()
    {
        
    }
}
