using UnityEngine;
using static FrogGame.FrogTriggerZone;
using static FrogGame.Frog;

namespace FrogGame
{
    public class Maggot : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && frog.isOpenMouth)
            {
                frogTriggerZone._countHits++;

                Destroy(gameObject);
            }
        }
    }
}