using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrogGame
{
    public class Maggot : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && Frog.frogue.isOpenMouth)
            {
                Debug.Log("EAT MAGGOT trigger");
                FrogTriggerZone.frogTriggerZone._countHits++;
                Destroy(gameObject);
            }
        }
    }
}