
using UnityEngine;
using UnityEngine.UI;

public class FallDown : MonoBehaviour {

    [SerializeField]
     public float fallSpeed = 3f; // speed of bomb falling 
    public Text MyText = null;
    public int t = 0;



    void Update()
    {

        if (transform.position.y < -6f) // if bomb out from playing layout , they will be destroyed
            Destroy(gameObject);
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
        t++;
    }
}

