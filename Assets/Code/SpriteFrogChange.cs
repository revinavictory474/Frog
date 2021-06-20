using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.Frog;

namespace FrogGame
{
    public class SpriteFrogChange : MonoBehaviour
    {
        internal static SpriteFrogChange spriteFrog;

        private void Awake()
        {
            if (spriteFrog == null)
                spriteFrog = this;
            else
                Destroy(gameObject);
        }

        internal void SpriteDeath()
        {
            if (frog.isDeath)
            {
                frog.isDeath = true;
                frog.isOpenMouth = false;
                frog._death.SetActive(true);
                frog._mouthClose.SetActive(false);
                frog._mouthOpen.SetActive(false);
                frog._maggotBounce.SetActive(false);
                frog._logBounce.SetActive(false);
            }
        }

        internal void SpriteCloseMouth()
        {
            frog.isOpenMouth = false;
            frog._mouthClose.SetActive(true);
            frog._maggotBounce.SetActive(false);
            frog._logBounce.SetActive(false);
            frog._mouthOpen.SetActive(false);
            frog._death.SetActive(false);
        }

        internal void SpriteOpenMouth()
        {
            frog._mouthOpen.SetActive(true);
            frog._mouthClose.SetActive(false);
            frog._maggotBounce.SetActive(false);
            frog._logBounce.SetActive(false);
            frog._death.SetActive(false);
        }

        internal void SpriteLogBounce()
        {
            frog._logBounce.SetActive(true);
            frog._maggotBounce.SetActive(false);
            frog._mouthClose.SetActive(false);
            frog._mouthOpen.SetActive(false);
            frog._death.SetActive(false);
        }

        internal void SpriteMaggotBounce()
        {
            frog._maggotBounce.SetActive(true);
            frog._logBounce.SetActive(false);
            frog._mouthClose.SetActive(false);
            frog._mouthOpen.SetActive(false);
            frog._death.SetActive(false);
        }
    }
}
