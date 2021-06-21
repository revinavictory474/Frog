using UnityEngine;
using static FrogGame.SpriteLifeChange;
using static FrogGame.Frog;

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
            frog.isDeath = true;
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
