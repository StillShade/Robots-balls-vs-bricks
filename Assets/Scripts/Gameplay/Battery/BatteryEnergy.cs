using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryEnergy : MonoBehaviour
{
    /*
    * ����� ����: ������� �� �������.
   ���� ���������: 
   1) ������ ���, ��� �� ��������� ����� -> �������� ���� �������
   2) ������� ���-�� ������� - 3
   3) ���������� ������� ����� ����������� ��������� ����� ��������� �������
   4) ������������ ��������� ���-�� ������� - 10 (���� ���) */

    //ToDo �������� ������ ����������/�������� ������ � PlayerPrefs ��� Json � ������ �������
    // ����� ������ ���� ������ ���������� ����� �������

    [SerializeField] private bool HasEnergy = true;
    [SerializeField] private bool IsActive = false;

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
        isActive = IsActive;
    }
}
