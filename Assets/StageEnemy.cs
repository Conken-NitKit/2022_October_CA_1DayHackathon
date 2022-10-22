using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageEnemy : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    public float shotDelay = 3.0f;

// Use this for initialization
    IEnumerator Start () 
    {
        while (true)
        {
            shot();
            yield return new WaitForSeconds(shotDelay);
        }
    }

    private void shot()
    {
        // プレハブ生成
        Instantiate(Enemy, transform.position, transform.rotation);
    }
}
