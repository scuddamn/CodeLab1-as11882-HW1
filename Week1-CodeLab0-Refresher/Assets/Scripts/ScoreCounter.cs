using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public static int P1scoreValue;
    public static int P2scoreValue;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Player1"))
        {

            score.text = "Player 1 Score: " + P1scoreValue;
        }

        if (gameObject.CompareTag("Player2"))
        {
            score.text = "Player 2 Score: " + P2scoreValue;
        }
    }
}
