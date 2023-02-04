using UnityEngine;

public class SpawnTarget : MonoBehaviour
{
    [SerializeField] private GameObject _targetPrefab;
    private int _countTarget;

    private Bounds _bounds;

    private float _xBoundsMin;
    private float _xBoundsMax;

    private float _yBoundsMin;
    private float _yBoundsMax;

    private float _zBoundsMin;
    private float _zBoundsMax;

    private float _xPos;
    private float _yPos;
    private float _zPos;
    
    private void Start()
    {
        _countTarget = PlayerPrefs.GetInt("Count");
        _bounds = GetComponent<BoxCollider>().bounds;

        _xBoundsMin = _bounds.min.x;
        _xBoundsMax = _bounds.max.x;

        _yBoundsMin = _bounds.min.y;
        _yBoundsMax = _bounds.max.y;

        _zBoundsMin = _bounds.min.z;
        _zBoundsMax = _bounds.max.z;

        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < _countTarget; i++)
        {
            _xPos = Random.Range(_xBoundsMin, _xBoundsMax);
            _yPos = Random.Range(_yBoundsMin, _yBoundsMax);
            _zPos = Random.Range(_zBoundsMin, _zBoundsMax);

            GameObject clone = Instantiate(_targetPrefab, new Vector3(_xPos, _yPos, _zPos), transform.rotation);
        }
    }
}
