using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }
}
