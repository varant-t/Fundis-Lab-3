using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerDataEntry : MonoBehaviour
{
    public string Name;
    public int Level;
    public int Score;
    public Hashtable playerData;
    public PlayerData pd;

    public TextMeshPro TextPlayerName;
    public TextMeshPro TextPlayerLevel;
    public TextMeshPro TextPlayerScore;
    public TMP_InputField InputField;

    public TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        TextPlayerName = GameObject.FindObjectOfType<TextMeshPro>();

        InputField = GameObject.FindObjectOfType<TMP_InputField>();

        playerData = new Hashtable();

        playerData.Add(0, "Varant");
        playerData.Add(1, "Charles");
        playerData.Add(2, "Matt");
        playerData.Add(3, "Craig");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CallingEntry()
    {
        if(playerData.ContainsValue(InputField.text) && playerData.ContainsKey(0))
        {
            displayText.text = "Name: Varant " + " Level: 100 " + " Score: 1000 ";
            Debug.Log(InputField.text);
        }
        Debug.Log(InputField.text);

    }    

    void varantStats()
    {
        Name = "Varant";
        Level = 100;
        Score = 1000;
    }

    void chalresStats()
    {
        Name = "Charles";
        Level = 80;
        Score = 800;
    }

    void mattStats()
    {
        Name = "Matt";
        Level = 60;
        Score = 600;
    }

    void craigStats()
    {
        Name = "Craig";
        Level = 40;
        Score = 400;
    }
}



