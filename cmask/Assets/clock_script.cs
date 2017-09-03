using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//need using UI

public class clock_script : MonoBehaviour {
    public int maxtime = 20;

    public Image gauge; //move circle
    public Text time_text;
    

    void Start()
    {
        maxtime = 20;
    }

    public void view_up_time(int now_time, float x)
    {if (now_time > maxtime) return;
      
        gauge.fillAmount = (float)x / maxtime;
        time_text.text = now_time.ToString();
    }

    public void resetfill() {
        gauge.fillAmount = 0;
        time_text.text = "0";
    }
  
}
