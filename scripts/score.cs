using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//to display score in unity
public class score : randomGEnerator
{
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "Score: " + score;
    }
}
