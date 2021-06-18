using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.SpriteLifeChange;
using static FrogGame.FrogTriggerZone;
using static FrogGame.Frog;

namespace FrogGame
{
    public class Log : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && frogue.isOpenMouth)
            {
                lifeChange.failPoints--;
                Debug.Log("EAT LOG trigger");
                frogTriggerZone._countFail++;

                Destroy(gameObject);
            }
        }
    }
}
