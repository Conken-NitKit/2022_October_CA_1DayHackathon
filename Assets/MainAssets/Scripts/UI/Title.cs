using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// タイトルのシーン遷移管理クラスです。
/// </summary>
public class Title : MonoBehaviour
{
    [SerializeField] 
    private Text playerName;

    /// <summary>
    /// これ呼び出したらゲームモードにシーン遷移してくれて次のシーンにプレイヤーの名前渡してくれます。
    /// </summary>
    public async void PassTitleToGameMode()
    {
        var nextScene = await SceneLoader.Load<GameMode>("GameMode");
        nextScene.SetArguments(playerName.text);
    }

}
