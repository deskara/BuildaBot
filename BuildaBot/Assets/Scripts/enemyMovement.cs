using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    Rigidbody2D characterBody;
    public int enemySpeed;
    public string startingDirection = "left";
    bool touchedLeft = false, touchedRight = false,touchedUp = false,touchedDown = false;
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
        else if (collision.gameObject.tag == "upPointer")
        {
            characterBody.velocity = new Vector2(0, 0);
            touchedUp = true;
            touchedDown = false;
            startingDirection = "";

        }
        else if (collision.gameObject.tag == "downPointer")
        {
            characterBody.velocity = new Vector2(0, 0);
            touchedUp = false;
            touchedDown = true;
            startingDirection = "";

        }

    }

    // Update is called once per frame
    void Update()
    {
        if(touchedLeft == true || startingDirection == "left")
        {
            characterBody.velocity = new Vector2(-enemySpeed, characterBody.velocity.y);


        }
        else if(touchedRight == true || startingDirection == "right")
        {
            characterBody.velocity = new Vector2(enemySpeed, characterBody.velocity.y);

        }
        if (touchedUp == true || startingDirection == "up")
        {
            characterBody.velocity = new Vector2(characterBody.velocity.x,enemySpeed);
        }
        else if(touchedDown == true || startingDirection == "down")
        {
            characterBody.velocity = new Vector2(characterBody.velocity.x, -enemySpeed);
        }
    }
}
