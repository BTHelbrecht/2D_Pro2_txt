using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allow creation of scriptable object through unity menu
[CreateAssetMenu(menuName = "State")]

// State machine class... Used for text___________________________________________________________________
public class State : ScriptableObject   //Scriptable object is a DATA container
{
    // creat text box (inspector) 14 lines by 10
    // serialized make this public in inspector
    // string to hold text from inspector (CAN HARD CODE THIS ALSO)
    [TextArea(14, 10)] [SerializeField] string storyText;
    // serialized make this public in inspector
    // created arrry to allow option of next state based on current state.
    [SerializeField] State[] nextStateArray;

    
    // Public Methods_____________________________________________________________________________________

    // Gets current states text
    public string GetStateText()
    {
        return storyText;
    }

    // Provides the next state in array form... Varies per current state...
    public State[] GetNextState()
    {
        return nextStateArray;
    }
}
 