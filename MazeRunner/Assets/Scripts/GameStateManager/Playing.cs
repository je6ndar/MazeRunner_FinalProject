using UnityEngine;

public class Playing : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {
        Time.timeScale = 1f;
    }

    public override void UpdateState(GameStateManager game)
    {

    }
}
