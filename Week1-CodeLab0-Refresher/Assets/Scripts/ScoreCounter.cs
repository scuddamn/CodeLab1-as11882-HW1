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
        //probably not the best way to do this? i originally did it in 2 different scripts so this feels better than that at least
        //display player 1 score
        if (gameObject.CompareTag("Player1"))
        {

            score.text = "Player 1 Score: " + P1scoreValue;
        }

        //display player 2 score
        if (gameObject.CompareTag("Player2"))
        {
            score.text = "Player 2 Score: " + P2scoreValue;
        }
    }
}
