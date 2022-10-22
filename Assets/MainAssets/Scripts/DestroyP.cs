using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyP : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            Renderer _renderer;
            _renderer = this.gameObject.GetComponent<Renderer>();
            _renderer.enabled = false;
        }
    }
}
