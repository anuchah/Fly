using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EagleScript : MonoBehaviour
{
    [SerializeField]
    public float jumpFoce = 4f;
    public static bool eagleAlive = true;
    public static int numberOfCoins;
    private Rigidbody2D rb2D;
    private Animator animator;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && eagleAlive)
        {
            HandleFlap();
        }
    }

   private void HandleFlap()
    {
        rb2D.velocity = Vector2.up * jumpFoce;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            HandleDie();
        }
    }

    private void HandleDie()
    {
        eagleAlive = false;
        animator.Play("Die");
        animator.SetTrigger("isDeath");
        Invoke("DestroyObject", 3f);
        SceneManager.LoadScene(3);
    }

     private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
