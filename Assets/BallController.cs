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
        rb=GetComponent<Rigidbody2D>();
        if(rb==null){
            Debug.LogError("Rigidbody2D not found on BallController!");
        }
        startPosition=transform.position;
        defaultMaxSpeed=maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       // HandleInput();
        if(!isSpeedBoosted && rb.linearVelocity.magnitude>maxSpeed){
            rb.linearVelocity=rb.linearVelocity.normalized*maxSpeed;
        }
        
    }
    void HandleInput(){
        if(Input.touchCount>0){
            Touch touch=Input.GetTouch(0);
            Vector2 touchPos=Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase==TouchPhase.Began){
                RaycastHit2D hit=Physics2D.Raycast(touchPos, Vector2.zero);
                if(hit.collider != null && hit.collider.gameObject == gameObject){
                    isDragging=true;
                    dragStartPos=touchPos;
                   // KickBall();
                }
            }
            else if(touch.phase==TouchPhase.Moved && isDragging){
                Vector2 delta=touchPos-dragStartPos;
                rb.AddForce(new Vector2(delta.x * dragSpeed, 0), ForceMode2D.Force);
                dragStartPos=touchPos;
            }
            else if(touch.phase == TouchPhase.Ended){
                isDragging=false;
            }
        }
        else if(Input.GetMouseButton(0)){
            Vector2 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit =Physics2D.Raycast(mousePos, Vector2.zero);
            if(hit.collider != null && hit.collider.gameObject == gameObject){
               // KickBall();
               isDragging=true;
               dragStartPos=mousePos;
            }
        }
        else if(Input.GetMouseButton(0) && isDragging){
            Vector2 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 delta=mousePos-dragStartPos;
            rb.AddForce(new Vector2(delta.x * dragSpeed, 0), ForceMode2D.Force);
            dragStartPos=mousePos;
        }
        else if(Input.GetMouseButtonUp(0)){
            isDragging=false;
        }
    }
}
