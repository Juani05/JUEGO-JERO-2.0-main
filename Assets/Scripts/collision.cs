using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Auto")
        {
            audioManager.playclip();
            StartCoroutine(esperar());  
        }

    }
    IEnumerator esperar ()
    {
        playermovement temp = GetComponent<playermovement>();
        temp.movementSpeed = 0;
        temp.turningSpeed = 0;
        yield return new WaitForSeconds(.6f);
        SceneManager.LoadScene("playagain");
    }
}
