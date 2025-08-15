using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text highScoreTxt;

    // Update is called once per frame
    void Update()
    {
        int highScore =PlayerPrefs.GetInt("HighScore");
        highScoreTxt.text=highScore.ToString();
        
    }
}
