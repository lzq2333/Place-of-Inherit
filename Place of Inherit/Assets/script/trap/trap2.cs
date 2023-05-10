using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap2 : MonoBehaviour
{
    public bool mus;
    // Start is called before the first frame update
    public GameObject music1;
    public GameObject arro;//Cube预制体
    public UnityEngine.Transform point;

    void Start()
    {

        //每2秒重复调用函数
        InvokeRepeating("music", 2, 3f);
        InvokeRepeating("Fire", 0, 3f);

    }
    private void music()
    {
        if(mus==false)
        music1.SetActive(true);
      
    }

    //自动生成对象
    private void Fire()
    {
        music1.SetActive(false);
        //生成预制体
        Instantiate(arro, point.position, point.rotation);

    }

}
