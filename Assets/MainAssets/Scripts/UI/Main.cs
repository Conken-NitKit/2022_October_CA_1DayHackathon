using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// メインのシーン遷移管理クラスです。
/// </summary>
public class Main : MonoBehaviour
{
    private string _playerName;
    public int reachedStageNum;
    
    public void SetArguments(string playerName,int reachedStageNum)
    {
        _playerName = playerName;
        this.reachedStageNum = reachedStageNum;
    }
    /// <summary>
    /// これ呼び出したらメインにシーン遷移してくれて次のシーンにプレイヤーの名前と到達ステージ数渡してくれます。。
    /// </summary>
    public async void PassMainToResult(int lastLevel)
    {
        var nextScene = await SceneLoader.Load<Result>("Result");
        nextScene.SetArguments(_playerName,reachedStageNum,lastLevel);
    }
    
    /// <summary>
    /// これ呼び出したらメインにシーン遷移してくれて次のシーンにプレイヤーの名前と到達ステージ数渡してくれます。
    /// </summary>
    public async void PassMainToMain()
    {
        var nextScene = await SceneLoader.Load<Main>("Main");
        nextScene.SetArguments(_playerName,reachedStageNum + 1);
    }
}
