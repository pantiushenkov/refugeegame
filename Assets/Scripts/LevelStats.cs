using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelStats
{
    public Vector2 position;
    public int health = 50;
    public bool[] collectedFruits = new bool[100];
}