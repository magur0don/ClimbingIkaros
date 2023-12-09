using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthViewer : MonoBehaviour
{
    /// <summary>
    /// 体力管理用クラス
    /// </summary>
    public Health Health;

    /// <summary>
    /// 体力反映用のスライダー
    /// </summary>
    public Slider HealthSlider;

    private void Update()
    {
        // SliderのPositionにカメラの座標変換を使ってプレイヤーのポジション＋Y軸方向に1の値を代入し続ける
        this.HealthSlider.GetComponent<RectTransform>().position =
          Camera.main.WorldToScreenPoint(this.Health.gameObject.transform.position + Vector3.up);
        
        // 死んでいたらSliderに値を代入しないようにする
        if (Health.IsDead)
        {
            return;
        }
        // 現在体力/最大体力をすることによって、80/100だった場合0.8の値をSliderに与えることができる
        HealthSlider.value = Health.GetCurrentHealth / Health.MaxHealth;
    }
}
