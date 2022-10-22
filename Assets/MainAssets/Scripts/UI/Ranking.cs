using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
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
    /// これ呼び出したらゲームモードにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassRankingToGameMode()
    {
        var nextScene = await SceneLoader.Load<GameMode>("GameMode");
        nextScene.SetArguments(_playerName);
    }
}
