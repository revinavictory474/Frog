using UnityEngine;
using static FrogGame.SpriteLifeChange;

public class MissMaggot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Maggot")
        {
            lifeChange.failPoints--;
        }
    }
}
