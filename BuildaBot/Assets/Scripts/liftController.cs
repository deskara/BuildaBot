using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftController : MonoBehaviour
{
    public GameObject button;
    Rigidbody2D liftBody;
    public int liftSpeed;
    public string startingDirection = "up";
    bool buttonPressed = false;
    bool touchedUp = false, touchedDown = false;
    // Start is called before the first frame update
    void Start()
    {
        liftBody = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "upPointer")
        {
            liftBody.velocity = new Vector2(0, 0);
            touchedUp = true;
            touchedDown = false;
            startingDirection = "";

        }
        else if (collision.gameObject.tag == "downPointer")
        {
            liftBody.velocity = new Vector2(0, 0);
            touchedUp = false;
            touchedDown = true;
            startingDirection = "";

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed == true && (touchedUp == true || startingDirection == "up"))
        {
            liftBody.velocity = new Vector2(liftBody.velocity.x, liftSpeed);
        }
        else if ((touchedDown == true || startingDirection == "down") && buttonPressed == true)
        {
            liftBody.velocity = new Vector2(liftBody.velocity.x, -liftSpeed);
        }
    }

    public void setButtonPressed()
    {
        buttonPressed = true;
        AudioSource buttonAudio = button.GetComponent<AudioSource>();
        buttonAudio.Play();
    }
}
