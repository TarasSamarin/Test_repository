using UnityEngine;

public class MonsterHPView : MonoBehaviour
{
    public Transform ParentSpriteView;
    public Transform HPBarSprite;

    private float sizeLine = 1;
    private float offLeftHpBar = -8f;
    private float offRightHpBar = -8f;

    public void SetProgressBar(float progress)
    {
        if (progress < 0)
        {
            sizeLine = 0;
        }
        else if (progress > 1)
        {
            sizeLine = 1;
        }
        else
        {
            sizeLine = progress;
        }
    }

    private void Update()
    {
        float offset = sizeLine * offRightHpBar - offLeftHpBar;
        HPBarSprite.transform.localScale = new Vector3(sizeLine, HPBarSprite.transform.localScale.y, HPBarSprite.transform.localScale.z);
        HPBarSprite.transform.localPosition = new Vector3( offset, HPBarSprite.transform.localPosition.y, HPBarSprite.transform.localPosition.z);
        ParentSpriteView.LookAt(Camera.main.transform.position);
    }
}
