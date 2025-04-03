using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Rigidbody2D rb;

    float jumpForce = 5f;

    private void Awake() => rb = GetComponent<Rigidbody2D>();
    private void Start()
    {
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump")) Jump();
    }

    void Jump() => rb.linearVelocity += new Vector2(0f, jumpForce);
    

    private void FixedUpdate()
    {

        transform.position += moveSpeed * Time.deltaTime * Vector3.right;


    }
}
