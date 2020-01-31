using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    GameObject player;
    Rigidbody2D characterBody;


    void Start()
    {
        characterBody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("space")){
            Vector2 jumpVector;
            jumpVector = new Vector2(0, 250);
            characterBody.AddForce(jumpVector);
        }

        if (Input.GetKey("left"))
        {
            Vector2 leftVector;
            leftVector = new Vector2(-10, 0);
            characterBody.AddForce(leftVector);

        }

        if (Input.GetKey("right"))
        {
            Vector2 rightVector;
            rightVector = new Vector2(10, 0);
            characterBody.AddForce(rightVector);

        }


    }
}
