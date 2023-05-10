using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject player;
    Vector2 a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.x = player.transform.position.x;
        a.y = player.transform.position.y;
        gameObject.transform.position = a;
    }
}
