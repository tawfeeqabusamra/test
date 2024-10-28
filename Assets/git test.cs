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

            if (ran == 15){
                Debug.Log(ran);
                break;
            }
            else if (ran == 5){
                continue;
            }
            else{
                Debug.Log(ran);
            }
            
            A++;
        }
    }

   
}
