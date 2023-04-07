using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class genera_map : MonoBehaviour
{
    private List<GameObject> gameObjects = new List<GameObject>();
    public GameObject enamy;
    
private void Start()
    {
        
        gameObjects.Add(Instantiate(enamy));
        gameObjects[0].transform.position = new Vector2(12.89f, -0.76f);
    }
    /*2.51  -1.48*/
    
    void Update()
    {
        
        if (gameObjects[gameObjects.Count - 1].transform.position.x + 6f >= 16f && gameObjects[gameObjects.Count - 1].transform.position.x + 6f <= 19f)
        {
            gameObjects.Add(Instantiate(enamy));
            gameObjects[gameObjects.Count - 1].transform.position = new Vector2(gameObjects[gameObjects.Count - 1].transform.position.x + 6, Random.Range(-1.48f, 2.51f));
        }

        if (gameObjects[0].transform.position.x >= -15f && gameObjects[0].transform.position.x <= -12f)
        {
            
            Destroy(gameObjects[0], .5f);
            gameObjects.RemoveAt(0);
        }
    }
}
