using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreCounter : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    
    public int score { get; private set; }

    private void Awake()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = $"Score: {score}";
    }

    public void AddScore(int scorePoints, bool playSound = false)
    {
        score += scorePoints;
        scoreText.text = $"Score: {score}";
    }
}
