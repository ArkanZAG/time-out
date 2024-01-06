using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private GameObject visual;
    private PointCounter pointCounter;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "Player") return;
        
        pointCounter.AddScore(1);
        Destroy(visual);
    }
}
