using UnityEngine;

public class SlimeAttackState : BaseState
{
    public override void EnterState(SlimeStateManager Slime)
    {
        Debug.Log("Entering Attack State");
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        Vector2 diraction = Slime.player.transform.position - Slime.SlimeShootPoint.transform.position;
        float angle = Mathf.Atan2(diraction.y, diraction.x) * Mathf.Rad2Deg;
        Slime.SlimeShootPoint.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if(Slime.redSlime)
        {
            Debug.Log("I am Red Slime");
            
            Slime.SwitchState(Slime.RestingState);
        }

        if (Slime.blueSlime)
        {
            Debug.Log("I am Blue Slime");
            GameObject newArrow = MonoBehaviour.Instantiate(Slime.slimeProjectile, Slime.SlimeShootPoint.transform.position, Slime.SlimeShootPoint.transform.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = Slime.SlimeShootPoint.transform.right * Slime.slimeProjectileSpeed;
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Slime Projectile"), LayerMask.NameToLayer("Arrow"));
            Slime.SwitchState(Slime.RestingState);
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
