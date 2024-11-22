using UnityEngine;

[RequireComponent(typeof(Blob))]
public class PlayerController : MonoBehaviour
{
    private bool _isServer;
    private Blob _blob;
    
    private void Start()
    {
        _blob = GetComponent<Blob>();
    }
    
    void Update()
    {
        var cursorInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _blob.Direction = cursorInWorld - transform.position;
    }
}
