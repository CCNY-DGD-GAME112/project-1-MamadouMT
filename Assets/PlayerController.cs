using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ public float speed;
    public Rigidbody2D RB;

    void Update()
    {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0, 0);

        //Then we use if statement to figure out what that variable should look like

        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = speed;
        }


//If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -speed;
        }

//If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = speed;
        }

//If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -speed;
        }

//Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;

        

    }
}







 //
  //  private float _horizontalInput, _verticalInput;
 //   private float _speed;      
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 //   void Start(){
    //rb =GetComponent<Rigidbody2D>();
    

    // Update is called once per frame
 //   void Update()
    

  //      _horizontalInput = Input.GetAxis("Horizontal");
   //     _verticalInput = Input.GetAxis("Vertical");

    

   // private void FixedUpdate()
    
    //    Vector2 movement = new Vector2(_horizontalInput, 0);
   //     rb.MovePosition(rb.position + movement * _speed * Time.fixedDeltaTime);
    



