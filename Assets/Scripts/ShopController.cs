using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public bool Baseball_purchased ;
    public bool AmericanFootball_purchased ;
    public bool Volleyball_purchased ;
    public bool Pingpong_purchased ;
    public bool X2live_purchased ;
    public bool X5live_purchased  ;
    public bool X10live_purchased ;
    

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

    public AudioSource dropCoin;

    void Start()
    {
        /*
        if(Baseball_pur_obj !=null &&
            AmericanFootball_pur_obj !=null &&
            Volleyball_pur_obj != null &&
            Pingpong_pur_obj != null &&
            X2live_pur_obj != null &&
            X5live_pur_obj != null &&
            X10live_pur_obj != null ){
            
        Baseball_pur_obj.SetActive(false);
        AmericanFootball_pur_obj.SetActive(false);
        Volleyball_pur_obj.SetActive(false);
        Pingpong_pur_obj.SetActive(false);
        X2live_pur_obj.SetActive(false);
        X5live_pur_obj.SetActive(false);
        X10live_pur_obj.SetActive(false);
            }
            */
        
        
        
    }
    

    void Update()
    {

        Baseball_purchased=PlayerPrefs.GetInt("Baseball_purchased",0) == 1;
        if(Baseball_purchased){
            BaseballBtn.SetActive(false);
            Baseball_pur_obj.SetActive(true);

        }
        AmericanFootball_purchased=PlayerPrefs.GetInt("AmericanFootball_purchased",0) == 1;
        if(AmericanFootball_purchased){
            AmericanfootballBtn.SetActive(false);
            AmericanFootball_pur_obj.SetActive(true);
        }
        Volleyball_purchased=PlayerPrefs.GetInt("Volleyball_purchased",0) == 1;
        if(Volleyball_purchased){
            VolleyballBtn.SetActive(false);
            Volleyball_pur_obj.SetActive(true);
        }
        Pingpong_purchased=PlayerPrefs.GetInt("Pingpong_purchased",0) == 1;
        if(Pingpong_purchased){
            PingpongBtn.SetActive(false);
            Pingpong_pur_obj.SetActive(true);
        }
        X2live_purchased=PlayerPrefs.GetInt("X2live_purchased",0) == 1;
        if(X2live_purchased){
            X2liveBtn.SetActive(false);
            X2live_pur_obj.SetActive(true);
        }
        X5live_purchased=PlayerPrefs.GetInt("X5live_purchased",0) == 1;
        if(X5live_purchased){
            X5liveBtn.SetActive(false);
            X5live_pur_obj.SetActive(true);
        }
        X10live_purchased=PlayerPrefs.GetInt("X10live_purchased",0) == 1;
        if(X10live_purchased){
            X10liveBtn.SetActive(false);
            X10live_pur_obj.SetActive(true);
        }
        
    }

    public void BaseBall(){
        Baseball_purchased=true;
        PlayerPrefs.SetInt("Baseball_purchased",Baseball_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
    public void AmericanFootball()
    {
        AmericanFootball_purchased=true;
        PlayerPrefs.SetInt("AmericanFootball_purchased",AmericanFootball_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
    public void VolleyBall(){
        Volleyball_purchased=true;
        PlayerPrefs.SetInt("Volleyball_purchased",AmericanFootball_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
    public void PingPong(){
        Pingpong_purchased=true;
        PlayerPrefs.SetInt("Pingpong_purchased",Pingpong_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
    public void X2live(){
        X2live_purchased=true;
        PlayerPrefs.SetInt("X2live_purchased",X2live_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
    public void X5live(){
        X5live_purchased=true;
        PlayerPrefs.SetInt("X5live_purchased",X5live_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
    public void X10live(){
        X10live_purchased=true;
        PlayerPrefs.SetInt("X10live_purchased",X10live_purchased ? 1 : 0);
        PlayerPrefs.Save();
        dropCoin.Play();
    }
}
