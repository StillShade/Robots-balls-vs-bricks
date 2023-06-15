using UnityEngine;
using TMPro;

public class UITopStatsPanel : MonoBehaviour
{
    // ������� ������ ������
    public int levelScene;
    public int healthLevel;
    public int attackLevel;
    public int starterBallsLevel;
    public int sightLengthLevel;

    // ������ ��� ����������� �������/��������
    [SerializeField] private TextMeshProUGUI levelValueText;
    [SerializeField] private TextMeshProUGUI coinsValueText;
    [SerializeField] private TextMeshProUGUI healthLevelText;
    [SerializeField] private TextMeshProUGUI attackLevelText;
    [SerializeField] private TextMeshProUGUI starterBallsLevelText;
    [SerializeField] private TextMeshProUGUI sightLengthLevelText;

    // ������� ������
    [SerializeField] private Transform healthStatPrefab;
    [SerializeField] private Transform attackStatPrefab;
    [SerializeField] private Transform starterBallsStatPrefab;
    [SerializeField] private Transform sightLengthStatPrefab;

    // ����������� ��������
    private HealthPrefabController healthPrefabController;
    private AttackPrefabController attackPrefabController;
    private StarterBallsPrefabController starterBallsPrefabController;
    private SightLengthPrefabController sightLengthPrefabController;

    private void Start()
    {
        // ���������� ����������� ��������
        healthPrefabController = healthStatPrefab.GetComponent<HealthPrefabController>();
        attackPrefabController = attackStatPrefab.GetComponent<AttackPrefabController>();
        starterBallsPrefabController = starterBallsStatPrefab.GetComponent<StarterBallsPrefabController>();
        sightLengthPrefabController = sightLengthStatPrefab.GetComponent<SightLengthPrefabController>();
    }

    private void OnEnable()
    {
        // ���������, ��� ����������� �� null, ����� ����� ������� ������,
        // ����� �� �������� �������� �������� ��������
        if (healthPrefabController == null || attackPrefabController == null || starterBallsPrefabController == null || sightLengthPrefabController == null)
            return;
        UpdateValuesAndPrefabs();
        ShowLevelValues();
    }

    private void ShowLevelValues()
    {
        levelValueText.text = $"LEVEL {SaveManager.LoadSceneData()}"; ;
        healthLevelText.text = $"{healthLevel}";
        attackLevelText.text = $"{attackLevel}";
        starterBallsLevelText.text = $"{starterBallsLevel}";
        sightLengthLevelText.text = $"{sightLengthLevel}";
    }

    private void UpdateValuesAndPrefabs()
    {
        // �������� ���������� ��� ����������� ��� �����������?, ����� ��������� � ��� ��� �����, ��������
        healthPrefabController.LoadHealthLevelAndShowSprite();
        attackPrefabController.LoadAttackLevelAndShowSprite();
        starterBallsPrefabController.LoadStarterBallsLevelAndShowSprite();
        sightLengthPrefabController.LoadSightLengthLevelAndShowSprite();

        LoadLevelValues();
    }

    private void LoadLevelValues()
    {
        // ���������� �������� ������� ������� ��� ������
        // levelScene = ???
        healthLevel = healthPrefabController.CurrentHealthLevel;
        attackLevel = attackPrefabController.CurrentAttackLevel;
        starterBallsLevel = starterBallsPrefabController.CurrentBallsLevel;
        sightLengthLevel = sightLengthPrefabController.CurrentSightLengthLevel;
    }
}
