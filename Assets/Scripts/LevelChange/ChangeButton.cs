using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButton : MonoBehaviour
{
    [SerializeField]
    private GameObject firstGame;

    [SerializeField]
    private GameObject secondGame;

    private void Awake()
    {
        firstGame.SetActive(false);
        secondGame.SetActive(false);
    }

    public void FirstScene()
    {
        firstGame.SetActive(true);
    }

    public void SecondScene()
    {
        secondGame.SetActive(true);
    }
}
