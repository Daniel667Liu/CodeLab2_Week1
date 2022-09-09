using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{


    public Sprite[] Sprites;
    [HideInInspector]
    public int colorIndex;
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
        //Debug.Log("create one circle");
    }
    public void SpawnCircle(int colorIndex)
    {
        float x = Random.Range(-6.5f, 6.5f);
        float y = Random.Range(-3.5f, 3.5f);
        GameObject newCircle;
        newCircle = Instantiate(Resources.Load<GameObject>("Prefabs/Circle"));
        newCircle.GetComponent<SpriteRenderer>().sprite = Sprites[colorIndex];
        newCircle.GetComponent<Transform>().position = new Vector3(x, y, 0f);
        newCircle.GetComponent<CircleInfo>().colorIndex = colorIndex;
    }

    public int colorPick() 
    {
        colorIndex = Random.Range(0, 4);
        return colorIndex;
    }
}
