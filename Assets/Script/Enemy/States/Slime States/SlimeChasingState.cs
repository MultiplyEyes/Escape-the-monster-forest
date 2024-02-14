using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeChasingState : BaseState
{
    Vector2 direction;
    float chassingTime = 3;
    float chassingDefaultTime = 3;
    public override void EnterState(SlimeStateManager Slime)
    {
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        //Slime.rb.AddForce((Slime.player.transform.position - Slime.transform.position).normalized * Slime.speed);
        direction = (Slime.player.transform.position - Slime.transform.position).normalized;

        Slime.rb.velocity = new Vector2(direction.x * Slime.speed, direction.y * Slime.speed);



        if(Slime.distance >= Slime.chassingRange)
        {
            Slime.SwitchState(Slime.IdleState);
        }
        chassingTime = chassingTime - 1 * Time.deltaTime;
        if(chassingTime <= 0)
        {
            Slime.SwitchState(Slime.AttackState);
        }
    }
    public override void OnCollisionEnter(SlimeStateManager Slime, Collision2D collision)
    {
    }
    public override void ExitState(SlimeStateManager Slime)
    {
        chassingTime = chassingDefaultTime;
        Slime.rb.velocity = Vector2.zero;
    }
}