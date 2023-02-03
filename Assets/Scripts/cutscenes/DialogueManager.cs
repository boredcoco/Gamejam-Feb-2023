using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    [SerializeField] private GameObject[] dialogues;
    private int index = 0;

    private void setActiveDialogue()
    {
      if (index > dialogues.Length - 1)
      {
        gameObject.SetActive(false);
        return;
      }
      dialogues[index].SetActive(true);
      if (index > 0)
      {
        dialogues[index - 1].SetActive(false);
      }
      index++;
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Return))
      {
        if (index > dialogues.Length - 1)
        {
          gameObject.SetActive(false);
        }
        Invoke("setActiveDialogue", 1f);
      }
    }
}
