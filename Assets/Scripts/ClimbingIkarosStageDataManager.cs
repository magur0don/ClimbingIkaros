using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingIkarosStageDataManager : MonoBehaviour
{
    /// <summary>
    /// ステージのデータ
    /// </summary>
    public ClimbingIkarosStage ClimbingIkarosStage;

    /// <summary>
    /// クリア用の高さを外部から取得するようのアクセサ
    /// </summary>
    public float GetClearHeight
    {
        get { return ClimbingIkarosStage.ClearHeight; }
    }

}
