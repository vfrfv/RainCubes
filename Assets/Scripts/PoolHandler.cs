using UnityEngine;

public class PoolHandler : MonoBehaviour
{
    [SerializeField] private Cube _prefabCube;

    private PoolCubes _pool;

    public PoolCubes Pool => _pool;

    private void Awake()
    {
        _pool = new PoolCubes(_prefabCube);
    }
}
