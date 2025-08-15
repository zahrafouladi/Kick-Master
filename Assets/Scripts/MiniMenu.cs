using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniMenu : MonoBehaviour
{
    public GameObject PausePanel;

    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
        
    }

    public void Pause(){
        if(PausePanel != null){
            PausePanel.SetActive(true);
            Time.timeScale=0f;
        }
        else{
            Debug.Log("PausePanel is not assigned in the Inspector!");
        }
    }

    public void Continue(){
        if(PausePanel !=null){
            PausePanel.SetActive(false);
            Time.timeScale=1f;
        }
        else{
            Debug.Log("PausePanel is not assigned in the Inspector!");
        }
    }

    public void Home(){
        Time.timeScale=1f;
        SceneManager.LoadScene("MainMenu");
    }
}
