using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score=0;
    public int lives=3;
    public int highScore=0;
    private bool isDoubleScoreActive=false;
    private bool isUnlimitedLives=false;

    public GameObject ballImg;
    public Image bgImg;
    public Sprite basketballImg;
    public Sprite basketballBgImg;
    public Sprite tennisBallImg;
    public Sprite tennisBgImg;
    public Sprite baseballImg;
    public Sprite baseballBgImg;
    public Sprite americanfootballImg;
    public Sprite americanfootballBgImg;
    public Sprite volleyballImg;
    public Sprite volleyballBgImg;
    public Sprite pingpongImg;
    public Sprite pingpongBgImg;

    private bool baseball=false;
    private bool americanfootball=false;
    private bool volleyball=false;
    private bool pingpong=false;
    
    public TMP_Text livesTxt;
    public TMP_Text ScoreTxt;

    public AudioSource footballSound;
    public AudioSource basketballSound;
    public AudioSource tennisSound;

    private ShopController shopController;

    // Start is called before the first frame update
    void Start()
    {
        footballSound.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer ballImage=ballImg.GetComponent<SpriteRenderer>();
        if(score==20){
            ballImage.sprite=basketballImg;
            bgImg.sprite=basketballBgImg;
            footballSound.Stop();
            basketballSound.Play();
        }
        else if(score==40){
            ballImage.sprite=tennisBallImg;
            bgImg.sprite=tennisBgImg;
            basketballSound.Stop();
            tennisSound.Play();
        }
        else if(score==60){
            CheckShop();
        }
        else if(score==80){
            CheckShop();
        }
        else if(score==100){
            CheckShop();
        }
        else if(score==120){
            CheckShop();
        }
       
    }

         void CheckShop(){
            SpriteRenderer ballImage=ballImg.GetComponent<SpriteRenderer>();
        if(shopController.Baseball_purchased==true && baseball==false){
            baseball=true;
            ballImage.sprite=baseballImg;
            bgImg.sprite=baseballBgImg;
        }
        else if(shopController.AmericanFootball_purchased==true && americanfootball==false){
            americanfootball=true;
            ballImage.sprite=americanfootballImg;
            bgImg.sprite=americanfootballBgImg;
        }
        else if(shopController.Volleyball_purchased==true && volleyball==false){
            volleyball=true;
            ballImage.sprite=volleyballImg;
            bgImg.sprite=volleyballBgImg;
        }
        else if(shopController.Pingpong_purchased==true && pingpong==false){
            pingpong=true;
            ballImage.sprite=pingpongImg;
            bgImg.sprite=pingpongBgImg;
        }
    }
}

