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
        //Invoke("CreatePrefeb_Invoke", intervalSec);    //1초뒤 한번 실행

        InvokeRepeating("CreatePRefeb", startSec, intervalSec); //2초 뒤 실행되고 1초마다 반복,
    }


    void CreatePrefeb_Invoke()
    {
        Debug.LogWarning("인보크 함수 호출");

    }
    void CreatePrefeb_Repeat()
    {
        Debug.Log("인보크 리피트 함수 호출");

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