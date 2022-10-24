using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// エネミー目線でプレイヤーがいるかどうか判別するクラス
/// </summary>
public class EnemyEye : MonoBehaviour
{
    [SerializeField]
    private Enemy _enemy;
    
    /// <summary>
    ///　
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!other.gameObject.GetComponent<PlayerStaus>().isHide)
            {
                _enemy.ChasePlayer();
            }
        }
    }    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<PlayerStaus>().isHide)
            {
                _enemy.MoveNormal();
            }
        }
    }

}
