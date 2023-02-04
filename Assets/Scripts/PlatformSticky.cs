using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSticky : MonoBehaviour
{
  private BoxCollider2D boxCollider;

  private void Start()
  {
    boxCollider = GetComponent<BoxCollider2D>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
      if (collision.gameObject.name == "Player")
      {
        collision.gameObject.transform.SetParent(transform);
      }
  }

  private void EnableBoxCollider()
  {
      boxCollider.enabled = true;
  }

  private void OnCollisionStay2D(Collision2D collision)
  {
    if (Input.GetKeyDown(KeyCode.LeftShift))
    {
      collision.gameObject.transform.SetParent(null);
      boxCollider.enabled = false;
      Invoke("EnableBoxCollider", 0.5f);
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
      if (collision.gameObject.name == "Player")
      {
          collision.gameObject.transform.SetParent(null);
          //boxCollider.enabled = true;
      }
  }

}
