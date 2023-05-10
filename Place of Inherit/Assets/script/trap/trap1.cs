using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject arro;//Cube预制体
    public UnityEngine.Transform point;

    void Start()
    {
       
        //每2秒重复调用函数
        InvokeRepeating("Fire", 0, 2f);
    }

    //自动生成对象
    private void Fire()
    {
        
        //生成预制体
        Instantiate(arro, point.position, point.rotation);

    }

}
