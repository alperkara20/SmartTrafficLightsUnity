using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadOverlookScene()
    {
        SceneManager.LoadScene("Overlook");
    }

    public void LoadCamera1ViewScene()
    {
        SceneManager.LoadScene("Camera1View");
    }

    public void LoadCamera2ViewScene()
    {
        SceneManager.LoadScene("Camera2View");
    }

    public void LoadCamera3ViewScene()
    {
        SceneManager.LoadScene("Camera3View");
    }

    public void LoadCamera4ViewScene()
    {
        SceneManager.LoadScene("Camera4View");
    }
}
