using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu]
public class PauseResponse : ScriptableObject
{
    [SerializeField] private AppManager appManager;
    [SerializeField] private State responseState;
    public void Respond()
    {
        Debug.Log("PausePressed responded to");
        if (appManager.AppStateMachine.ContainsState(responseState))
        {
            appManager.AppStateMachine.ChangeState(responseState);
        }
    }
}
