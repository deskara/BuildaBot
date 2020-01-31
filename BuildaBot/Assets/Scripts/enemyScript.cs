using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    Rigidbody2D characterBody;
    string conveyerType = "None";
    float terminalVelocity = -100;
    float maxJumpSpeed = 100;
    float maxMoveSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        characterBody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This checks all collisions, if they have the platform tag, the player is set to grounded
        if (collision.gameObject.tag == "Platform")
        {

        }
        else if (collision.gameObject.tag == "conveyerLeft")
        {
            conveyerType = "left";
        }
        else if (collision.gameObject.tag == "conveyerRight")
        {
            conveyerType = "right";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //This checks all collision exits, if they used to have the platform tag then the player is no longer grounded
        if (collision.gameObject.tag == "Platform")
        {
        }
        else if (collision.gameObject.tag == "conveyerLeft")
        {
            conveyerType = "None";
        }
        else if (collision.gameObject.tag == "conveyerRight")
        {
            conveyerType = "None";
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        //The below two functions handle conveyer belts

        if (conveyerType == "left")
        {
            Vector2 leftVector;
            leftVector = new Vector2(-10, 0);
            characterBody.AddForce(leftVector);

        }

        if (conveyerType == "right")
        {
            Vector2 rightVector;
            rightVector = new Vector2(10, 0);
            characterBody.AddForce(rightVector);

        }




        //This one handles capping velocity

        if (characterBody.velocity.y < terminalVelocity)
        {
            characterBody.velocity = new Vector2(characterBody.velocity.x, terminalVelocity);
        }

        if (characterBody.velocity.y > maxJumpSpeed)
        {
            characterBody.velocity = new Vector2(characterBody.velocity.x, maxJumpSpeed);

        }

        if (characterBody.velocity.x < -maxMoveSpeed)
        {
            characterBody.velocity = new Vector2(-maxMoveSpeed, characterBody.velocity.y);

        }

        if (characterBody.velocity.x > maxMoveSpeed)
        {
            characterBody.velocity = new Vector2(maxMoveSpeed, characterBody.velocity.y);

        }

    }

    private void die()
    {
        Destroy(this);

    }
}
