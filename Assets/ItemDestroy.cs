using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{

    private GameObject unitychan;
    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < unitychan.transform.position.z-5)
        {
            //�ڐG�����R�C���̃I�u�W�F�N�g��j��
            Destroy(this.gameObject);
        }


    }
}
