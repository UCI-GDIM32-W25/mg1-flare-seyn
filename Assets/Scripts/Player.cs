using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        if (_playerTransform == null)
        {
            _playerTransform = transform;
        }

        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        UpdateSeedUI();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * (_speed * Time.deltaTime);
        _playerTransform.Translate(movement, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft <= 0 || _plantPrefab == null)
        {
            return;
        }

        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _numSeedsLeft--;
        _numSeedsPlanted++;
        UpdateSeedUI();
    }

    private void UpdateSeedUI()
    {
        if (_plantCountUI == null)
        {
            return;
        }

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
