using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private GameObject visual;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Point bertambah");
        if (!col.gameObject.TryGetComponent(out PointCounter point)) return;
        
        point.AddScore(1);
        Destroy(visual);
    }
}
