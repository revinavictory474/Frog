using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static FrogGame.Frog;
using static FrogGame.SpriteFrogChange;

namespace FrogGame
{
    public class FrogTriggerZone : MonoBehaviour
    {
        internal static FrogTriggerZone frogTriggerZone;

        internal int _countHits;

        private void Awake()
        {
            if (frogTriggerZone == null)
                frogTriggerZone = this;
            else Destroy(gameObject);
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (!frog.isDeath)
            {
                if (collision.CompareTag("Log"))
                {
                    frog.isCollision = true;
                    frog.isDeath = false;
                    spriteFrog.SpriteLogBounce();

                    if (frog.isOpenMouth)
                    {
                        spriteFrog.SpriteOpenMouth();
                    }
                }
                else if (collision.CompareTag("Maggot"))
                {
                    frog.isCollision = true;
                    frog.isDeath = false;
                    spriteFrog.SpriteMaggotBounce();

                    if (frog.isOpenMouth)
                    {
                        spriteFrog.SpriteOpenMouth();
                    }

                }
                else
                {
                    frog.isDeath = false;
                    frog._mouthClose.SetActive(true);
                }
                StartCoroutine(ChangingSprites());
            }
        }

        private IEnumerator ChangingSprites()
        {
            yield return new WaitForSeconds(0.5f);

            if (frog.isCollision)
            {
                spriteFrog.SpriteCloseMouth();
            }
            else
            {
                spriteFrog.SpriteCloseMouth();
            }
        }
    }
}