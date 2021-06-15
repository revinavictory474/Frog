using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrogGame
{
    public class Frog : MonoBehaviour
    {
        internal FrogTriggerZone _triggerZone;

        [SerializeField] internal GameObject _mouthClose;
        [SerializeField] internal GameObject _mouthOpen;
        [SerializeField] internal GameObject _maggotBounce;
        [SerializeField] internal GameObject _logBounce;
        [SerializeField] internal GameObject _death;

        public bool isDeath;
        internal bool isCollision;
        internal bool isClicked;
        internal bool isOpenMouth;

        private void Awake()
        {
            _triggerZone = GetComponent<FrogTriggerZone>();
        }
        void Update()
        {
            ClickFrog();
            //Death();
        }
        
        private void ClickFrog()
        {
            if (!isDeath)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    isClicked = true;
                    isDeath = false;
                    isOpenMouth = true;
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
                    isOpenMouth = false;
                    _mouthClose.SetActive(true);
                    _mouthOpen.SetActive(false);
                    _death.SetActive(false);
                    _maggotBounce.SetActive(false);
                    _logBounce.SetActive(false);
                }
            }
        }

        //private void Death()
        //{
        //    if (_triggerZone._countHits >= 3)
        //    {
        //        SpriteDeath();
        //    }
        //}

        private void SpriteDeath()
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