using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap2 : MonoBehaviour
{
    public bool mus;
    // Start is called before the first frame update
    public GameObject music1;
    public GameObject arro;//CubeԤ����
    public UnityEngine.Transform point;

    void Start()
    {

        //ÿ2���ظ����ú���
        InvokeRepeating("music", 2, 3f);
        InvokeRepeating("Fire", 0, 3f);

    }
    private void music()
    {
        if(mus==false)
        music1.SetActive(true);
      
    }

    //�Զ����ɶ���
    private void Fire()
    {
        music1.SetActive(false);
        //����Ԥ����
        Instantiate(arro, point.position, point.rotation);

    }

}
