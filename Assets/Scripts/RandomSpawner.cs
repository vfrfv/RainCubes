using System.Collections;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private Cube _prefabCube;

    private int _heightSpawn = 6;
    private int _minRangeX = -4;
    private int _maxRangeX = 5;
    private int _minRangeZ = -4;
    private int _maxRangeZ = 5;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        float amountDelay = 0.2f;
        var delay = new WaitForSeconds(amountDelay);

        while (enabled)
        {
            Vector3 randomPosition = new Vector3(Random.Range(_minRangeX, _maxRangeX), _heightSpawn, Random.Range(_minRangeZ, _maxRangeZ));

            Instantiate(_prefabCube, randomPosition, Quaternion.identity);

            yield return delay;
        }
    }
}
