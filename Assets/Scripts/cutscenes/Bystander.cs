using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bystander : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
      anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
      Debug.Log(collider.gameObject.name);
      if (collider.gameObject.name == "Car")
      {
        anim.SetTrigger("kill");
      }
    }
}
