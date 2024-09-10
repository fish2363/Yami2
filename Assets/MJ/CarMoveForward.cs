using DG.Tweening;

public class CarMoveForward : RandomEvent
{
    private bool _isStart = false;


    private void Awake()
    {
    }

    public override void Enter()
    {
        base.Enter();
        _isStart = true;
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (_isStart == true)
        {
            transform.DOLocalMoveY(-4300, 9);
        }
    }
}
