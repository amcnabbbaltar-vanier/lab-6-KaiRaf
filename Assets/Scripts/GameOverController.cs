using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score: " +
                    GameManager.Instance.getScore().ToString();
        }
    }

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
