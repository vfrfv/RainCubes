using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Cube : MonoBehaviour
{
    private Renderer _renderer;
    private bool IsChangedColor = false;
    private int _minTimeDeletion = 2;
    private int _maxTimeDeletion = 6;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (IsChangedColor == false)
        {
            _renderer.material.color = Random.ColorHSV();
            IsChangedColor = true;

            StartCoroutine(Die());
        }
    }

    private IEnumerator Die()
    {
        yield return new WaitForSeconds(Random.Range(_minTimeDeletion, _maxTimeDeletion));

        Destroy(gameObject);
    }
}
