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
    private int currentStageIndex = -1;

    public GameObject ballImg;
    public Image bgImg;
   
    public Sprite footballImg;
    public Sprite footballBgImg;
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

    
    public TMP_Text livesTxt;
    public TMP_Text ScoreTxt;

    public AudioSource footballSound;
    public AudioSource basketballSound;
    public AudioSource tennisSound;
    public AudioSource baseballSound;
    public AudioSource americanfootballSound;
    public AudioSource volleyballSound;
    public AudioSource pingpongSound;


    public bool Baseball_purchased ;
    public bool AmericanFootball_purchased ;
    public bool Volleyball_purchased ;
    public bool Pingpong_purchased ;
    public bool X2live_purchased ;
    public bool X5live_purchased  ;
    public bool X10live_purchased ;

    private List<Stage> stages=new List<Stage>();
    [System.Serializable]
    public class Stage{
        public string name;
        public Sprite ball;
        public Sprite bg;
        public AudioSource sound;
    }

    // Start is called before the first frame update
    void Start()
    {
         Baseball_purchased=PlayerPrefs.GetInt("Baseball_purchased",0) == 1;
        AmericanFootball_purchased=PlayerPrefs.GetInt("AmericanFootball_purchased",0) == 1;
        Volleyball_purchased=PlayerPrefs.GetInt("Volleyball_purchased",0) == 1;
        Pingpong_purchased=PlayerPrefs.GetInt("Pingpong_purchased",0) == 1;

        X2live_purchased=PlayerPrefs.GetInt("X2live_purchased",0) == 1;
        X5live_purchased=PlayerPrefs.GetInt("X5live_purchased",0) == 1;
        X10live_purchased=PlayerPrefs.GetInt("X10live_purchased",0) == 1;

        stages.Clear();
        stages.Add(new Stage(){ name="Football", ball=footballImg, bg=footballBgImg, sound=footballSound});
        stages.Add(new Stage(){ name="Basketball", ball=basketballImg, bg=basketballBgImg, sound=basketballSound});
        stages.Add(new Stage(){ name="Tennis", ball=tennisBallImg, bg=tennisBgImg, sound=tennisSound});

        if(Baseball_purchased)  stages.Add(new Stage(){ name="Baseball", ball=baseballImg, bg=baseballBgImg, sound=baseballSound});
        if(AmericanFootball_purchased)  stages.Add(new Stage(){ name="AmericanFootball", ball=americanfootballImg, bg=americanfootballBgImg, sound=americanfootballSound});
        if(Volleyball_purchased)  stages.Add(new Stage(){ name="Volleyball", ball=volleyballImg, bg=volleyballBgImg, sound=volleyballSound});
        if(Pingpong_purchased)  stages.Add(new Stage(){ name="Pingpong", ball=pingpongImg, bg=pingpongBgImg, sound=pingpongSound});

        SetStage(0);

        if(X2live_purchased) lives = lives*2;
        if(X5live_purchased) lives = lives*5;
        if(X10live_purchased) lives = lives*10;

         highScore =PlayerPrefs.GetInt("HighScore");
         livesTxt.text=lives.ToString();
         ScoreTxt.text=score.ToString();       
    }

    // Update is called once per frame
    void Update()
    {
        livesTxt.text=lives.ToString();
        ScoreTxt.text=score.ToString();

        if(isUnlimitedLives) lives=999999;

        int stageIndex=score/20;
        if(stageIndex>=stages.Count) stageIndex=stages.Count-1;

        SetStage(stageIndex);

        SpriteRenderer ballImage=ballImg.GetComponent<SpriteRenderer>();

       if(score>=highScore){
        highScore=score;
        PlayerPrefs.SetInt("HighScore",highScore);
        PlayerPrefs.Save();
       }
       
       if(lives<=0){
        SceneManager.LoadScene("GameOver");
       }
      
    }

    void SetStage(int index){
        if(index < 0 || index >= stages.Count) return;

       if(currentStageIndex == index) return; 
           currentStageIndex = index;

        Stage s=stages[index];
         ballImg.GetComponent<SpriteRenderer>().sprite = s.ball;
        bgImg.sprite = s.bg;

        StopAllSounds();
        if(s.sound != null) s.sound.Play();
        
    }

    public void AddScore(){
        if(isDoubleScoreActive){
            score+=2;
        }
        else{
            score++;
        }

    }

    public void LoseLife(){
        if(!isUnlimitedLives){
            lives--;
        }
        else{
            Debug.Log("Life not reduced due to unlimited mode.");
        }
    }
    
    public void DoubleScore(float duration=10f){
        if(!isDoubleScoreActive){
            StartCoroutine(DoubleScoreCoroutine(duration));
        }
    }
    public IEnumerator DoubleScoreCoroutine(float duration){
        isDoubleScoreActive=true;
        yield return new WaitForSeconds(duration);
        isDoubleScoreActive=false;
    }
    public void SetUnlimitedLives(){
        isUnlimitedLives=true;
        Debug.Log("Unlimited lives activated!");
    }

    void StopAllSounds(){
        footballSound.Stop();
        basketballSound.Stop();
        tennisSound.Stop();
        baseballSound.Stop();
        americanfootballSound.Stop();
        volleyballSound.Stop();
        pingpongSound.Stop();
    }

}

