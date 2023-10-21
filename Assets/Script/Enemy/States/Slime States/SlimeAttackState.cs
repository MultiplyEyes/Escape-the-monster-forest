using UnityEngine;

public class SlimeAttackState : BaseState
{
    public override void EnterState(SlimeStateManager Slime)
    {
        Debug.Log("Entering Attack State");
    }
    public override void UpdateState(SlimeStateManager Slime)
    {
        GameObject newArrow = MonoBehaviour.Instantiate(Slime.slimeProjectile, Slime.transform.position, Slime.transform.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = Slime.transform.right * Slime.slimeProjectileSpeed;
        Slime.SwitchState(Slime.RestingState);
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
