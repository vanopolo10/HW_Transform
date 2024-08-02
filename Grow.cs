using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    private int _growCoefficient = 1000;
    
    private void Update()
    {
        var newScale = transform.localScale;

        newScale.x += _speed / _growCoefficient;
        newScale.y += _speed / _growCoefficient;
        newScale.z += _speed / _growCoefficient;
        
        transform.localScale = newScale;
    }
}
