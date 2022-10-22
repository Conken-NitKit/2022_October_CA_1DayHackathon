using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// TODO : UniRx使って実装します
/// エネミーの処理管理クラス
/// </summary>
public class Enemy : MonoBehaviour
{
    private bool _isChangingEnemyMove;

    private float _enemySpeed;
    private float _defaultSpeed = -0.5f;

    private const float NormalEnemySpeed = 0.5f;
    private const float ChaseEnemySpeed = 2f;

    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    
    private void Start()
    {
        _enemySpeed = _defaultSpeed;
    }

    private void FixedUpdate()
    {
        if (!_isChangingEnemyMove)
        {
            _rigidbody2D.velocity = new Vector3(_enemySpeed, 0);
        }
    }
    
    /// <summary>
    /// プレイヤーを追いかける速度に変更するクラス
    /// </summary>
    public void ChasePlayer()
    {
        _enemySpeed = _defaultSpeed;
        _enemySpeed *= ChaseEnemySpeed;
    }

    /// <summary>
    /// プレイヤーを追いかけない時の速度に変更するクラス
    /// </summary>
    public void MoveNormal()
    {
        _enemySpeed = _defaultSpeed;
        _enemySpeed *= NormalEnemySpeed;
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            InvertEnemyDirection();
        }

        if (other.gameObject.CompareTag("Player"))
        {
            if (true /*!other.GetComponent<Player>().isHide*/)
            {
                Debug.Log("GameOver");
            }
        }
    }

    /// <summary>
    /// エネミーの向きを進む方向を変更するメソッド
    /// </summary>
    public void InvertEnemyDirection()
    {
        this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x * -1,
            this.gameObject.transform.localScale.y);
        _enemySpeed *= -1;
        _defaultSpeed *= -1;
    }
}
