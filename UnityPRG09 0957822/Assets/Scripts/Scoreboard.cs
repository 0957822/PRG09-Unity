using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour  {

    public static int totalScore = 0;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnGUI(){

        GUI.Box (new Rect (10,10,50,20), totalScore.ToString());

    }
}
