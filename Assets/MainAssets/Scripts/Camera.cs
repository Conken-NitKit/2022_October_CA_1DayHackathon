using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform camera;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hoge");
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            
            camera.DOMoveY(9.6f,0.5f).SetUpdate(true).OnComplete(() =>
            {
                Time.timeScale = 1f;
            });
        }
    }
}
