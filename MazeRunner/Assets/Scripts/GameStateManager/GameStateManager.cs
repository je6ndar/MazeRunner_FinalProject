using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    GameBaseState currentState;
    isPaused isPausedState = new isPaused();
    Playing PlayingState = new Playing();

    private void Start()
    {
        currentState = PlayingState;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
