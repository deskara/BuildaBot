using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    Rigidbody2D characterBody;
    public string startingDirection = "left";
    bool touchedLeft = false;
    bool touchedRight = false;
    // Start is called before the first frame update
    void Start()
    {
        characterBody = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "leftPointer")
        {
            characterBody.velocity = new Vector2(0, 0);
            touchedLeft = true;
            touchedRight = false;
            startingDirection = "";
        }
        else if(collision.gameObject.tag == "rightPointer")
        {
            characterBody.velocity = new Vector2(0, 0);
            touchedLeft = false;
            touchedRight = true;
            startingDirection = "";

        }

    }

    // Update is called once per frame
    void Update()
    {
        if(touchedLeft == true || startingDirection == "left")
        {
            //Vector2 leftVector;
            //leftVector = new Vector2(-3, 0);
            //characterBody.AddForce(leftVector);
            characterBody.velocity = new Vector2(-3, 0);


        }
        else if(touchedRight == true || startingDirection == "right")
        {
            //Vector2 rightVector;
            //rightVector = new Vector2(3, 0);
            //characterBody.AddForce(rightVector);
            characterBody.velocity = new Vector2(3, 0);

        }
    }
}
