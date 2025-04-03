using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Rigidbody2D rb;
    bool isJumping = false;
    float jumpForce = 5f;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {

        transform.position += moveSpeed * Time.deltaTime * Vector3.right;


        if (isJumping)
        {
            rb.linearVelocity += Vector2.up * jumpForce;
            isJumping = false;
        }
    }
}
