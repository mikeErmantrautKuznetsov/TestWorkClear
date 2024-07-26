using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    private IControllable playerControlleb;

    private void Start()
    {
        playerControlleb = GetComponent<IControllable>();
    }

    void Update()
    {
        playerControlleb.movePlayer();
        playerControlleb.checkAnimation();
    }
}
