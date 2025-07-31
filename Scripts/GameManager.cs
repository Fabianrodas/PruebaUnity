using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text textScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void addScore()
    {
        score++;
        textScore.text = score.ToString();
    }
}
