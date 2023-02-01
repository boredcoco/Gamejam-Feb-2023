using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

    private void EnableBoxCollider()
    {
        boxCollider.enabled = true;
    }

        private void Update()
    {
        if (transform.GetChild(0).name == "Player" && Input.GetKeyDown(KeyCode.LeftShift))
        {
            boxCollider.enabled = false;
            Invoke("EnableBoxCollider", 0.5f);
        }
    }
    
}
