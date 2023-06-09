using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackButton : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("Overlook"); // Replace "MainScene" with the name of your main scene or scene you want to go back to
    }
}
