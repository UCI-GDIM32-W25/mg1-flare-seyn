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

        if (_plantCountUI != null)
        {
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }

    private void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical");     

        
        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized * (_speed * Time.deltaTime);
        _playerTransform.position += movement;

        // Space 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        
        if (_numSeedsLeft <= 0) return;
        if (_plantPrefab == null) return;

   
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

      
        _numSeedsLeft--;
        _numSeedsPlanted++;

        if (_plantCountUI != null)
        {
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}
