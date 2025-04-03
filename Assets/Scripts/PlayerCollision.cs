using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.OnGameOver();
    }
}
