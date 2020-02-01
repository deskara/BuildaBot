using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class footBoxScript : MonoBehaviour
{
    public UnityEvent Grounded,Ungrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Grounded.Invoke();


        }
        else if (collision.gameObject.tag == "conveyerLeft")
        {
            Grounded.Invoke();
        }
        else if (collision.gameObject.tag == "conveyerRight")
        {
            Grounded.Invoke();
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Grounded.Invoke();


        }
        else if (collision.gameObject.tag == "conveyerLeft")
        {
            Grounded.Invoke();
        }
        else if (collision.gameObject.tag == "conveyerRight")
        {
            Grounded.Invoke();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Ungrounded.Invoke();


        }
        else if (collision.gameObject.tag == "conveyerLeft")
        {
            Ungrounded.Invoke();
        }
        else if (collision.gameObject.tag == "conveyerRight")
        {
            Ungrounded.Invoke();
        }

    }
}
