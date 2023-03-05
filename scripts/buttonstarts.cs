using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonstarts : MonoBehaviour
{
    public GameObject maingame;
    public GameObject startbutton; 
    public void pressed(){
        Debug.Log("game has started");
        maingame.SetActive(true);
        startbutton.SetActive(false);
    }
}
