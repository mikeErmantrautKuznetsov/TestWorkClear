using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerBest : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_TextMeshProUGUI;
    private float m_Time;
    private float bestTimeResult;
    [SerializeField]
    TextMeshProUGUI bestTimeResultShow;

    void Update()
    {
        timerVoidCalculated();
    }

    private void timerVoidCalculated()
    {
        m_Time += Time.deltaTime;
        int minuts = Mathf.FloorToInt(m_Time / 60);
        int seconds = Mathf.FloorToInt(m_Time % 60);
        m_TextMeshProUGUI.text = string.Format("{0:00}:{1:00}", minuts, seconds);

        bestTimeResult = m_Time;

        if (PlayerPrefs.GetFloat("m_Time") <= bestTimeResult)
        {
            PlayerPrefs.SetFloat("m_Time", bestTimeResult);
        }
        bestTimeResultShow.text = "bestTime: " + PlayerPrefs.GetFloat("m_Time").ToString();
    }

    public void clearTime()
    {
        PlayerPrefs.DeleteKey("m_Time");
        bestTimeResult = 0f;
        m_Time = 0f;
    }
}
