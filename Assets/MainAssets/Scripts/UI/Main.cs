using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// メインのシーン遷移管理クラスです。
/// </summary>
public class Main : MonoBehaviour
{
    private string _playerName;
    private int _reachedStageNum;
    
    public void SetArguments(string playerName,int reachedStageNum)
    {
        _playerName = playerName;
        _reachedStageNum = reachedStageNum;
    }
    /// <summary>
    /// これ呼び出したらリザルトにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassMainToResult()
    {
        var nextScene = await SceneLoader.Load<Result>("Result");
        nextScene.SetArguments(_playerName,_reachedStageNum);
    }
    
    /// <summary>
    /// これ呼び出したらメインにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassMainToMain()
    {
        var nextScene = await SceneLoader.Load<Main>("Main");
        nextScene.SetArguments(_playerName,_reachedStageNum);
    }
}
