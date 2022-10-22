using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class EnemyUnderEye : MonoBehaviour
{
    [SerializeField]
    private Enemy _enemy;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Stage"))
        {
            if (!other.GetComponent<Renderer>().enabled)
            {
                _enemy.InvertEnemyDirection();
            }
        }
    }
}
