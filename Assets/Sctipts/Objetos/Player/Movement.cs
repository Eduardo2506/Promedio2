using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    Vector2 moveInput;
    public Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveInput.x * speed, moveInput.y * speed);

        bool isWalking = moveInput != Vector2.zero;

        animator.SetBool("isWalk", isWalking);

        if (moveInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
