using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap1 : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject arro;//CubeԤ����
    public UnityEngine.Transform point;

    void Start()
    {
       
        //ÿ2���ظ����ú���
        InvokeRepeating("Fire", 0, 2f);
    }

    //�Զ����ɶ���
    private void Fire()
    {
        
        //����Ԥ����
        Instantiate(arro, point.position, point.rotation);

    }

}
