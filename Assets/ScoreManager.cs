using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int p1Score;
    public int p2Score;
    public TextMeshProUGUI winScreen;
    public TextMeshProUGUI p1ScoreUI;
    public TextMeshProUGUI p2ScoreUI;

    private void Update()
    {
       p1ScoreUI.text = "P1 Score: "+p1Score;
        p2ScoreUI.text = "P2 Score: " + p2Score;

        if (p1Score >= 4 || p2Score >= 4)
            winScreen.text = "Player Wins!";
    }
}
