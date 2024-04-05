using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeapFrogTrigger : MonoBehaviour
{

    public ScoreManager scoreMan;
    public bool isPlayer1;


    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
           Debug.Log("Score!");

           
            
           
            
            
        }
    }
}
