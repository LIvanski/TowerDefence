using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject standartTurretPrefab;
    public GameObject anotherTurretPrefab;
    public static BuildManager instance;
    private GameObject turretToBuild;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }      
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;   
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
