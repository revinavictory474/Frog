using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogAndMaggot : MonoBehaviour
{
    public GameObject[] logAndMaggot;
    public float timeBonusSpawn;
    public Vector2 pointToSpawn;
    private List<GameObject> logAndMaggotList = new List<GameObject>();


    private void Start()
    {
        StartCoroutine(LogAndMaggotSpawn()); 
    }

    private IEnumerator LogAndMaggotSpawn()
    {
        for(int i =0; i < logAndMaggot.Length; i++)
        {
            logAndMaggotList.Add(logAndMaggot[i]);
        }
        yield return new WaitForSeconds(2);


        while(true)
        {
            int random = Random.Range(0, logAndMaggotList.Count);

            GameObject newObject = Instantiate(logAndMaggotList[random], pointToSpawn, Quaternion.Euler(0, 0, Random.Range(-25, 25)));

            logAndMaggotList.RemoveAt(random);

            if(logAndMaggotList.Count==0)
            {
                for (int i = 0; i < logAndMaggot.Length; i++)
                {
                    logAndMaggotList.Add(logAndMaggot[i]);
                }
            }

            yield return new WaitForSeconds(timeBonusSpawn);
        }
    }
}
