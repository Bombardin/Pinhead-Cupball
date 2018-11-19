using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullString : MonoBehaviour {
    public string inputName;
    public float distance = 50.0f;
    public float speed = 1.0f;
    public GameObject ball;
    public float power = 2000.0f;
    private bool ready { get; set; }
    private bool fire { get; set; }
    private float moveCount { get; set; }
    
    // Use this for initialization
    void Start () {
        ready = false;
        fire = false;
        moveCount = 0.0f;
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ready = true;
        }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetButton(inputName))
        //gradually pull down as button is held
        { 
            if(moveCount < distance)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                fire = true;
            }
        }
        else if(moveCount > 0)
        {
            if(fire && ready)
            {
                //shoot the ball
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            //fire 
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;
        }
        //to stay on the board
        if(moveCount <= 0)
        {
            fire = false;
            moveCount = 0;
        }
	}
    
}
