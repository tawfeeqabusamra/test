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
       while( true ){
        int ran = Random.Range(0,10);
        // string testWord = arr[ran];
        // String [] test = new string [7];
        // test.Append(testWord);
        string targetWord = arr[ran];
        
        bool wordExists = sentence.Contains(targetWord);
        if(!wordExists){
            sentence.Append(targetWord);
            i++;
        }

        
        if(i==7) {
            break;
        }
       }
          foreach(string s in sentence){
            Debug.Log(s);
          }
    //    string targetWord 
    }

   
}
