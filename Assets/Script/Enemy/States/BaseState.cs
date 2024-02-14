using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState(SlimeStateManager Slime);
    public abstract void UpdateState(SlimeStateManager Slime);
    public abstract void OnCollisionEnter(SlimeStateManager Slime, Collision2D collision);
    public abstract void ExitState(SlimeStateManager Slime);
}
