using UnityEngine;

public class RotationSky : MonoBehaviour
{
    #region PublicField
    /// <summary>��]���x</summary>
    public float rotateSpeed;
    /// <summary>��̃}�e���A��</summary>
    public Material sky;
    #endregion

    #region UnityEvent
    void Update()
    {
        // �X�J�C�h�[������]�����鏈��
        var rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + rotateSpeed, 360f);
        sky.SetFloat("_Rotation", rotationRepeatValue);
    }
    #endregion
}
