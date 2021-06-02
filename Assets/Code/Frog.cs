using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Frog
{
    public class Frog : MonoBehaviour
    {
        [SerializeField] private GameObject _mouthClose;
        [SerializeField] private GameObject _mouthOpen;
        [SerializeField] private GameObject _maggotBounce;
        [SerializeField] private GameObject _logBounce;
        [SerializeField] private GameObject _death;

        public bool isDeath;
        private bool isCollision;
        private bool isClicked;

        void Update()
        {
            ClickFrog();
            Death();
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (!isDeath)
            {
                if (collision.CompareTag("Log"))
                {
                    isCollision = true;
                    isDeath = false;
                    _logBounce.SetActive(true);
                    _maggotBounce.SetActive(false);
                    _mouthClose.SetActive(false);
                    _mouthOpen.SetActive(false);
                    _death.SetActive(false);
                    Debug.Log("LOG");
                }
                else if (collision.CompareTag("Maggot"))
                {
                    isCollision = true;
                    isDeath = false;
                    _maggotBounce.SetActive(true);
                    _logBounce.SetActive(false);
                    _mouthClose.SetActive(false);
                    _mouthOpen.SetActive(false);
                    _death.SetActive(false);
                    Debug.Log("MAGGOT");
                }
                else
                {
                    isDeath = false;
                    _mouthClose.SetActive(true);
                }
                //StartCoroutine(ChangingSprites());
            }
        }

        //private IEnumerator ChangingSprites()
        //{
        //    if (isCollision)
        //    {
        //        _mouthClose.SetActive(true);
        //        _maggotBounce.SetActive(false);
        //        _logBounce.SetActive(false);
        //        _mouthOpen.SetActive(false);
        //        _death.SetActive(false);
        //    }
        //    else
        //    {
        //        _mouthClose.SetActive(true);
        //        _maggotBounce.SetActive(false);
        //        _logBounce.SetActive(false);
        //        _mouthOpen.SetActive(false);
        //        _death.SetActive(false);
        //    }
        //    yield return new WaitForSeconds(1);
        //}


        private void ClickFrog()
        {
            if (!isDeath)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    isClicked = true;
                    isDeath = false;
                    _mouthOpen.SetActive(true);
                    _mouthClose.SetActive(false);
                    _death.SetActive(false);
                    _maggotBounce.SetActive(false);
                    _logBounce.SetActive(false);
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    isClicked = false;
                    isDeath = false;
                    _mouthClose.SetActive(true);
                    _mouthOpen.SetActive(false);
                    _death.SetActive(false);
                    _maggotBounce.SetActive(false);
                    _logBounce.SetActive(false);
                }
            }
        }

        private void Death()
        {
            if (isDeath)
            {
                isDeath = true;
                _death.SetActive(true);
                _mouthClose.SetActive(false);
                _mouthOpen.SetActive(false);
                _maggotBounce.SetActive(false);
                _logBounce.SetActive(false);
            }
        }

    }
}