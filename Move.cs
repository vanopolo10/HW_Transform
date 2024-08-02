using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    private int _speedCoefficient = 10;

    private void Update()
    {
        transform.Translate(transform.forward * (_speed * _speedCoefficient * Time.deltaTime));
    }
}
