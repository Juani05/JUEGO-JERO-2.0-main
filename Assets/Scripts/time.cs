using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    internal static int Timescale;
    public Text txt_timeFloored;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

            if (currentTime > 19)
            {
            SceneManager.LoadScene("ganaste");

        }
        }
    }
