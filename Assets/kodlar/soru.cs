using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class soru : MonoBehaviour
{
    public InputField inp;
    public string cevap;

    void Update()
    {
        if (inp.text == cevap)
        {
            SceneManager.LoadScene("levelcomplate");
        }
    }
}
