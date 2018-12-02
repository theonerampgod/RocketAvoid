using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitFromRecords : MonoBehaviour
{


    public void Button_OnClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
