using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestingState : BaseState
{
    float timer = 2;
    float defaultTimer = 2;
    // Start is called before the first frame update
public override void EnterState(SlimeStateManager Slime)
    {
        Debug.Log("Entering Resting State");
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        timer = timer - 1 * Time.deltaTime;
        if(timer <= 0)
        {
            Slime.SwitchState(Slime.ChasingState);
        }
    }
    public override void OnCollisionEnter(SlimeStateManager Slime)
    {
    }
    public override void ExitState(SlimeStateManager Slime)
    {
        timer = defaultTimer;
    }
}
