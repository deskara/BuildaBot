using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    GameObject player;
    GameObject Camera;
    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        Camera.transform.position = newPosition;
        
    }
}
