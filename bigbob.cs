using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partic : MonoBehaviour
{
    private Transform tr1;
    [SerializeField] private Transform player_tf1;
    private ParticleSystem df1;
    void Start()
    {
        tr1 = GetComponent<Transform>();
        df1 = GetComponent<ParticleSystem>();
        df1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        tr1.position = new Vector2(player_tf1.position.x, player_tf1.position.y);
    }
}
