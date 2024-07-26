using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventGame : MonoBehaviour
{
    [SerializeField]
    private GameObject winScene;

    private void Start()
    {
        winScene.SetActive(false);
    }

    private void OnEnable()
    {
        EventBus.playerFinish += PlayerWin;
    }

    private void OnDisable()
    {
        EventBus.playerFinish -= PlayerWin;
    }

    private void PlayerWin()
    {
        Debug.Log("You win!");
        winScene.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
            EventBus.playerFinish?.Invoke();
            PlayerWin();
    }
}
