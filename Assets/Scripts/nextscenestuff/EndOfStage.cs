using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfStage : MonoBehaviour
{
    [SerializeField] private int nextScene = 1;

    private void Update()
    {
        if (GameObject.Find("Player") != null)
        {
          GameObject player = GameObject.Find("Player");
          if (player.transform.position.x > transform.position.x)
          {
            SceneManager.LoadScene(nextScene);
          }
        }
    }
}
