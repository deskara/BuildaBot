using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    GameObject player;
    Rigidbody2D characterBody;
    Vector2 jumpVector;

    void Start()
    {
        characterBody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        jumpVector = new Vector2(0, 500);
        if (Input.GetKeyDown("space")){
            characterBody.AddForce(jumpVector);
        }

        if (Input.GetKeyDown("left"))
        {

        }
    }
}
