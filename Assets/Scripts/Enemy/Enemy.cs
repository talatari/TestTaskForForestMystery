using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    private SpriteRenderer _spriteRendererEnemy;

    private void Awake()
    {
        _spriteRendererEnemy = GetComponent<SpriteRenderer>();
    }

    public void Init(Vector3 _position)
    {
        transform.position = _position + new Vector3(0, 0, 0);

        transform.eulerAngles = new Vector3(90, Random.Range(0, 360), 0);
    }


}