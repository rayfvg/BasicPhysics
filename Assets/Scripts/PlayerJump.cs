using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _force;
    private Rigidbody _rigitbody;

    public bool _isGrounded;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Ground ground = collision.gameObject.GetComponent<Ground>();

        if (ground != null)
            _isGrounded = true;
    }

    private void Update()
    {
        if (_isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _isGrounded = false;
                _rigitbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
            }             
        }   
    }
}