using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private PointCounter pointCounter;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "Player") return;
        
        pointCounter.ReduceScore(1);
    }
}
