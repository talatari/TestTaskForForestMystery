using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Enemy))]
public class EnemyController : MonoBehaviour
{
    [HideInInspector] public UnityEvent<Enemy> _enemyCollision;

    private Enemy _enemy;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
    }


}