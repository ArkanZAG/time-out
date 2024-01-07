using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private Player player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Point berkurang");
        if (!col.gameObject.TryGetComponent(out PointCounter point)) return;
        point.ReduceScore(1);
    }
}
