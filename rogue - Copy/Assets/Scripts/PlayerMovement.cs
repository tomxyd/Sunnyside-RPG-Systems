using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private enum State{
        Normal,
        Pause,
        roll,
        Attack,
        Mining,
    }
    new Rigidbody2D rigidbody2D;
    private GameObject[] resource;
    private GameObject target;
    private PlayerAnimation anim;
    private State state;
    public Vector2 moveDir { get; private set; }
    private Vector2 rollDir;
    public Transform attackPosition;
    [SerializeField] private float attackRadius;
    Vector2 lastMoveDir;
    bool facingRight = true;
    [SerializeField] private float moveSpeed;
    public float rollSpeed{ get; private set; }
    public GameObject IP;
    // Start is called before the first frame update
    void Awake(){
        rigidbody2D = GetComponent<Rigidbody2D>();       
        state = State.Normal;
    }
    private void Start()
    {
        anim = GetComponentInChildren<PlayerAnimation>();
    }
    void Menu(){
        if(Input.GetKeyDown(KeyCode.Tab)){
            if(IP.activeSelf){
                IP.SetActive(false);
            }else{
                IP.SetActive(true);
            }
        }
    }
     private void Update() {
        switch(state){
            case State.Pause:
                Menu();
                  if(IP.activeSelf){
                    state = State.Pause;
                }else{
                    state = State.Normal;
                }
                break;
            case State.Normal:
                Menu();
                float horizontalInput = Input.GetAxis("Horizontal");
                float verticalInput = Input.GetAxis("Vertical");
                Vector2 movementInput = new Vector2(horizontalInput, verticalInput);
                moveDir = movementInput.normalized;
                if (horizontalInput != 0 || verticalInput != 0)
                {
                    lastMoveDir = moveDir;
                }
                if ((moveDir.x > 0 && !facingRight) || (moveDir.x < 0 && facingRight))
                {
                    Flip();
                }
                PlayerRoll();
                if(Input.GetMouseButtonDown(0)){
                    state = State.Mining;
                    
                }
                if(IP.activeSelf){
                    state = State.Pause;
                }
                break;
            case State.roll:
                float rollSpeedFallMultiplier = 5f;
                rollSpeed -= rollSpeed * rollSpeedFallMultiplier * Time.deltaTime;
                float rollSpeedMinimum = 50f;
                if(rollSpeed < rollSpeedMinimum){
                    state = State.Normal;
                }
                break;
            case State.Attack:
                //play attack animation
                //launch boc trigger in front of player
                //check for enemy 
                //attack enemy
                anim.SetTrigger("attack");
                Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPosition.position, attackRadius);
                state = State.Normal;
                break;
            case State.Mining:
                //play mining animation
                anim.SetTrigger("mine");
                state = State.Normal;
                break;

        }
        
        

    }
    void EnableResources(){
        if(target != null){
             ResourceSourceUI targetResources = target.GetComponent<ResourceSourceUI>();
            targetResources.gameObject.SetActive(true);
        }
       
    }
    

    private void PlayerRoll()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rollDir = moveDir;
            rollSpeed = 750f;
            state = State.roll;
        }
    }

    private void FixedUpdate()
    {
        switch(state){
            case State.Normal:
                rigidbody2D.velocity = moveDir * moveSpeed * Time.deltaTime;
                break;
            case State.roll:
                rigidbody2D.velocity = lastMoveDir * rollSpeed * Time.deltaTime;
                break;
            case State.Attack:
                rigidbody2D.velocity = Vector2.zero;
                break;
        }
        
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 0);
    }
    private void OnDrawGizmos()
    {
        if(attackPosition == null){
            return;
        }
        Gizmos.DrawWireSphere(attackPosition.position, attackRadius);
    }
}
