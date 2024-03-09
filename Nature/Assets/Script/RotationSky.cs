using UnityEngine;

public class RotationSky : MonoBehaviour
{
    #region PublicField
    /// <summary>回転速度</summary>
    public float rotateSpeed;
    /// <summary>空のマテリアル</summary>
    public Material sky;
    #endregion

    #region UnityEvent
    void Update()
    {
        // スカイドームを回転させる処理
        var rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + rotateSpeed, 360f);
        sky.SetFloat("_Rotation", rotationRepeatValue);
    }
    #endregion
}
