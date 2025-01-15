using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, PlayerController.IPlayerActions
{

    private PlayerController playerController;

    void Awake()
    {
        playerController = new PlayerController();

        playerController.Player.Enable();

        playerController.Player.SetCallbacks(this);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Receiving move input : " + context.ReadValue<Vector2>());
            Actions.MoveEvent?.Invoke(context.ReadValue<Vector2>());
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    
}
public class Actions
{
    public static Action<Vector2> MoveEvent;
}
