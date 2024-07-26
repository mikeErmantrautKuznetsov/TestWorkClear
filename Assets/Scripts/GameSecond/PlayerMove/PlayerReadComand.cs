using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReadComand : MonoBehaviour, IControllable
{
    private CharacterController characterController;
    private float speedPlayer = 10f;
    [SerializeField]
    private Animator animator;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    public void movePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal
            + transform.forward * vertical;

        characterController.Move(move * speedPlayer * Time.deltaTime);
    }

    public void checkAnimation()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("runPlayer", true);
            animator.SetBool("idlePlayer", false);
        }
        else
        {
            animator.SetBool("runPlayer", false);
            animator.SetBool("idlePlayer", true);
        }
    }
}
