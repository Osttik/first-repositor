using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    private float _timeSpanEggs;
    private float _timeSpanEcshn;
    private Data _data;
    private float _fallspeed;

    public bool IsStopCreating { get; set; }

    public GameObject fireMan;
    public GameObject[] variatyEgg = new GameObject[3];
    public GameObject[] spawnPoints = new GameObject[5];

    private int _dificultyLevel;

	private void Start () {
        Time.timeScale = 1;
        _data = GameObject.Find("DificultyData").GetComponent<Data>();
        _dificultyLevel = _data.Dificulty;
        _fallspeed = _data.FallSpeedEggs;
        _timeSpanEcshn = 100f * Time.deltaTime;

        IsStopCreating = false;
        StartGenerators();
	}

    public void StartGenerators()
    {
        StartCoroutine("EggsGenerator");
        StartCoroutine("EcshnGenerator");
    }

    IEnumerator EggsGenerator()
    {
        while (!IsStopCreating)
        {
            _timeSpanEggs = _fallspeed * Time.deltaTime;
            int randPoint = Random.Range(0, _dificultyLevel);
            float randByObject = Random.Range(0f, 1f);
            int randObject = 0;
            if (0.5f < randByObject && randByObject <= 0.7f)
            {
                randObject = 1;
            }
            else if (0.7f < randByObject)
            {
                randObject = 2;
            }
            Instantiate(variatyEgg[randObject], spawnPoints[randPoint].transform.position, transform.rotation);
            yield return new WaitForSeconds(_timeSpanEggs);
        }
    }

    IEnumerator EcshnGenerator()
    {
        while (!IsStopCreating)
        {
            float _timeSpanToDestroy = 50f * Time.deltaTime;
            float x = Random.Range(-6, 6);
            GameObject copyOfFireMan = Instantiate(fireMan, new Vector2(x, 5f), transform.rotation);

            yield return new WaitForSeconds(_timeSpanToDestroy);
            Destroy(copyOfFireMan);

            _timeSpanEcshn = 200f * Time.deltaTime;
            yield return new WaitForSeconds(_timeSpanEcshn);
        }
    }
}
