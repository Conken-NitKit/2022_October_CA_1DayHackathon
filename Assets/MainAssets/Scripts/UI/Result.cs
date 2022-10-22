using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// リザルトのシーン遷移管理クラスです。
/// </summary>
public class Result : MonoBehaviour
{
    private string _playerName;
    private int _reachedStageNum;
    
    public void SetArguments(string playerName,int reachedStageNum)
    {
        _playerName = playerName;
        _reachedStageNum = reachedStageNum;
    }
    
    /// <summary>
    /// これ呼び出したらゲームモードにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassTitleToGameMode()
    {
        var nextScene = await SceneLoader.Load<GameMode>("GameMode");
        nextScene.SetArguments(_playerName);
    }
}