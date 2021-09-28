using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace FrogGame
{
    public class StartGame : MonoBehaviour
    {
        public void GameStartGame(string name)
        {
            SceneManager.LoadScene(name);
        }
    }
}