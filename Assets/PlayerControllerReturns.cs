using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    public AudioClip jump;
    public AudioClip backgroundMusic;
    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;

    Animator anim;

    private Rigidbody2D rb;
    private bool isGrounded;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sfxPlayer = GetComponent<AudioSource>();
        Time.timeScale = 1f;
    }

    void Update()
    {
        anim.SetBool("IsOnGround", isGrounded);
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
       
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            sfxPlayer.PlayOneShot(jump);
            anim.SetTrigger("Jump");
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
    
    
}