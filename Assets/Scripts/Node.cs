using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;

    // Awake is called when the script instance is being loaded
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    // OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider
    private void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen.");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    // OnMouseEnter is called when the mouse entered the GUIElement or Collider
    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
