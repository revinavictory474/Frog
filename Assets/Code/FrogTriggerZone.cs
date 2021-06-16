using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrogGame
{
    public class FrogTriggerZone : MonoBehaviour
    {
        public static FrogTriggerZone frogTriggerZone;

        [SerializeField] private Frog _frog;
        [SerializeField] private Text _score;

        internal int _countFail;
        internal int _countHits;

        private void Awake()
        {
            if (frogTriggerZone == null)
                frogTriggerZone = this;
            else Destroy(gameObject);
        }

        private void Update()
        {
            Debug.Log(_countHits);

            Debug.Log(_countFail);
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (!_frog.isDeath)
            {
                if (collision.CompareTag("Log"))
                {
                    _frog.isCollision = true;
                    _frog.isDeath = false;
                    SpriteLogBounce();

                    if (_frog.isOpenMouth)
                    {
                        Debug.Log("FAIL");
                        SpriteOpenMouth();
                    }
                }
                else if (collision.CompareTag("Maggot"))
                {
                    _frog.isCollision = true;
                    _frog.isDeath = false;
                    SpriteMaggotBounce();

                    if (_frog.isOpenMouth)
                    {
                        Debug.Log("WIN");
                        SpriteOpenMouth();
                    }

                }
                else
                {
                    _frog.isDeath = false;
                    _frog._mouthClose.SetActive(true);
                }
                StartCoroutine(ChangingSprites());
            }
        }

        private IEnumerator ChangingSprites()
        {
            yield return new WaitForSeconds(0.5f);
            if (_frog.isCollision)
            {
                SpriteCloseMouth();
            }
            else
            {
                SpriteCloseMouth();
            }
        }

        private void SpriteCloseMouth()
        {
            _frog.isOpenMouth = false;
            _frog._mouthClose.SetActive(true);
            _frog._maggotBounce.SetActive(false);
            _frog._logBounce.SetActive(false);
            _frog._mouthOpen.SetActive(false);
            _frog._death.SetActive(false);
        }

        private void SpriteOpenMouth()
        {
            _frog._mouthOpen.SetActive(true);
            _frog._mouthClose.SetActive(false);
            _frog._maggotBounce.SetActive(false);
            _frog._logBounce.SetActive(false);
            _frog._death.SetActive(false);
        }

        private void SpriteLogBounce()
        {
            _frog._logBounce.SetActive(true);
            _frog._maggotBounce.SetActive(false);
            _frog._mouthClose.SetActive(false);
            _frog._mouthOpen.SetActive(false);
            _frog._death.SetActive(false);
        }

        private void SpriteMaggotBounce()
        {
            _frog._maggotBounce.SetActive(true);
            _frog._logBounce.SetActive(false);
            _frog._mouthClose.SetActive(false);
            _frog._mouthOpen.SetActive(false);
            _frog._death.SetActive(false);
        }


    }
}