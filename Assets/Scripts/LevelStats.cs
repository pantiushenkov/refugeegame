using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelStats
{
    public Vector2 position;
    public int life = 50;
    public bool[] collectedQuestions = new bool[10];
	public bool[] collectedFruits = new bool[10];
}