using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winZoneEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xoay();
    }
    public void xoay()
    {
        transform.Rotate(0,0 ,-0.25f);
    }
}
