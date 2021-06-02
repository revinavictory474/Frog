using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Frog
{
    public class SpawnLog : MonoBehaviour
    {
        [SerializeField] private Object _logs;
        [SerializeField] private Transform _spawnPosition;


        void Start()
        {
            StartCoroutine(SpawnLogs());
        }

        private void Repeat()
        {
            StartCoroutine(SpawnLogs());
        }

        private IEnumerator SpawnLogs()
        {
            yield return new WaitForSeconds(Random.Range(2,4));
            Instantiate(_logs, _spawnPosition.position, Quaternion.identity);
            Repeat();
        }
    }
}
