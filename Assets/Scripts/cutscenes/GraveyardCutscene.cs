using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GraveyardCutscene : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject rawImage;
    [SerializeField] private GameObject videoPlayer;

    private TMP_Text textDisplayed;
    private string originalText;

    private void Start()
    {
        textDisplayed = GetComponent<TMP_Text>();
        originalText = textDisplayed.text;
    }

    private void PlayVideo()
    {
      rawImage.SetActive(true);
      videoPlayer.SetActive(true);
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Return))
      {
        Invoke("PlayVideo", 5f);
      }
    }
}
