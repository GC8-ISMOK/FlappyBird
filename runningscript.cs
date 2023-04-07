using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningscript : MonoBehaviour
{
    private Transform tf;

void Start()
    {        
        tf = GetComponent<Transform>();
    }

    void Update()
    {

        tf.position = new Vector2(tf.position.x - 6f * Time.deltaTime, tf.position.y);
    }

}
