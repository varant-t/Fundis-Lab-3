using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerDataEntry : MonoBehaviour
{
    public PlayerData playerData;
    public Hashtable pd;
   

    public TextMeshPro TextPlayerName;
    public TextMeshPro TextPlayerLevel;
    public TextMeshPro TextPlayerScore;
    public TMP_InputField InputField;
    public TextMeshProUGUI displayText;


    // Start is called before the first frame update
    void Start()
    {

        PlayerData playerdata = gameObject.GetComponent<PlayerData>();
        TextPlayerName = GameObject.FindObjectOfType<TextMeshPro>();
        InputField = GameObject.FindObjectOfType<TMP_InputField>();


        pd = new Hashtable();
        pd.Add(0, "Varant");
        pd.Add(1, "Matt");
        pd.Add(2, "Charles");
        pd.Add(3, "Craig");

      
        CallingEntry();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void CallingEntry()
    {
        if(pd.ContainsValue(InputField.textComponent) && pd.ContainsKey(0))
        {
            displayText.text = playerData.GetValues();
            Debug.Log("Calling");
        }

    }    


}



