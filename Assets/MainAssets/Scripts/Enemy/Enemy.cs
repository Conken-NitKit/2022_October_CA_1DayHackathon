using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// TODO : UniRx使って実装します
/// </summary>
public class Enemy : MonoBehaviour
{
    private bool _watchPlayer;

    private bool _isChangingEnemyMove;

    private float _enemySpeed;

    private const float NormalEnemySpeed = 0.5f;
    private const float ChaseEnemySpeed = 1f;

    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    
    private void Start()
    {
        _watchPlayer = false;
        _enemySpeed = NormalEnemySpeed;
    }

    private void FixedUpdate()
    {
        if (!_isChangingEnemyMove)
        {
            MoveStage();
        }
    }

    public void ChasePlayer()
    {
        _enemySpeed = ChaseEnemySpeed;
    }

    public void MoveNormal()
    {
        _enemySpeed = NormalEnemySpeed;
    }

    private void MoveStage()
    {
        _rigidbody2D.velocity = new Vector3(_enemySpeed, 0);
    }
}
