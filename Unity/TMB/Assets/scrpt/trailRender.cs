using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailRender : MonoBehaviour {

    public TrailRenderer trail;
    // Use this for initialization
    void Start()
    {
        trail.sortingLayerName = "Default";
        trail.sortingOrder = 6;
    }
    // Update is called once per frame
    void Update () {



    }
}
