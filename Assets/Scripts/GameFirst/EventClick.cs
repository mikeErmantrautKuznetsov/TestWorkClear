using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class EventClick : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countClick;
    [SerializeField]
    private TextMeshProUGUI countHigh;
    private int count;
    private int highCount;

    private void Start()
    {
        countHigh.text = "–екорд: " + PlayerPrefs.GetInt("TimerStart").ToString();
        countClick.text = "—чет: " + highCount.ToString();
    }

    private void OnEnable()
    {
        EventBusClick.cliclButton += AddClicCheck;
    }

    private void OnDisable()
    {
        EventBusClick.cliclButton -= AddClicCheck;
    }

    public void AddClicCheck()
    {
        countClick.text = "—чет: " + count.ToString();
        count++;

        highCount = count;
        countClick.text = "—чет: " + highCount.ToString();

        if (PlayerPrefs.GetInt("TimerStart") <= highCount)
        {
            PlayerPrefs.SetInt("TimerStart", highCount);
        }
        countHigh.text = "–екорд: " + PlayerPrefs.GetInt("TimerStart").ToString();
    }

    public void clearClick()
    {
        highCount = 0;
        count = 0;
        PlayerPrefs.DeleteKey("TimerStart");
    }
}
