using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun : MonoBehaviour {

    private float _rotateSpeed;

    public GameObject gold;

    void Start () {
        _rotateSpeed = 40;
        StartGenerator();
    }
	
    private void MinigunRotate()
    {
        float rotateZ = transform.localEulerAngles.z;
        if (rotateZ >= 80 && rotateZ <= 280)
            _rotateSpeed *= -1;
        transform.Rotate(new Vector3(0, 0, 1f), _rotateSpeed * Time.deltaTime);
    }

	void Update () {
        MinigunRotate();
	}

    public void StartGenerator()
    {
        StartCoroutine("Generator");
    }

    IEnumerator Generator()
    {
        while (true)
        {
            float rotZ = transform.localEulerAngles.z;
            if (rotZ > 180f)
                rotZ -= 360f;
            float sinX = Mathf.Sin(rotZ);
            float cosX = Mathf.Cos(rotZ);
            var q = transform.rotation;
            print(q.eulerAngles);
            Instantiate(gold, transform.position, transform.rotation).transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(cosX - sinX, cosX + sinX)*200f);
            //var obj = Instantiate(gold, transform.position, transform.rotation) as GameObject;
            //var rigidbody = obj.GetComponent<Rigidbody2D>();
            //rigidbody.AddForce(new Vector2(5f * cosX, -5f * sinX), ForceMode2D.Impulse);
            //print(rotZ);
            yield return new WaitForSeconds(1f);
        }
    }
}
