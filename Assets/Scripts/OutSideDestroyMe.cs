using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutSideDestroyMe : MonoBehaviour
{
    bool showFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // ��� �����Ѵ�.(�����ð�����)
    void LateUpdate()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            //1ȸǥ�õ� ����
            showFlag = true;

        }
        else
        {
            if (showFlag)
            {
                //ȭ�� ������ ���ͼ� ������� �����Ѵ�.
                Destroy(this.gameObject);
                
            }
        }
    }
}
