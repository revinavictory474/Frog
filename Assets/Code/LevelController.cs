using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.SpriteLifeChange;

public class LevelController : MonoBehaviour
{
    private bool isPause;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if(lifeChange.failPoints <= 0 && !isPause)
        {
            GamePause();
        }
    }

    public void GamePause()
    {
        if(!isPause)
        {
            isPause = true;
            Time.timeScale = 0;
        }
        else
        {
            isPause = false;
            Time.timeScale = 1;
        }
    }    
}
