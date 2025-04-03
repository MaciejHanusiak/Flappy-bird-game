using System;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<DeadlyObject>(out DeadlyObject deadlyObj))
        {
            Debug.Log("GameOver");
        }
    }
}
