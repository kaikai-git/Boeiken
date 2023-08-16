
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class TimeCounter : MonoBehaviour
{
    //カウントダウン
    public float countdown = 25.0f;

    //時間を表示するText型の変数
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "s to escape mode";

        //countdownが0以下になったときz
        if (countdown <= 0)
        {
            timeText.text = "Escape Mode";
        }
    }
}