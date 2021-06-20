using UnityEngine;
using static FrogGame.SpriteLifeChange;
using static FrogGame.Frog;

namespace FrogGame
{
    public class Log : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && frog.isOpenMouth)
            {
                lifeChange.failPoints--;

                Destroy(gameObject);
            }
        }
    }
}
