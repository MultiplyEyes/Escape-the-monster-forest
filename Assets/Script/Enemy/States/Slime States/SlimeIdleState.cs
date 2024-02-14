using UnityEngine;

public class SlimeIdleState : BaseState
{
    public override void EnterState(SlimeStateManager Slime)
    {
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        if(Slime.distance <= Slime.chassingRange)
        {
            Slime.SwitchState(Slime.ChasingState);
        }
    }
    public override void OnCollisionEnter(SlimeStateManager Slime, Collision2D collision)
    {
    }

    public override void ExitState(SlimeStateManager Slime)
    {
    }
}
