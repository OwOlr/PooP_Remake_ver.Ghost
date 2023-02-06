using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreatePrefeb : MonoBehaviour
{
    public GameObject newPrefeb;
    public float startSec = 2.0f;
    public float intervalSec = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("CreatePrefeb_Invoke", intervalSec);    //1�ʵ� �ѹ� ����

        InvokeRepeating("CreatePRefeb", startSec, intervalSec); //2�� �� ����ǰ� 1�ʸ��� �ݺ�,
    }


    void CreatePrefeb_Invoke()
    {
        Debug.LogWarning("�κ�ũ �Լ� ȣ��");

    }
    void CreatePrefeb_Repeat()
    {
        Debug.Log("�κ�ũ ����Ʈ �Լ� ȣ��");

    }
    void CreatePRefeb()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.z = -5;

        GameObject newGo = Instantiate(newPrefeb);
        newGo.transform.position = newPos;


    }
    void vCreatePRefeb_save()
    {
        Debug.Log("");
    }
}