using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerScript : MonoBehaviour
{

  private bool hasFlower = false;

  private void OnTriggerStay2D(Collider2D collider)
  {
    if (Input.GetKeyDown(KeyCode.Return) && collider.gameObject.name == "Player")
    {
      hasFlower = true;
      gameObject.SetActive(false);
    }
  }

}
