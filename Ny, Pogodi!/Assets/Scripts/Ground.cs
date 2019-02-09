using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

    private MethodsForMenu _controller;

	private void Start () {
        _controller = GameObject.Find("Controller").GetComponent<MethodsForMenu>();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        _controller.Score -= Mathf.Abs(other.gameObject.GetComponent<FallenPresent>().LosePoint);
        Destroy(other.gameObject);
    }
}
