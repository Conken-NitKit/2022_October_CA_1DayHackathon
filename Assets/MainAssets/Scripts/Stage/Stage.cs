using System.Collections;
using System.Collections.Generic;
using Shapes2D;
using Unity.VisualScripting;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> stageObujects = new List<GameObject>();

    [SerializeField] 
    private List<Transform> generateTransforms = new List<Transform>();

    private void Start()
    {
        GenerateStage();
    }
    public void GenerateStage()
    {
        var nowLevel = 1;
        for (int i = 0; i < generateTransforms.Count; i++)
        {
            Instantiate(stageObujects[Random.Range(0,nowLevel * 10)], generateTransforms[i].position, Quaternion.identity);
        }
    }
}
