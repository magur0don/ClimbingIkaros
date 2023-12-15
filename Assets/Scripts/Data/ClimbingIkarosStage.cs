using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CreateAssetMenuの属性を付けることでUnityEditor上の右クリックから作成することが可能となります。
/// </summary>
[CreateAssetMenu(menuName = "ScriptableObjects/ClimbingIkarosStage")]
public class ClimbingIkarosStage : ScriptableObject
{
    /// <summary>
    /// Stageの名前
    /// </summary>
    [SerializeField]
    public string StageName = "地上";

    /// <summary>
    /// ゲームをクリアするための高さ
    /// </summary>
    [SerializeField]
    public float ClearHeight = 100;

}
