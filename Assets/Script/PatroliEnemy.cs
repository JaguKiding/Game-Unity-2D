using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroliEnemy : MonoBehaviour
{
    private Rigidbody2D rb;

    public float kecepatanGerak;

    public bool berbalik;

    private float rotZ;
    public float RotationSpeed;
    public bool ClockwiseRotation;
    private SpriteRenderer sprite;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (berbalik)
        {
            rb.velocity = new Vector2(kecepatanGerak, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-kecepatanGerak, rb.velocity.y);
        }

        if (ClockwiseRotation == false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * RotationSpeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balik"))
        {
            berbalik = !berbalik;
            anim.SetBool("playGergaji", true);
        }

        else if (collision.gameObject.CompareTag("BalikFlip"))
        {
            berbalik = !berbalik;
            sprite.flipX = true;
        }

        else if (collision.gameObject.CompareTag("BalikFlipFalse"))
        {
            berbalik = !berbalik;
            sprite.flipX = false;
        }
    }
}
