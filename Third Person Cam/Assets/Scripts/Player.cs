using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("References")]
    private CharacterController controller;

    [Header("Movment Settings")]
    [SerializeField] private float moveSpeed = 5f;

    [Header("Inputs")]
    private float moveInput;   
    private float turnInput;

    private void Start()
    {
        controller = GetComponent<CharacterController>();   
    }

    private void Update()
    {
        InputManagement();
        Move();
    }

    private void Move()
    {
        GroundMovemnt();
    }

    public void GroundMovemnt()
    {
        Vector3 move = new Vector3(turnInput, 0, moveSpeed);

        move.y = 0;

        move *= moveSpeed;
        controller.Move(move * Time.deltaTime);
    }

    public void InputManagement()
    {
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
    }
}