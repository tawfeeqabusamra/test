using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gittest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int A = 0;
        while(A<20){
            int ran = Random.Range(1,21);
            switch(ran){
                case 5 : continue;
                case 15 : break;
                default : Debug.Log(ran);
                break;
                
            }
            A++;
        }
    }

   
}
