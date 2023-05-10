using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydead : MonoBehaviour
{
    public static bool enemy;
    public static bool enemy1;
    public GameObject Enemy;
    public GameObject Enemy1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy)
            Destroy(Enemy);
        if (enemy1)
            Destroy(Enemy1);

    }
    
}
