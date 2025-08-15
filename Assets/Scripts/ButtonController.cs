using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
}
    public void Shop(){
        SceneManager.LoadScene("ShopScene");
    }
    public void Exit(){
        Application.Quit();
    }
    public void Back(){
        SceneManager.LoadScene("MainMenu");
    }
    public void Again(){
        SceneManager.LoadScene("GameScene");
    }
}
