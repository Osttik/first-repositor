using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private GameObject _player;
    private Camera _cam;

	void Start () {
        _player = GameObject.Find("Player");
        _cam = Camera.main;
	}
	
	void Update () {
		if (Input.GetMouseButton(0))
        {
            float positionX = _cam.ScreenToWorldPoint(Input.mousePosition).x;
            _player.transform.position = new Vector3(positionX, _player.transform.position.y, _player.transform.position.z);
        }
	}
}
