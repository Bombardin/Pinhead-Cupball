using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private int count { get; set; }
    private bool nextState {get; set;}
    private Rigidbody rb;
    public Text countText;
    public Text loseText;
    public Text scoreText;
    private int score;
    Vector3 originalPosition;
    public GameObject soundBox;
    //private Vector3 startingPosition = rb.Transform.localPosition();
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        count = 3;
        score = 0;
        countText.text = "BallCount: " + count.ToString();
        loseText.text = "";
        scoreText.text = "Score: " + score.ToString();
        originalPosition = 
            new Vector3(rb.gameObject.transform.position.x, 
                        rb.gameObject.transform.position.y, 
                        rb.gameObject.transform.position.z);

        soundBox = GameObject.FindWithTag("SoundBox");

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Catcher"))
        {
            count = count - 1;
            countText.text = "BallCount: " + count.ToString();
            if (count <= 0)
            {
                loseText.text = "Game Over";
                soundBox.GetComponent<SoundBoxScript>().playSounds("loss");
            }
            else
            {
                transform.position = originalPosition;
                soundBox.GetComponent<SoundBoxScript>().playSounds("plunger2");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bumper"))
        {
            score += 100;
            scoreText.text = "Score: " + score.ToString();
            soundBox.GetComponent<SoundBoxScript>().playSounds("bumperAndDing");
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            soundBox.GetComponent<SoundBoxScript>().playSounds("hitWall");
        }
    }

}
