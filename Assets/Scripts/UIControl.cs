using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public Text life;
    public Text points;
    
    private Catcher player;
    public Image gameEnding;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Catcher>();
    }

    // Update is called once per frame
    void Update()
    {
        updateUI();
        updateEnding();
    }
    void updateUI ()
    {
        life.text = player.life.ToString();
        points.text = player.points.ToString();
    }

    void updateEnding() 
    {
        if (player.life <= 0)
        {
            gameEnding.gameObject.GetComponentInChildren<Text>().text = "Game Lose";
            gameEnding.gameObject.SetActive(true);
        }
        else if (player.points >= 10) 
        {
            gameEnding.gameObject.GetComponentInChildren<Text>().text = "Game Win";
            gameEnding.gameObject.SetActive(true);
        }
    }
}
