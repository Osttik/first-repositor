using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {
    
	public int Dificulty { get; set; }
    public float FallSpeedEggs { get; set; }
    public string LevelDificulty { get; set; }
    public float Volume { get; set; }

    private void Start()
    {
        Dificulty = 3;
        FallSpeedEggs = 20f;
        LevelDificulty = "Easy";
        Volume = 100f;
        DontDestroyOnLoad(transform);
    }
}
