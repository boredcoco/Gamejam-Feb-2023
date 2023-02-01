using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject vLowerBound;
    [SerializeField] private GameObject vUpperBound;

    [SerializeField] private GameObject hLowerBound;
    [SerializeField] private GameObject hUpperBound;

    [SerializeField] private float vSpeed = 1f;
    [SerializeField] private float hSpeed = 1f;

    private void Update()
    {
      if (transform.position.y < vLowerBound.transform.position.y) {
        vSpeed = Mathf.Abs(vSpeed);
      } else if (transform.position.y > vUpperBound.transform.position.y) {
        vSpeed = -1 * Mathf.Abs(vSpeed);
      }

      if (transform.position.x < hLowerBound.transform.position.x) {
        hSpeed = Mathf.Abs(hSpeed);
      } else if (transform.position.y > hUpperBound.transform.position.x) {
        hSpeed = -1 * Mathf.Abs(hSpeed);
      }
      float xSpeed = Time.deltaTime * hSpeed;
      float ySpeed = Time.deltaTime * vSpeed;
      transform.position = new Vector3(transform.position.x +  xSpeed, transform.position.y + ySpeed, transform.position.z);
    }

}
