using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelbitisgecis : MonoBehaviour
{
  private float delayeBeforeLoading= 3.0f;

    public string scenename;

    private float timelapsed;

    private void Update()
    {

        timelapsed += Time.deltaTime;

        if (timelapsed > delayeBeforeLoading)
        {
            SceneManager.LoadScene(scenename);


        }
    }



}
