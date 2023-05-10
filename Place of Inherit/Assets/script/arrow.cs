using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public float speed;
    public float destroyDistance;
    private Rigidbody2D rb2d;
    private Vector3 startPos;
    public   int Direction; // 方向 1代表上， 2代表下， 3代表左 4 代表右
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (Direction == 1)
        {
            rb2d.velocity = transform.up * speed;
            this.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
            startPos = transform.position;
        }
        else if (Direction == 2)
        {
            rb2d.velocity = -transform.up * speed;
            this.transform.rotation = Quaternion.AngleAxis(-90, Vector3.forward);
            startPos = transform.position;
        }
        else if (Direction == 3)
        {
            rb2d.velocity = -transform.right * speed;
            this.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            startPos = transform.position;

        }
        else if (Direction == 4)
        {
            rb2d.velocity = transform.right * speed;
            //this.transform.rotation = quaternion.angleaxis(180, vector3.forward);
            startPos = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        DestroyArrow();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"&&sixth.chest==false)
        {
            PlayerDEATH.dead = true;
        }
       
        Destroy(gameObject);
       

    }
   

    void DestroyArrow()
    {
        float distance = (transform.position - startPos).sqrMagnitude;
        if (distance > destroyDistance)
        {
            Destroy(gameObject);
        }

    }

}