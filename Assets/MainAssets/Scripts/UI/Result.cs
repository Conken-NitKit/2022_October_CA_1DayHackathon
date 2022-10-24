using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// リザルトのシーン遷移管理クラスです。
/// </summary>
public class Result : MonoBehaviour
{
    [SerializeField] 
    private Text reachedStageNumText;

    [SerializeField] 
    private Text lastLevelText;

    [SerializeField] 
    private string _playerName;

    public void SetArguments(string playerName,int reachedStageNum,int lastLevel)
    {
        _playerName = playerName;
        reachedStageNumText.text = $"{reachedStageNum}";
        lastLevelText.text = $"{lastLevel}";
    }
    
    /// <summary>
    /// これ呼び出したらゲームモードにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassResultToGameMode()
    {
        var nextScene = await SceneLoader.Load<GameMode>("GameMode");
        nextScene.SetArguments(_playerName);
    }
    
    public async void PassResultToRanking()
    {
        var nextScene = await SceneLoader.Load<Ranking>("Ranking");
        nextScene.SetArguments(_playerName);
    }
}
