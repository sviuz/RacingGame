using System;
using System.Numerics;
using UnityEditorInternal;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class MoveTrack : MonoBehaviour
{
    public float speed;
    //public GameObject track;

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector2 offset = new Vector2(0, Time.time + speed/2);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
