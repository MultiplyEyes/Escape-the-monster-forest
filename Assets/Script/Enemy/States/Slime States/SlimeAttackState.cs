using UnityEngine;

public class SlimeAttackState : BaseState
{
    Vector2 direction;

    public override void EnterState(SlimeStateManager Slime)
    {
        
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        if(Slime.redSlime)
        {
            direction = (Slime.player.transform.position - Slime.transform.position).normalized;

            Slime.rb.velocity = new Vector2(direction.x * Slime.speed * 15, direction.y * Slime.speed * 15);
        }else
        {
            Vector2 diraction = Slime.player.transform.position - Slime.SlimeShootPoint.transform.position;
            float angle = Mathf.Atan2(diraction.y, diraction.x) * Mathf.Rad2Deg;
            Slime.SlimeShootPoint.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            GameObject newArrow = MonoBehaviour.Instantiate(Slime.slimeProjectile, Slime.SlimeShootPoint.transform.position, Slime.SlimeShootPoint.transform.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = Slime.SlimeShootPoint.transform.right * Slime.slimeProjectileSpeed;
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Slime Projectile"), LayerMask.NameToLayer("Arrow"));
            Slime.SwitchState(Slime.RestingState);
        }
  
    }
    public override void OnCollisionEnter(SlimeStateManager Slime, Collision2D collision)
    {

    }
    public override void ExitState(SlimeStateManager Slime)
    {
    }
}