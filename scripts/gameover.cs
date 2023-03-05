using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : randomGEnerator
{
    public GameObject gameoverUI;
    public GameObject maingame;
    public Text YourscoreText;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(mistake >= 3 || counter <= 0){
            Debug.Log("gameover"+mistake);
            gameoverUI.SetActive(true);
            maingame.SetActive(false);
            YourscoreText.text = "Your Final Score: " + score;
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
