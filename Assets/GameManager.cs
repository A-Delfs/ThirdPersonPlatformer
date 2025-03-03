using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void IncreaseScore()
    {
        score++;
        if (scoreText != null) 
        {
            scoreText.text = "Score: " + score;
        }
        Debug.Log("Score: " + score);
    }
}
