using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームオーバーのシーン遷移管理クラスです。
/// </summary>
public class GameMode : MonoBehaviour
{
    private string _playerName;
    
    /// <summary>
    /// 値をもらう関数
    /// </summary>
    public void SetArguments(string playerName)
    {
        _playerName = playerName;
    }
    
    /// <summary>
    /// これ呼び出したらメインにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassGameModeToMain()
    {
        var nextScene = await SceneLoader.Load<Main>("Main");
        nextScene.SetArguments(_playerName,0);
    }
}
