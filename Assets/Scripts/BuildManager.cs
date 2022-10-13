using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject standartTurretPrefab;
    public static BuildManager instance;
    private GameObject turretToBuild;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }      
    }
    private void Start()
    {
        turretToBuild = standartTurretPrefab;
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;   
    }
}
