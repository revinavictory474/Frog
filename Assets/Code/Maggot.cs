using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrogGame
{
    public class Maggot : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("EAT MAGGOT trigger");
                Destroy(gameObject);
            }
        }
    }
}