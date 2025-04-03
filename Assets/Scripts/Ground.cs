using System.IO;
using UnityEngine;

public class Ground : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Awake() => spriteRenderer = GetComponent<SpriteRenderer>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MoveForward();
    }
    void MoveForward()
    {
        float width = spriteRenderer.size.x;
        
        transform.localPosition += new Vector3(width * 5, 0f, 0f);
    }
}
