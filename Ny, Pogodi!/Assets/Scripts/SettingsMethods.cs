using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SettingsMethods : MonoBehaviour {

    public Slider volumeSlider;

    private Data _data;

	private void Start () {
        volumeSlider.value = volumeSlider.maxValue;
        _data = GameObject.Find("DificultyData").GetComponent<Data>();

	}
	
	private void Update () {
        _data.Volume = volumeSlider.value;
        Camera.main.GetComponent<AudioSource>().volume = volumeSlider.value/100f;
    }
}
