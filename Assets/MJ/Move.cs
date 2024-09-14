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
        {
            Movement();
            Rotation();
        }
    }

    private void Rotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(180, 0, 0);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
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
