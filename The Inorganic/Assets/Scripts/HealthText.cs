using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "" + HealthManager.playerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthManager.playerHealth < 0)
        {
            HealthManager.playerHealth = 0;
        }
        text.text = "" + HealthManager.playerHealth;
       
    }
}
