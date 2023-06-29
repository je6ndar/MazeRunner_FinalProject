using UnityEngine;

public class isPaused : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {
       Time.timeScale = 0f;
    }

    public override void UpdateState(GameStateManager game)
    {
       
    }
}
