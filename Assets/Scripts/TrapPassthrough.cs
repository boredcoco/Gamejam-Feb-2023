using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPassthrough : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Terrain" || collision.gameObject.name == "Boss")
        {
            boxCollider.enabled = false;
        }
    }

    // private void OnCollisionExit2D(Collision2D collision)
    // {
    //     if (collision.gameObject.name == "Player")
    //     {
    //         collision.gameObject.transform.SetParent(null);
    //     }
    // }
    
}
