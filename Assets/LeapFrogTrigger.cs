using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeapFrogTrigger : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard;
    public TextMeshProUGUI winScreen;
    public int score;
    public bool isPlayer1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
           Debug.Log("Score!");
            score++;
            if (isPlayer1)
            {
                scoreBoard.text = "P2 score:" + score;
            }
            else
            {
                scoreBoard.text = "P1 score:" + score;
            }
            
            if (score >= 4)
            {
                winScreen.text = "Player wins!:)";
            }
        }
    }
}
