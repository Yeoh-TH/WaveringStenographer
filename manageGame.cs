using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manageGame : MonoBehaviour
{
    public GameObject player;
    public static bool gameOver = false;
    public GameObject gameOverScreen;
    public static int Score = 0;
    public Text scoreDisplay;

    void Start()
    {
    }

    void Update()
    {
        if (player.transform.position.y < -6.0f)
        {
            gameOver = true;
            gameOverScreen.SetActive(gameOver);
        }
    }

    public void addScore(int scoreToAdd)
    { 
        Score += scoreToAdd;
        scoreDisplay.text = Score.ToString();
    }

    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
