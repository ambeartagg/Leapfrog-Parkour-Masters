using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    public TextMeshProUGUI winScreen;
    

    public void PlayerWin()
    {
        winScreen.text = "Player Wins!";
    }
}
