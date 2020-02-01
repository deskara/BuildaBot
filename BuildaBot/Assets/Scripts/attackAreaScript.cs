using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackAreaScript : MonoBehaviour
{

    private GameObject Player;
    bool isFlipped = false;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlipped == false)
        {
            Vector2 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
            Vector3 newPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
            transform.position = newPosition;

        }
        else
        {
            Vector2 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
            Vector3 newPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
            transform.position = newPosition;

        }

    }

    public void leftFlip()
    {
        isFlipped = true;

    }
    public void rightFlip()
    {
        isFlipped = false;
    }
}
