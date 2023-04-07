using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumping_script : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpspeed = 10f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) 
        {
            rb.velocity = Vector2.up * jumpspeed;            
        }       
    }
}
