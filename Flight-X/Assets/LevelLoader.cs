using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public GameObject image1;
    public GameObject image2;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncronously(sceneIndex));
    }

    IEnumerator LoadAsyncronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }

    public void ChangeImage(int sceneIndex)
    {
        if(sceneIndex == 1 || sceneIndex == 3)
        {
            image1.SetActive(true);
            image2.SetActive(false);
        }
        else
        {
            image1.SetActive(false);
            image2.SetActive(true);
        }
            
    }
}