using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MenuScoreSetter : MonoBehaviour {

    private Text _easyScoreText;
    private Text _mediumScoreText;
    private Text _hardScoreText;
    private Text _insaneScoreText;

	void Start ()
    {
        _easyScoreText = transform.GetChild(1).GetChild(1).GetComponent<Text>();
        _mediumScoreText = transform.GetChild(2).GetChild(1).GetComponent<Text>();
        _hardScoreText = transform.GetChild(3).GetChild(1).GetComponent<Text>();
        _insaneScoreText = transform.GetChild(4).GetChild(0).GetComponent<Text>();

        _easyScoreText.text = "1. " + PlayerPrefs.GetInt("Easy").ToString();
        _mediumScoreText.text = "1. " + PlayerPrefs.GetInt("Medium").ToString();
        _hardScoreText.text = "1. " + PlayerPrefs.GetInt("Hard").ToString();

        if (PlayerPrefs.GetInt("Insane") != 0)
            _insaneScoreText.text = "1. " + PlayerPrefs.GetInt("Insane").ToString();
        // To Remove before build 
        //PlayerPrefs.DeleteAll();
        //
    }
}
