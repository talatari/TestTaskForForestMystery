using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]

public class HeroController : MonoBehaviour
{
    [SerializeField] private float _heroSpeed = 300.0f;
    [SerializeField] private float _heroJumpPower = 5.0f;
    [SerializeField] private float _speed;
	[SerializeField] private float _heroRunOn = 3.0f;
    [SerializeField] private float _heroRunOff = 1.0f;
    [SerializeField] private int MainMenuIndex = 0;
	
	private Vector2 _heroMoveVector;
    private string _X = "Horizontal";
    private float _heroStartPositionY = -1.5f;
    private int _Y = 1;
    private float _heroRunRate;
	
	Rigidbody2D _heroRigidBody;
    SpriteRenderer _heroSpriteRenderer;
	
    void Start()
    {
        _heroRigidBody = GetComponent<Rigidbody2D>();
        _heroSpriteRenderer = GetComponent<SpriteRenderer>();

        _heroRunRate = _heroRunOff;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            RunHero();
        }

        if (Input.GetKey(KeyCode.A) == true ||
           (Input.GetKey(KeyCode.D) == true))
        {
            MoveHero();
        }

        if (Input.GetKey(KeyCode.Space) == true ||
           (Input.GetKey(KeyCode.W) == true))
        {
            JumpHero();
        }

        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            MenuGame();
        }
    }

    void RunHero()
    {
        if (_heroRunRate == _heroRunOff)
        {
            _heroRunRate = _heroRunOn;
        }
        else
        {
            _heroRunRate = _heroRunOff;
        }
    }

    void MoveHero()
    {
        _heroMoveVector.x = Input.GetAxis(_X);
        _speed = _heroMoveVector.x * _heroSpeed * _heroRunRate * Time.deltaTime;
        _heroRigidBody.velocity = new Vector2(_speed,
                                              _heroRigidBody.velocity.y);

        FlipHero();
    }

    void FlipHero()
    {
        if (_heroMoveVector.x > 0)
        {
            _heroSpriteRenderer.flipX = false;
        }
        else if (_heroMoveVector.x < 0)
        {
            _heroSpriteRenderer.flipX = true;
        }
    }

    void JumpHero()
    {
        if (gameObject.transform.position[_Y] < _heroStartPositionY)
        {
            _heroRigidBody.velocity = new Vector2(_heroRigidBody.velocity.x,
                                                  _heroJumpPower);
        }
    }

    void MenuGame()
    {
        SceneManager.LoadScene(MainMenuIndex);
    }
}