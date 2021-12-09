using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    @PlayerController controls;
    Vector2 move;
    Vector3 movement;
    public float speed = 10;

    // Pulling in the controls from the Player Input
    void Awake()
    {
        controls = new @PlayerController();
        //controls.Player.Move.performed += ctx =>
                                    //SendMessage(ctx.ReadValue<Vector2>());
        controls.Player.Move.performed += ctx => move =
                                    ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    // Setting up movement
    void FixedUpdate()
    {
        movement = new Vector3(move.x, 0.0f, move.y) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    // Setting up the player to be able to rotate in the direction they're moving
    void Update()
    {

        if (movement.x != 0 || movement.z != 0)
        {
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(movement.x, 0, movement.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
        
    }
}
