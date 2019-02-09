using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonMethods : MonoBehaviour {

    private Data _data;

	private void Start () {
        _data = GameObject.Find("DificultyData").GetComponent<Data>();
    }

    public void Open(Transform transform)
    {
        transform.gameObject.SetActive(true);
    }

    public void Close(Transform transform)
    {
        transform.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("game");
    }

    public void SetEasy()
    {
        _data.Dificulty = 3;
        _data.FallSpeedEggs = 20f;
        _data.LevelDificulty = "Easy";
    }

    public void SetMedium()
    {
        _data.Dificulty = 3;
        _data.FallSpeedEggs = 15f;
        _data.LevelDificulty = "Medium";
    }

    public void SetHard()
    {
        _data.Dificulty = 5;
        _data.FallSpeedEggs = 13f;
        _data.LevelDificulty = "Hard";
    }
    
    public void SetInsane()
    {
        _data.Dificulty = 5;
        _data.FallSpeedEggs = 10f;
        _data.LevelDificulty = "Insane";
    }

    public void Quit()
    {
        Application.Quit();
    }
}
