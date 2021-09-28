using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FrogGame.SpriteLifeChange;

public class DestroyAll : MonoBehaviour
{
    private BoxCollider2D _boundareCollider;
    private Vector2 _viewportSize;

    private void Awake()
    {
        _boundareCollider = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        ResizeCollider();
    }

    private void ResizeCollider()
    {
        _viewportSize = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)) * 2;
        _viewportSize.x *= 1.5f;
        _viewportSize.y *= 1.5f;
        _boundareCollider.size = _viewportSize;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Maggot":
                Destroy(collision.gameObject);
                break;
            case "Log":
                Destroy(collision.gameObject);
                break;
        }
    }

}
