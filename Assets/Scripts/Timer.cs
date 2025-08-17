using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Slider timeSlider;
    public float gameTime=10f;
    private bool stopTimer=true;
    private float startTime;

    public void ActiveTimer(){
        stopTimer=false;
        startTime=Time.time;
        timeSlider.maxValue=gameTime;
        timeSlider.value=gameTime;
    }
    // Update is called once per frame
    void Update()
    {
        if(!stopTimer){

            float elapsedTime=Time.time-startTime;
            float time=gameTime-elapsedTime;

            int minutes=Mathf.FloorToInt(time/60);
            int seconds=Mathf.FloorToInt(time-minutes*60);

            if(time <= 0){
                stopTimer=true;
                gameObject.SetActive(false);
            }

            timeSlider.value=time;
        }
        
    }
}
