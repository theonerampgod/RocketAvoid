
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public static bool lose = false;
    public GameObject restart;
    public GameObject extm;
    public int startTime;
    public Text MyText = null;
    public int t;



    void Awake()
    {
        lose = false;
    }
    void OnEnable()
    {
        startTime = (int)Time.time;
    }
    public void Update()
    {

        t = (int)Time.time - startTime;
        if (lose != true)
        {
            MyText.text = t.ToString();
            if ((t > Records.rec1) && (t > Records.rec2) && (t > Records.rec3))
            {
                Records.rec1 = t;
            }
            if ((t < Records.rec1) && (t > Records.rec2) && (t > Records.rec3))
            {
                Records.rec2 = t;
            }
            if ((t < Records.rec1) && (t < Records.rec2) && (t > Records.rec3))
            {
                Records.rec3 = t;
            }

        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
            lose = true;
        restart.SetActive(true);
        extm.SetActive(true);
    }

}
