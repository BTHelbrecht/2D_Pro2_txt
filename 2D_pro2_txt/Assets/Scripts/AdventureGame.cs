using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class AdventureGame : MonoBehaviour
{
    // public variables initialized (Using serialized)
    [SerializeField] Text textComponent;
    [SerializeField] State initialState;
   

    // Instance to state class
    State currentState;

    // Private Variables Initialized
    private string hardcodeTestText = "Coded in C# text.";

    // Start is called before the first frame update
    void Start()
    {
        currentState = initialState;
        textComponent.text = currentState.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        throw new NotImplementedException();
    }
}
