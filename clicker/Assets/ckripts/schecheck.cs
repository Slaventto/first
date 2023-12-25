using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schecheck : MonoBehaviour
{
    public int tamer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        tamer++;
        Debug.Log(tamer);
    }
}
