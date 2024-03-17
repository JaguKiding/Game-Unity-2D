using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickScore : MonoBehaviour
{
    public int NilaiScore;
    private Rigidbody2D rb;
    public Text TxtScore;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        TxtScore.text = NilaiScore + " ";
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi")){
            NilaiScore++;
            TxtScore.text = NilaiScore + " ";
        }
    }
}
