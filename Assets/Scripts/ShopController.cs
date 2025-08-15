using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public bool Baseball_purchased = false;
    public bool AmericanFootball_purchased = false;
    public bool Volleyball_purchased = false;
    public bool Pingpong_purchased = false;
    public bool X2live_purchased = false;
    public bool X5live_purchased = false;
    public bool X10live_purchased = false;
    

    public GameObject Baseball_pur_obj;
    public GameObject AmericanFootball_pur_obj;
    public GameObject Volleyball_pur_obj;
    public GameObject Pingpong_pur_obj;
    public GameObject X2live_pur_obj;
    public GameObject X5live_pur_obj;
    public GameObject X10live_pur_obj;

    public GameObject BaseballBtn;
    public GameObject AmericanfootballBtn;
    public GameObject VolleyballBtn;
    public GameObject PingpongBtn;
    public GameObject X2liveBtn;
    public GameObject X5liveBtn;
    public GameObject X10liveBtn;

    void Start()
    {
        Baseball_pur_obj.SetActive(false);
        AmericanFootball_pur_obj.SetActive(false);
        Volleyball_pur_obj.SetActive(false);
        Pingpong_pur_obj.SetActive(false);
        X2live_pur_obj.SetActive(false);
        X5live_pur_obj.SetActive(false);
        X10live_pur_obj.SetActive(false);
        
    }
    

    void Update()
    {
        if(Baseball_purchased){
            BaseballBtn.SetActive(false);
            Baseball_pur_obj.SetActive(true);

        }
        if(AmericanFootball_purchased){
            AmericanfootballBtn.SetActive(false);
            AmericanFootball_pur_obj.SetActive(true);
        }
        if(Volleyball_purchased){
            VolleyballBtn.SetActive(false);
            Volleyball_pur_obj.SetActive(true);
        }
        if(Pingpong_purchased){
            PingpongBtn.SetActive(false);
            Pingpong_pur_obj.SetActive(true);
        }
        if(X2live_purchased){
            X2liveBtn.SetActive(false);
            X2live_pur_obj.SetActive(true);
        }
        if(X5live_purchased){
            X5liveBtn.SetActive(false);
            X5live_pur_obj.SetActive(true);
        }
        if(X10live_purchased){
            X10liveBtn.SetActive(false);
            X10live_pur_obj.SetActive(true);
        }
        
    }

    public void BaseBall(){
        Baseball_purchased=true;
    }
    public void AmericanFootball()
    {
        AmericanFootball_purchased=true;
    }
    public void VolleyBall(){
        Volleyball_purchased=true;
    }
    public void PingPong(){
        Pingpong_purchased=true;
    }
    public void X2live(){
        X2live_purchased=true;
    }
    public void X5live(){
        X5live_purchased=true;
    }
    public void X10live(){
        X10live_purchased=true;
    }
}
