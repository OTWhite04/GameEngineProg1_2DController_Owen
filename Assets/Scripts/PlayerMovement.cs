using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
   
    public Vector2 moveDirection = new Vector2(0.00f, 1.00f);

    public float moveSpeed = 2.0f;

    void Awake()
    {
        Actions.MoveEvent += HandlePlayerMovement;
    }

    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandlePlayerMovement(Vector2 moveDirection)
    {
        characterController.Move(moveDirection * Time.deltaTime);
    }

    void OnDisable()
    {
        Actions.MoveEvent -= HandlePlayerMovement;
    }
}
