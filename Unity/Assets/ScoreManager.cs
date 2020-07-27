using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score; 
    private int displayScore;
    public Text scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        displayScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(score != displayScore) 
        {
            displayScore = score;
            scoreUI.text = displayScore.ToString();
        }
    }
}
