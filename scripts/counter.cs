using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//counter in unity

public class counter : randomGEnerator
{
    public Text counterText;
    public Text mistaketext; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        counter-=1*Time.deltaTime;
        counterText.text = "Time: " + counter.ToString("0.00");
        mistaketext.text = "Mistake: " + mistake.ToString("0");
    }
}
