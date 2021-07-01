using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouncer : MonoBehaviour
{
    [SerializeField] private float jump=500f;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up*jump);
        }
        if (transform.position.y > 8.2 || transform.position.y < -7.35)
        {
            SceneManager.LoadScene(0);
        }
    }
}
