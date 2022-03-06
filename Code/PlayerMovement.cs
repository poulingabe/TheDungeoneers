using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 100f;

   public Rigidbody playerRb; 
  
   Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");


    }
    void FixedUpdate()
    {
        //movement
        playerRb.MovePosition((playerRb.position + movement * moveSpeed)); //* Time.fixedDeltaTime);

    }
}
