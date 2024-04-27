using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Cube : MonoBehaviour
{
    private Renderer _renderer;
    private bool IsCollidedWithGround = false;
    private int _minTimeDeletion = 2;
    private int _maxTimeDeletion = 6;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Ground ground))
        {
            if (IsCollidedWithGround == false)
            {
                _renderer.material.color = Random.ColorHSV();
                IsCollidedWithGround = true;

               StartCoroutine(ground.DeliteCube(this, _minTimeDeletion, _maxTimeDeletion));
            }
        }    
    }
}
