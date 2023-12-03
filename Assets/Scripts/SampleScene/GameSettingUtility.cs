using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームの設定データ
/// staticは静的という意味なので、どこからでもアクセスできます
/// </summary>
public static class GameSettingUtility 
{
    /// <summary>
    /// Playerの定数
    /// </summary>
    public const string PlayerTagName = "Player";

    /// <summary>
    /// Groundのレイヤー№
    /// </summary>
    public const int GroundLayerNumber = 6;

    /// <summary>
    /// 動くステージの横移動の係数
    /// </summary>
    public const float MoveStageHorizontalFactor = 0.01f;
}
