using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource soundPlayer;
    public float exitDelay = 0.3f;    

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        soundPlayer.Play();
        Invoke("Quit", exitDelay);
    }

    void Quit() {
        Application.Quit();
    }
}
