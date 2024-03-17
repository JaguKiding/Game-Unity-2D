using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangga : MonoBehaviour
{
    private float Vertical;
    private float Speed = 8f;
    private bool isLadder;
    private bool isClimbing;
    [SerializeField] private Rigidbody2D rb;
    

    // Update is called once per frame
    void Update()
    {
        Vertical = Input.GetAxis("Vertical");

        if (isLadder && Mathf.Abs(Vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, Vertical * Speed);
        }

        else
        {
            rb.gravityScale = 4f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}
