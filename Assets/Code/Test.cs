using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.SpriteLifeChange;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Maggot")
        {
            lifeChange.failPoints--;
        }
    }
}