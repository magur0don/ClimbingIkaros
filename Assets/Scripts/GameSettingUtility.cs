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
}
