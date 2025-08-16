using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float kickForce=5f;
    public float kickForceBoostMultiplier=1.5f;
    public float dragSpeed=10f;
    public float maxSpeed=10f;
    public float speedBoostMultiplier=1.5f;
    private Rigidbody2D rb;
    private Vector2 startPosition;
    private bool isGrounded=false;
    private bool isDragging=false;
    private Vector2 dragStartPos;
    private bool isSpeedBoosted=false;
    private float defaultMaxSpeed;
    public GameObject timerChangespeed;
    public GameObject timerDoubleScore;
    public Timer timersliderSpeed;
    public Timer timersliderscore;
    public GameManager gamemanager;
    public AudioSource ballKick;
    public AudioSource loselifesound;
    public AudioSource itemsound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
