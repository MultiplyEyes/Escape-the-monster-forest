using UnityEngine;

public class SlimeStateManager : MonoBehaviour
{
    BaseState CurrentState;
    
    public SlimeIdleState IdleState = new SlimeIdleState();
    public SlimeAttackState AttackState= new SlimeAttackState();
    public SlimeChasingState ChasingState = new SlimeChasingState();
    public RestingState RestingState = new RestingState();
    

    public GameObject slimeProjectile;
    public float slimeProjectileSpeed = 3f;
    public Transform player;
    public float distance, chassingRange, speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        CurrentState = IdleState;
        CurrentState.EnterState(this);
    }

    // Update is called once per frameW
    void Update()
    {
        CurrentState.UpdateState(this);

        distance = Vector2.Distance(transform.position, player.transform.position);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Every time you enter a new state you call the OnCollisionEnter method in the state class
        CurrentState.OnCollisionEnter(this);
    }

    public void SwitchState(BaseState state)
    {
        CurrentState.ExitState(this);
        CurrentState = state;
        state.EnterState(this);
    }
}
