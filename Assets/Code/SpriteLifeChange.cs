using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrogGame
{
    public class SpriteLifeChange : MonoBehaviour
    {
        [SerializeField] internal GameObject[] accessibleLife;
        [SerializeField] private GameObject[] notAccessibleLife;
        public static SpriteLifeChange lifeChange;
        public int logsEat;

        private void Awake()
        {
            if (lifeChange == null)
                lifeChange = this;
            else Destroy(gameObject);
        }
        void Update()
        {
            //TODO
            for (int j = 0; j < logsEat; j++)
            {
                for (int i = 0; i < accessibleLife.Length; i++)
                {
                    accessibleLife[i].transform.position = new Vector3(0, 0, 1);
                }
            }
        }
    }
}
