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
    //private VideoPlayer vp;

    private void Start()
    {
        textDisplayed = GetComponent<TMP_Text>();
        originalText = textDisplayed.text;
        //vp = videoPlayer.GetComponent<VideoPlayer>();
    }

    private void LoadNext()
    {
      SceneManager.LoadScene(2);
    }

    private void PlayVideo()
    {
      rawImage.SetActive(true);
      videoPlayer.SetActive(true);
      Invoke("LoadNext", 5f);
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Return) && GameObject.Find("Flower") == null)
      {
        Invoke("PlayVideo", 5f);
      }
    }
}
