using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Frog
{
    public class SpawnMaggot : MonoBehaviour
    {
        [SerializeField] private Object _maggot;
        [SerializeField] private Transform _spawnPosition;


        void Start()
        {
            StartCoroutine(SpawnMaggots());
        }

        private void Repeat ()
        {
            StartCoroutine(SpawnMaggots());
        }

        private IEnumerator SpawnMaggots()
        {
            yield return new WaitForSeconds(Random.Range(1,3));
            Instantiate(_maggot, _spawnPosition.position, Quaternion.identity);
            Repeat();
        }
        
    }
}
