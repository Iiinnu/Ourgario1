using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : MonoBehaviour
{
    public Vector2 Direction { get; set; }
    private float _size = 1f;
    public string Guid { get; set; }
    public float Size
    {
        get => _size;
        set
        {
            transform.localScale = new Vector3(value, value, 1f);
            _size = value;
        }
    }
    public float baseSpeed = 3f;
    
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Direction.normalized * baseSpeed / Size;
    }

    private void OnTriggerStay(Collider other)
    {
        // only if we can eat the other:
        var otherBlob = other.GetComponent<Blob>();
        if (otherBlob.Size >= Size) return;
        
        var distance = Vector2.Distance(other.transform.position, transform.position);
        if (distance < Size * 0.5f)
        {
            Debug.Log("We would've eaten the other blob if the programmers were better.");
            // Size += otherBlob.Size;
            // zoom out the camera
        }
    }
}
