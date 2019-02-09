using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenPresent : MonoBehaviour {

	public int Point { get; set; }
    public int LosePoint { get; set; }
    public int toSetPoint;
    public int toSetLosePoint;

    private void Start()
    {
        Point = toSetPoint;
        LosePoint = toSetLosePoint;
    }
}
