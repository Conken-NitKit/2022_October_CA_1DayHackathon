using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シーンごとのクラスの基盤クラス
/// </summary>
public abstract class SceneBase : MonoBehaviour { 
    public virtual void OnLoad(object options = null){}
}
