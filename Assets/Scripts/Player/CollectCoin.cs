using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private int scorePoint = 1;
    private void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        var gameObject = collision.gameObject;

        if (gameObject.CompareTag("Coin"))
        {
            FindAnyObjectByType<ScoreManager>()?.AddScore(scorePoint);
            FindAnyObjectByType<SpeedManager>()?.IncreaseSpeed();

            Destroy(gameObject);
        }
    }
}
