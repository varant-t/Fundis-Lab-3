using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{

    public string Name;
    public int Level;
    public int Score;

    public void SetValues(string Name, int Level, int Score)
    {
        this.Name = Name;
        this.Level = Level;
        this.Score = Score;
       
    }


    public string GetValues()
    {
        return ("Name: " + this.Name + "\n Level: " + this.Level + "\n Score: " + this.Score).ToString();
        
    }
   
   
    public string CreateValues(string name)
    {
        PlayerData Varant = new PlayerData();
        Varant.SetValues("Varant", 100, 1000);

        PlayerData Matt = new PlayerData();
        Matt.SetValues("Matt", 80, 800);

        PlayerData Charles = new PlayerData();
        Charles.SetValues("Charles", 60, 600);

        PlayerData Craig = new PlayerData();
        Craig.SetValues("Craig", 40, 400);


        if (name == "Varant")
        {
            return Varant.GetValues();
        }
        else if (name == "Matt")
        {
            return Matt.GetValues();
        }
        else if (name == "Charles")
        {
            return Charles.GetValues();
        }
        else if (name == "Craig")
        {
            return Craig.GetValues();
        }
        return "";
    }  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
