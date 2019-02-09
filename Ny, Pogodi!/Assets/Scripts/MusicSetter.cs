using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSetter : MonoBehaviour {

    private Data _data;

	void Start () {
        _data = GameObject.Find("DificultyData").GetComponent<Data>();
        transform.GetComponent<AudioSource>().volume = _data.Volume/100f;
	}
}
