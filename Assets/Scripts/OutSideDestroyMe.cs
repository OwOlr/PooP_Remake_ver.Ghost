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

    // 계속 시행한다.(일정시간마다)
    void LateUpdate()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            //1회표시된 다음
            showFlag = true;

        }
        else
        {
            if (showFlag)
            {
                //화면 밖으로 나와서 사라지면 삭제한다.
                Destroy(this.gameObject);
                
            }
        }
    }
}
