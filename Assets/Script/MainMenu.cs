using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Mulai(string namascene)
    {
        SceneManager.LoadScene(namascene);
        Time.timeScale = 1;
    }
    public void Lanjut(string namascene)
    {
        SceneManager.LoadScene(namascene);
        Time.timeScale = 1;
    }
    public void Menu(string namascene)
    {
        SceneManager.LoadScene(namascene);
        Time.timeScale = 1;
    }
    public void tutupAplikasi()
    {
        Application.Quit();
        Debug.Log("tamat");
    }
}
