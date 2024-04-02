using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int scoreCount = 0;
    void Start()
    {

    }

    void Update()
    {
        var text = "Score:" + scoreCount;
        ScoreText.text = text;
        Debug.Log(text);
    }

    public void AddScore(int score = 1)
    {
        scoreCount += score;
    }
}
