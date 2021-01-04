using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{

    [SerializeField] float velocity = 1;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            rb.velocity = Vector2.up * velocity;
        }
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * 20f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
