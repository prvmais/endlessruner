using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject groundChecker;
    public LayerMask whatIsGround;
    
   float maxSpeed = 5.0f;


    bool isOnGround = false;
    
    // Start is called before the first frame update
    Rigidbody2D playerObject;

    void Start()
    {    //Create a 'float' that will be equal to the players horizontal input
        float movementValueX = Input.GetAxis("Horizontal");

        playerObject = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal");

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        playerObject.velocity = new Vector2 (movementValueX, playerObject.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {

            Jump();
        }
    }
    void Jump()
    {
      
        playerObject.AddForce(new Vector2(0.0f, 320.0f));

    }
}
    