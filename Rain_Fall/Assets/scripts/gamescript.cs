using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamescript : MonoBehaviour
{
    public GameObject exitButton;
    // Start is called before the first frame update
    void Start()
    {
        exitButton.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
