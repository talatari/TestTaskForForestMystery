using UnityEngine;

public abstract class EnemySpawnSystem : MonoBehaviour
{
    [SerializeField] protected EnemyController _enemyController;

    protected virtual void Awake()
    {
        _enemyController._enemyCollision.AddListener(OnEnemyCollision);
    }

    protected virtual void OnDestroy()
    {
        _enemyController._enemyCollision.RemoveListener(OnEnemyCollision);
    }

    protected virtual void OnEnemyCollision(Enemy _enemy) { }


}