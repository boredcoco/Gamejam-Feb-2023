using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tombstone : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void OnCollisionStay2D(Collision2D collision)
    {
      if (Input.GetKeyDown(KeyCode.Return))
      {
        panel.SetActive(true);
      }
    }
}
