using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float time;
    Vector3 a;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        a.x = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        a.y = gameObject.transform.position.y;
        a.z = gameObject.transform.position.z;
        if (timer < time)
        { a.x += speed * eye.x; }
        else stop();
        if(eye.x!=0)
        {
            timer += Time.deltaTime;
        }
        gameObject.transform.position = a;
    }
    void stop()
    {
        if (timer > time)
        {eye.x = 0;
            timer = 0;

        }
            

    }
}
