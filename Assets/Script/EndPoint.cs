using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    public AudioSource SfxEnd;
    public GameObject PanelEnd;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SfxEnd.Play();
            PanelEnd.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
