using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    /// <summary>
    /// 値をもらう関数
    /// </summary>
    /// <param name="colorCode"></param>
    /// <param name="characterName"></param>
    public void SetArguments(string playerName)
    {
    }
    public async void PassMainToGameOver()
    {
        //var sceneB = await SceneLoader.Load<GameOver>("GameOver");
        //sceneB.SetArguments(battleGameManager.enemyKillNum - 1,charaName);
    }
}
