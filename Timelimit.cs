using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class Timelimit : MonoBehaviour
{
    public Text timer;
    public GameObject timeDisplay;
    public float seconds;
    public bool deductingTime;
    public GameObject gameOver;
    public Behaviour scriptA;
    public Behaviour scriptB;
    public GameObject bally;
    public GameObject pausemenu;



    void Start() {
        timer.text = seconds.ToString("F2");
        gameOver.SetActive(false);
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds > 0) {
            seconds -= Time.deltaTime;
            timer.text = seconds.ToString("F2");
        }

        if (seconds <= 0) {
            seconds = 0;
            gameOver.SetActive(true);
            scriptA.enabled = false;
            scriptB.enabled = false;
            deductingTime = false;
            timeDisplay.SetActive(false);

            
        }
        if (Input.GetKeyDown("space")) {
            if (seconds >= 5) {
                bally.transform.position = new Vector3(0,0,5);
                seconds -= 1;
            }
            
        }
        if (Input.GetKeyDown("p")) {
            
            scriptA.enabled = false;
            scriptB.enabled = false;
            deductingTime = false;
            Time.timeScale = 0f;
            pausemenu.SetActive(true);
            
            
        }
        if (Input.GetKeyDown("d")) {
            Time.timeScale = 1f;
            scriptA.enabled = true;
            scriptB.enabled = true;
            deductingTime = true;
            pausemenu.SetActive(false);
            
        }
                    
    
       

    }

    IEnumerator DeductSecond() {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "TIME: " + seconds;
        deductingTime = false;
    }
}
