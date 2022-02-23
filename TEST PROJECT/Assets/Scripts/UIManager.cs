using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class UIManager : MonoBehaviour
{
    public Image ImageCurrentGun;
    public Image HitPosinsPlayer;
    public Text TextGameOver;
    public WeaponIconsScriptableObject IconsData;
    public void SetHitPointsProgress(float progress)
    {
        if (progress <= 0)
        {
            HitPosinsPlayer.fillAmount = 0;
        }
        else if (progress >= 1)
        {
            HitPosinsPlayer.fillAmount = 1;
        }
        else
        {
            HitPosinsPlayer.fillAmount = progress;
        }
    }

    private void Start()
    {
        GameManager.Instance.PlayerObject.GetComponent<WeaponSelector>().OnWeaponChanged.AddListener(WeaponChanged);
    }

    private void WeaponChanged(Weapon weapon)
    {
        ImageCurrentGun.sprite = IconsData.WeaponIcons.Find( icon => icon.BulletName == ((BulletWeapon)weapon).BulletName).Sprite;
    }

    public void ShowTextGameOver()
    {
        TextGameOver.gameObject.SetActive(true);
    }
}
