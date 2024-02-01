using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector3 _direction;
    
    private void Update()
    {
        if (_direction == null)
            return;

        transform.Translate(_direction * Time.deltaTime * _moveSpeed);
    }

    public void GetDirection(Vector3 direction)
    {
        _direction = direction;
//
        if (_direction.x <0)
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }
}
