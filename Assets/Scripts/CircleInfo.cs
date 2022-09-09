using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInfo : MonoBehaviour
{
    [HideInInspector]
    public int colorIndex;
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
        
        if (other.gameObject.CompareTag("Player")) 
        {
            
            other.gameObject.GetComponent<Catcher>().CalPoints(colorIndex);
            Destroy(this.gameObject);
        }
    }
}
