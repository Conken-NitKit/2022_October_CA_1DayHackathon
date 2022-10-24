using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using NaughtyAttributes;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Main _main;

    [SerializeField] private Stage _stage;

    private int nowLevel;
    
    private void Start()
    {
        nowLevel = (int)Mathf.Floor(1 + Mathf.Sqrt(8 * _main.reachedStageNum - 7) / 2);
        Debug.Log(nowLevel);
        _stage.GenerateStage(nowLevel);
    }

    [Button]
    public void ClearStage()
    {
        _main.PassMainToMain();
    }
    
    [Button]
    public void GameOver()
    {
        _main.PassMainToResult(nowLevel);
    }
}
