using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.FrogTriggerZone;
using static FrogGame.Frog;

namespace FrogGame
{
    public class Maggot : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && frogue.isOpenMouth)
            {
                Debug.Log("EAT MAGGOT trigger");
                frogTriggerZone._countHits++;
                Destroy(gameObject);
            }
        }
    }
}