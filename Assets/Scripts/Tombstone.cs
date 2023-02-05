using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tombstone : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (!panel.activeSelf)
      {
        panel.SetActive(true);
      }
    }
}
