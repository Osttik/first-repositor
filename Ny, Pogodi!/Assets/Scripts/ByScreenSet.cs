using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ByScreenSet : MonoBehaviour {
    
	void Start () {
        float x = Camera.main.pixelWidth;
        float y = Camera.main.pixelHeight;

        //var gameOverImage = GameObject.Find("GameOverI").GetComponent<Image>();
        //gameOverImage.rectTransform.sizeDelta = new Vector2(x, y);

        //var ground = GameObject.Find("Ground");
        //ground.transform.localScale = new Vector3(x / 164, ground.transform.localScale.y, ground.transform.localScale.z);
	}
}
