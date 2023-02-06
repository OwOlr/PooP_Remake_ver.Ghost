using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    public int score = 0;
    private void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "uni_0(Clone)")
        {
            GameObject checkObj = collision.gameObject;
            if (checkObj != null)
            {
                score++;
                Debug.Log("Score : " + score);

            }
        }
    }
}
