using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class pauseMenu : MonoBehaviour
{
    bool isPaused = false;
    public UnityEvent pauseGame, unPauseGame;

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if(isPaused == false)
            {
                pauseGame.Invoke();
            }
            else
            {
                unPauseGame.Invoke();
            }
        }
    }
}
