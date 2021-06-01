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

        void Start()
        {

        }

        void Update()
        {
            ClickFrog();
            Death();

        }

        private void ClickFrog()
        {
            if (Input.GetMouseButton(0))
            {
                _mouthClose.SetActive(false);
                _mouthOpen.SetActive(true);
            }
            else
            {
                _mouthClose.SetActive(true);
                _mouthOpen.SetActive(false);
            }
        }

        private void Death()
        {
            if (isDeath)
            {
                _mouthClose.SetActive(false);
                _mouthOpen.SetActive(false);
                _death.SetActive(true);
            }
        }
    }
}