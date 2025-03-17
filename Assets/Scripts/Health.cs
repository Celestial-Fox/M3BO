using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private int health = 5;
    public Text healthText;

    private void Update()
    {
        healthText.text = "HEALTH : " + health;

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            health--;
        }
    }
}
