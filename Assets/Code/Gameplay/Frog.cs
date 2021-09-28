using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.SpriteFrogChange;

namespace FrogGame
{
    public class Frog : MonoBehaviour
    {
        internal static Frog frog;

        [SerializeField] internal GameObject _mouthClose;
        [SerializeField] internal GameObject _mouthOpen;
        [SerializeField] internal GameObject _maggotBounce;
        [SerializeField] internal GameObject _logBounce;
        [SerializeField] internal GameObject _death;

        private bool isClicked;
        internal bool isDeath;
        internal bool isCollision;
        internal bool isOpenMouth;

        private void Awake()
        {
            if (frog == null)
                frog = this;
            else
                Destroy(gameObject);

        }

        void Update()
        {
            ClickFrog();    
            spriteFrog.SpriteDeath();
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
                    spriteFrog.SpriteOpenMouth();
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    isClicked = false;
                    isDeath = false;
                    isOpenMouth = false;
                    spriteFrog.SpriteCloseMouth();
                }
            }
        }

        
    }
}