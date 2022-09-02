using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{


    public Sprite[] Sprites;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("repeatingSpawn", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void repeatingSpawn() 
    {
        SpawnCircle(colorPick());
        Debug.Log("create one circle");
    }
    public void SpawnCircle(int colorIndex)
    {
        GameObject newCircle;
        newCircle = Instantiate(Resources.Load<GameObject>("Prefabs/Circle"));
        newCircle.GetComponent<SpriteRenderer>().sprite = Sprites[colorIndex];
    }

    public int colorPick() 
    {
        return Random.Range(0, 4);
    }
}
