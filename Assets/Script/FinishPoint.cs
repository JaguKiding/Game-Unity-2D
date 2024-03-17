using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public AudioSource Win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneController.instance.NextLevel();
            Win.Play();
        }
    }
}
