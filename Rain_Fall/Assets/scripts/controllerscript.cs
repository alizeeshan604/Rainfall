using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerscript : MonoBehaviour
{
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.SetActive(true);
    }

    public void LoadMainGame()
    {
        
        StartButton.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }
}
