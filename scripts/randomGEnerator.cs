using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomGEnerator : MonoBehaviour
{
    public static float counter;
    static int flag;
    public GameObject[] sq= new GameObject[9];
    SpriteRenderer[] sp_rend=new SpriteRenderer[9];
    SpriteRenderer sp_changed;
    static public int score;
    GameObject obj_changed;
    static public int mistake;
    void Start()
    {
        for(int i=0;i<9;i++){
        sp_rend[i]= sq[i].GetComponent<SpriteRenderer>();
        }
        flag=1;
        score=0;
        mistake=0;
        counter=7;
    }
    void Update()
    {   


        if(flag==1){
        int a=Random.Range(0,9);
        sp_rend[a].color=Color.red;
        sp_changed=sq[a].GetComponent<SpriteRenderer>();
        obj_changed=sq[a];
        obj_changed.tag="enemy";
        flag=0;
        }

        
        if (Input.touchCount > 0 && flag==0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
 
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "enemy")
                {
                    sp_changed.color=Color.black;
                    obj_changed.tag="sqaure";
                    score++;
                    flag=1;
                    counter+=(float)0.25;
                }
                else{
                mistake++;
                
                }

            }
            else{
                mistake++;
                
            }
        }
    }
}
        

