using UnityEngine;

public class SlimeIdleState : BaseState
{
    public override void EnterState(SlimeStateManager Slime)
    {
        Debug.Log("Entering Idle State");
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        if(Slime.distance <= Slime.chassingRange)
        {
            Slime.SwitchState(Slime.ChasingState);
        }
    }
    public override void OnCollisionEnter(SlimeStateManager Slime)
    {
        Debug.Log("Collision");
    }
    public override void ExitState(SlimeStateManager Slime)
    {
        Debug.Log("Exiting State");
    }
}
