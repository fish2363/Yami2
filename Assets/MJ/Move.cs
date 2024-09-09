using UnityEngine;

public class Move : RandomEvent
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigid;
    private Vector2 _moveDir;
    private bool _isStart = false;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Enter()
    {
        base.Enter();
        _isStart = true;
    }


    private void Update()
    {
        if (_isStart == true)
            Movement();
    }

    private void FixedUpdate()
    {
        if (_isStart == true)
            _rigid.velocity = _moveDir * _speed;
    }

    private void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        _moveDir = new Vector2(x, y);
    }
}
