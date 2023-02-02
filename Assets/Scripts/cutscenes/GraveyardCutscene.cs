using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GraveyardCutscene : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private TMP_Text textDisplayed;
    private string originalText;
    private bool hasFlower = true;
    private bool hasLaidFlower = false;

    private void Start()
    {
        textDisplayed = GetComponent<TMP_Text>();
        originalText = textDisplayed.text;
    }

    private void ChangeText(string text)
    {
      textDisplayed.text = text;
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Return))
      {
        if (hasFlower && !hasLaidFlower)
        {
          ChangeText("Lay flower?");
          hasLaidFlower = true;
        } else if (hasLaidFlower && hasLaidFlower)
        {
          SceneManager.LoadScene(0);
        } else {
          ChangeText(originalText);
          //panel.SetActive(false);
        }
      }
    }

    public void pickUpFlower() {
      hasFlower = true;
    }
}
