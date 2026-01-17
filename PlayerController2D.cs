using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 6f;

    private Rigidbody2D rb;
    private Vector2 move;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true;
    }

    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.A)) x -= 1f;
        if (Input.GetKey(KeyCode.D)) x += 1f;
        if (Input.GetKey(KeyCode.S)) y -= 1f;
        if (Input.GetKey(KeyCode.W)) y += 1f;

        move = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = move * moveSpeed;
    }
}
