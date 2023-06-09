using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string[] scenesToLoad = { "Camera1View", "Camera2View", "Camera3View", "Camera4View" };

    private void Start()
    {
        // Load additional scenes additively
        foreach (string sceneName in scenesToLoad)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }
    }
}
