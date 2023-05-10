using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public float speed;
    public float time;
    //Vector3 a;
    private Rigidbody2D rb2d;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // a.y = gameObject.transform.position.y;
        // a.z = gameObject.transform.position.z;
        if (timer < time)
        {
            if (eye.x < 0)
                rb2d.velocity = -transform.right * speed;
            if (eye.x > 0)
                rb2d.velocity = transform.right * speed;
        }
        else eye.x = 0;
        if (eye.x != 0)
        {
            timer += Time.deltaTime;
        }
       
    }
}
