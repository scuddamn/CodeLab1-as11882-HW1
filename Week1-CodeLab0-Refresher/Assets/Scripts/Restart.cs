using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        //reload current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreCounter.P1scoreValue = 0;
        ScoreCounter.P2scoreValue = 0;
    }
}
