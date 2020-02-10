using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    float currentTime = 0f;
    float startTime = 30f;

    public Text timerText;
    public Text winText;
    public GameObject startOverButton;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        timerText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;

            if(ScoreCounter.P1scoreValue > ScoreCounter.P2scoreValue)
            {
                winText.text = "Player 1 Wins!";
                startOverButton.SetActive(true);
                
            }

            if(ScoreCounter.P2scoreValue > ScoreCounter.P1scoreValue)
            {
                winText.text = "Player 2 Wins!";
                startOverButton.SetActive(true);
                
            }

            if(ScoreCounter.P1scoreValue == ScoreCounter.P2scoreValue)
            {
                winText.text = "Players Tied!";
                startOverButton.SetActive(true);
                
            }

            
        }

        if(currentTime >= 3.5f)
        {
            timerText.color = Color.black;
        }

        if(currentTime < 3.5f)
        {
            timerText.color = Color.red;
        }
    }
}
