using System;
using System.Collections.Generic;
using UnityEngine;

public class PoolCubes
{
    private readonly Cube _prefabCube;
    private readonly Queue<Cube> _cubes;

    public PoolCubes(Cube prefabCube)
    {
        _prefabCube = prefabCube ?? throw new ArgumentNullException(nameof(prefabCube));
        _cubes = new Queue<Cube>();
    }

    public Cube GiveCube(Vector3 position)
    {
        if(_cubes.Count < 1)
        {
            CreateCube();
        }
        
        Cube cube = _cubes.Dequeue();
        cube.gameObject.SetActive(true);
        cube.transform.position = position;
        return cube;     
    }

    public void GetCube(Cube cube)
    {
        cube.gameObject.SetActive(false);   
        _cubes.Enqueue(cube);
    }

    private void CreateCube()
    {
        Cube cube = GameObject.Instantiate(_prefabCube);
        cube.gameObject.SetActive(false);
        _cubes.Enqueue(cube);
    }
}
