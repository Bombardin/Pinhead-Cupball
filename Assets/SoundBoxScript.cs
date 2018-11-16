using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBoxScript : MonoBehaviour {
    public AudioClip bowling;
    public AudioClip bowlingCompressed;
    public AudioClip bumper;
    public AudioClip bumperAndDing;
    public AudioClip hitWall;
    public AudioClip paddle;
    public AudioClip paddle2;
    public AudioClip ding;
    public AudioClip loss;
    public AudioClip plunger;
    public AudioClip plunger2;

    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)){
            playSounds("bowling");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playSounds("bowlingCompressed");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            playSounds("bumper");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            playSounds("bumperAndDing");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            playSounds("hitWall");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            playSounds("paddle");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            playSounds("paddle2");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            playSounds("ding");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            playSounds("loss");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            playSounds("plunger");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playSounds("plunger2");
        }

    }
    void playSounds(string soundChoice){
        switch (soundChoice){
            case "bowling":
                source.PlayOneShot(bowling, 1.0F);
                break;
            case "bowlingCompressed":
                source.PlayOneShot(bowlingCompressed, 1.0F);
                break;
            case "bumper":
                source.PlayOneShot(bumper, 10.0F);
                break;
            case "bumperAndDing":
                source.PlayOneShot(bumperAndDing, 10.0F);
                break;
            case "hitWall":
                source.PlayOneShot(hitWall, 10.0F);
                break;
            case "paddle":
                source.PlayOneShot(paddle, 10.0F);
                break;
            case "paddle2":
                source.PlayOneShot(paddle2, 10.0F);
                break;
            case "ding":
                source.PlayOneShot(ding, 1.0F);
                break;
            case "loss":
                source.PlayOneShot(loss, 1.0F);
                break;
            case "plunger":
                source.PlayOneShot(plunger, 10.0F);
                break;
            case "plunger2":
                source.PlayOneShot(plunger2, 10.0F);
                break;
        }
    }
}
