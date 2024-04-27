using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private PoolHandler _poolHandler;

    public IEnumerator DeliteCube(Cube cube, int minTimeDeletion, int maxTimeDeletion)
    {
        yield return new WaitForSeconds(Random.Range(minTimeDeletion, maxTimeDeletion));

        _poolHandler.Pool.GetCube(cube);
    }
}
