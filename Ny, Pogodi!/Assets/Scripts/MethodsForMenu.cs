using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MethodsForMenu : MonoBehaviour {
    
    public int Score { get; set; }
    public int EggsNumber { get; set; }
    public int GoldNumber { get; set; }

    private int _maxScore;
    private Text _scoreText;
    private GameObject _gameOverScreen;
    private string _levelDificultyStr;

	private void Start () {
        Score = 300;
        _maxScore = 0;
        EggsNumber = 0;
        GoldNumber = 0;

        _gameOverScreen = GameObject.Find("GameOverI");
        _gameOverScreen.SetActive(false);

        _scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

        _levelDificultyStr = GameObject.Find("DificultyData").GetComponent<Data>().LevelDificulty;
    }
	
    public void Restart()
    {
        print("Click");
        Time.timeScale = 1;
        SceneManager.LoadScene("game");
    }

    public void ToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        _gameOverScreen.SetActive(true);
        SetScores();
    }

    private void SetScores()
    {
        Text scoreNumberText = _gameOverScreen.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>();
        Text eggNumberText = _gameOverScreen.transform.GetChild(4).transform.GetChild(0).GetComponent<Text>();
        Text goldNumberText = _gameOverScreen.transform.GetChild(5).transform.GetChild(0).GetComponent<Text>();
        scoreNumberText.text = "Score\n" + Score.ToString();
        eggNumberText.text = "Egg\n" + EggsNumber.ToString();
        goldNumberText.text = "Gold\n" + GoldNumber.ToString();

        if (PlayerPrefs.GetInt(_levelDificultyStr) < _maxScore)
        {
            PlayerPrefs.SetInt(_levelDificultyStr, _maxScore);
        }
    }

	private void Update () {
		if (Score < 0)
            GameOver();

        if (_maxScore < Score)
            _maxScore = Score;

        _scoreText.text = "Score:\n" + Score.ToString();
	}
}
