using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject replayObj;
    Rigidbody2D playerRigid;
    public float speed = 2;
    float vx;
    bool flipFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        playerRigid = GetComponent<Rigidbody2D>();
        playerRigid.gravityScale = 0;
        playerRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
        playerRigid.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            flipFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            flipFlag = true;
        }
        
    }
    private void FixedUpdate()
    {
        playerRigid.velocity = new Vector2(vx, 0);
        //무거운 물리.
        //playerRigid.AddForce(new Vector2(vx, 0));
        this.GetComponent<SpriteRenderer>().flipX = flipFlag;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "uni_0(Clone)")
        {
            GameObject checkObj = collision.gameObject;
            if (checkObj != null)
            {
                Debug.Log("Game Over!!");
                replayObj.SetActive(true);
                Time.timeScale = 0;

            }
        }
    }
}
