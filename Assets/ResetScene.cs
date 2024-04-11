using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScene : MonoBehaviour
{
    [Tooltip("Shall we reset position to parent's position?")]
    public bool _resetToParentPosition = false;

    private Vector3 _initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        if (_resetToParentPosition && transform.parent != null)
            _initialPosition = transform.parent.position;
        else
            _initialPosition = transform.position;
    }

    void OnBecameInvisible()
    {
        transform.position = _initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
