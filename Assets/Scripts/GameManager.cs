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
    
    public TMP_Text livesTxt;
    public TMP_Text ScoreTxt;

    public AudioSource footballSound;
    public AudioSource basketballSound;
    public AudioSource tennisSound;

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
       
    }
}
