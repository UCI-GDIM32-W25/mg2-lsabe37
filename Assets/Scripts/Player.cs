using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float jumpForce;
    private bool grounded = true;
    private int currentpoints;
    [SerializeField] private TextMeshProUGUI score;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            Jump();
        }
    }
    private void Jump()
    {
        rb.velocity = new Vector2(0, jumpForce);
        grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Floor"))
        {
            grounded = true;
        }

        if (collider.CompareTag("Coin"))
        {
            Destroy(collider.gameObject);
            currentpoints += 1;
            AddPoints(currentpoints);
        }
    }

    private void AddPoints(int points)
    {
        score.text = "Points: " + points.ToString();
    }

}
