using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_script : MonoBehaviour {

    public clock_script _crock_script; //script view clock
    
    public int  now_time;

    public float timeOut=1f;  // interval time
    private float timeElapsed; //internal interval time

    void Start()
    {
      
    }

    
    //when press
    public void start_bt() {
        now_time = 0; 
        _crock_script.view_up_time(0,0);
    }




    
    void Update()
    {
       
       
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
          
          
            ++now_time;
           
            timeElapsed = 0.0f;
        }
        _crock_script.view_up_time(now_time, (float)(now_time+timeElapsed));
    }
}
