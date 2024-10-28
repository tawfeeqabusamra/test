using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class ass2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       String [] arr = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"} ;
       String [] sentence = new string [7];
       int i =1 ;
       int x=0;
       string targetWord;
       int ran ;
       while( true ){
        ran = Random.Range(0,10);
        targetWord = arr[ran];
        bool wordExists = sentence.Contains(targetWord);
        if(!wordExists){            
            sentence[x]= targetWord;
            i++;
            x++;
        }        
        if(i==8) {
            break;
        }
       }
          foreach(string s in sentence){
            Debug.Log(s);
          }
    }  
}
