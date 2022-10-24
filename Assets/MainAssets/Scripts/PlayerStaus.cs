using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStaus : MonoBehaviour
{
    public bool isHide;

    [SerializeField]
    private Renderer _renderer;

    [SerializeField]
    private Collider2D collider2D;

    private void Start()
    {
        isHide = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isHide)
        {
            isHide = true;
            _renderer.enabled = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && isHide)
        {
            isHide = false;
            _renderer.enabled = true;
        }
    }
}
