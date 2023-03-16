using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryEnergy : MonoBehaviour
{
    //ToDo �������� ������ ����������/�������� ������ � PlayerPrefs ��� Json � ������ �������
    // ����� ������ ���� ������ ���������� ����� �������

    [SerializeField] private bool HasEnergy = true;
    [SerializeField] private bool IsActive = false;

    [Header("Child objects")]
    [SerializeField] private Transform chargeIndicator;
    [SerializeField] private Transform topLeftIndicator;
    [SerializeField] private Transform topRightIndicator;

    [Header("Charge indicator sprites")]
    [SerializeField] private Sprite dischargedIndicatorSprite;
    [SerializeField] private Sprite activeChargeIndicatorSprite;
    [SerializeField] private Sprite chargedIndicatorSprite;

    [Header("Top indicator sprites")]
    [SerializeField] private Sprite dischargedTopIndicatorSprite;
    [SerializeField] private Sprite activeTopIndicatorSprite;
    [SerializeField] private Sprite chargedTopIndicatorSprite;

    private Image topLeftSprite;
    private Image topRightSprite;
    private Image chargeIndicatorSprite;

    private void Awake()
    {   
        topLeftSprite = topLeftIndicator.GetComponent<Image>();
        topRightSprite = topRightIndicator.GetComponent<Image>();
        chargeIndicatorSprite = chargeIndicator.GetComponent<Image>();
    }

    public bool HasBatteryEnergy()
    {
        return HasEnergy;
    }

    public bool IsBatteryActive()
    {
        return IsActive;
    }

    public void SetBatteryEnergy(bool IsCharged)
    {
        HasEnergy = IsCharged;
    }

    public void SetBatteryActive(bool isActive)
    {
        IsActive = isActive;
    }

    public void SetIndicatorSprites(BatteryStates state)
    {
        if (state == BatteryStates.DISCHARGED)
        {
            ChangeSprites(dischargedTopIndicatorSprite, dischargedIndicatorSprite);
        }
        if (state == BatteryStates.ACTIVE)
        {
            ChangeSprites(activeTopIndicatorSprite, activeChargeIndicatorSprite);
        }
        if (state == BatteryStates.CHARGED)
        {
            ChangeSprites(chargedTopIndicatorSprite, chargedIndicatorSprite);
        }
    }

    private void ChangeSprites(Sprite topIndicatorSprite, Sprite indicatorSprite)
    {
        topLeftSprite.sprite = topIndicatorSprite;
        topRightSprite.sprite = topIndicatorSprite;
        chargeIndicatorSprite.sprite = indicatorSprite;
    }
}

public enum BatteryStates
{
    CHARGED, ACTIVE, DISCHARGED
}
