using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject ThisPanorama;
    public GameObject TargetPanorama;

    GameObject ShowText;
    private int x;

    void Start()
    {
        x = 0;
        ShowText = GameObject.Find("AboutBG");
    }


    public void ChangeHotSpot()
    {
        if (TourManager.SetCameraPosition != null)
            TourManager.SetCameraPosition(TargetPanorama.transform.position, ThisPanorama.transform.position);
        TargetPanorama.gameObject.SetActive(true);
        ThisPanorama.gameObject.SetActive(false);
    }

    public void AboutText()
    {
        if (ShowText.activeInHierarchy)
        {
            ShowText.SetActive(false);
            x = 1;
        }
        else
        {
            ShowText.SetActive(true);
            x = 0;
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void GoToAds()
    {
        SceneManager.LoadScene("AdCityScene");
    }
}
