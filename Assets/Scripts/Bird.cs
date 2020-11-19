using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] GameStatsScript _stats;
    [SerializeField] float _jumpForce = 5f;

    Rigidbody2D _body;
    bool _isJumpPressed;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_stats.ShouldTakeInput)
        {
            return;
        }
        _isJumpPressed = Input.GetKeyDown(KeyCode.Space);
        if (!_stats.GameStarted && _isJumpPressed)
        {
            _stats.GameStarted = true;
            FloppyBirdEvents.gameStartEvent.Invoke();
        }
    }

    private void FixedUpdate()
    {
        if (_isJumpPressed)
        {
            _body.velocity = Vector2.up * _jumpForce;
        }
    }
}
