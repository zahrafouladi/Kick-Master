using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatArea : MonoBehaviour
{
    public GameManager gameManager;
    private int touchCount=0;
    private bool isUnlimitedMode=false;
    private const int REQUIRED_TOUCHES=5;

    // Start is called before the first frame update
    void Start()
    {
       
        if(GetComponent<Collider2D>()== null){
            Debug.LogError("TouchAreaController requires a Collider2D component!");
        }
        
    }
    void OnMouseDown(){
        HandleTouch(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0){
            Touch touch =Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
                HandleTouch(touch.position);
            }
        }
        
    }

    void HandleTouch(Vector2 screenPosition){
        Vector2 worldPosition=Camera.main.ScreenToWorldPoint(screenPosition);
        RaycastHit2D hit=Physics2D.Raycast(worldPosition, Vector2.zero);

        if(hit.collider != null && hit.collider.gameObject== gameObject){
            if(!isUnlimitedMode){
                touchCount++;

                if(touchCount >= REQUIRED_TOUCHES){
                    ActivateUnlimitedMode();
                }
            }
        }
    }

    void ActivateUnlimitedMode(){
        isUnlimitedMode=true;
        
        if(gameManager != null){
            gameManager.DoubleScore(999999f);
            gameManager.SetUnlimitedLives();
        }
    }
    public bool IsUnlimitedMode(){
        return isUnlimitedMode;
    }
}
