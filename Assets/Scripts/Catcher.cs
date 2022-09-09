using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    [SerializeField]
    private int colorIndex;
    public int life = 10;
    public int points = 0;
    private Camera cam;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        colorIndex = Random.Range(0, 4);
        cam = FindObjectOfType<Camera>();
        this.gameObject.GetComponent<Transform>().position = new Vector3(0f, 0f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        updatePos();
    }

    void updatePos() 
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = mousePosition.x;
        float y = mousePosition.y;
        this.gameObject.GetComponent<Transform>().Translate((new Vector3(x, y, 0f) - this.gameObject.GetComponent<Transform>().position) * speed * Time.deltaTime, Space.World);
    }

    public void CalPoints(int circleColor) 
    {
        if (circleColor == colorIndex)
        {
            points++;
        }
        else 
        {
            life--;
        }
    }
}
