using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrogGame
{
    public class SpriteLifeChange : MonoBehaviour
    {
        [SerializeField] internal GameObject[] accessibleLife;
        public static SpriteLifeChange lifeChange;
        public int logsEat;
        public int failPoints = 3;

        private void Awake()
        {
            if (lifeChange == null)
                lifeChange = this;
            else Destroy(gameObject);
        }

        void Update()
        {

            if (failPoints >= 3 )
            {
                accessibleLife[0].SetActive(true);
                accessibleLife[1].SetActive(true);
                accessibleLife[2].SetActive(true);
            }
            else if (failPoints >= 2 && failPoints < 3)
            {
                accessibleLife[2].SetActive(false);
            }
            else if (failPoints >= 1 && failPoints < 2)
            {
                accessibleLife[1].SetActive(false);
            }
            if (failPoints < 1)
            {
                accessibleLife[0].SetActive(false);
            }

            Debug.Log("currentlogeat" + failPoints);
        }
    }
}
