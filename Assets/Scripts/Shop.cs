using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandartTurret()
    {
        BuildManager.instance.SetTurretToBuild(buildManager.standartTurretPrefab); 
    }

    public void PurchaseAnotherTurret()
    {
        BuildManager.instance.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
