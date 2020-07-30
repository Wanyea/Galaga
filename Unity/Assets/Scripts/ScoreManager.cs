using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score; 
    private int displayScore;
    public Text scoreUI;

    void Start()
    {
        score = 0;
        displayScore = 0;
    }
    void Update()
    {
        if(score != displayScore) 
        {
            displayScore = score;
            scoreUI.text = displayScore.ToString();
        }
    }
}
