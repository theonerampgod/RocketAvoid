using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Records : MonoBehaviour {

    public Text textRecords1 = null;
    public Text textRecords2 = null;
    public Text textRecords3 = null;
    public static int rec1;
    public static int rec2;
    public static int rec3;



    void Start () {
        textRecords1.text = rec1.ToString();
        textRecords2.text = rec2.ToString();
        textRecords3.text = rec3.ToString();
    }



}
