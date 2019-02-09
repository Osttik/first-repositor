using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour {

    private MethodsForMenu _control;

	void Start () {
        _control = GameObject.Find("Controller").GetComponent<MethodsForMenu>();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        var element = other.gameObject.GetComponent<FallenPresent>();
        if (element != null)
        {
            if (element.tag == "Egg")
                _control.EggsNumber += 1;

            else if (element.tag == "Gold")
                _control.GoldNumber += 1;

            _control.Score += element.Point;
        }
        Destroy(other.gameObject);
    }
}
