using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count1 : MonoBehaviour
{

    public Text MyText = null;
    public int t;
    public int startTime;

    void OnEnable()
    {
        startTime = (int)Time.time;
    }

    public void Update()
    {
        //while (!Player.lose)
        //{
            t = (int)Time.time - startTime;
            MyText.text = t.ToString();
        //}
    }
}

