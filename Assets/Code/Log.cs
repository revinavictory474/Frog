using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrogGame
{
    public class Log : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && Frog.frogue.isOpenMouth)
            {
                Debug.Log("EAT LOG trigger");
                FrogTriggerZone.frogTriggerZone._countFail++;
                Destroy(gameObject);
            }
        }
    }
}
