using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPC_Dialog : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject toActivate;

    [SerializeField] private Transform standingPoint;

    private Transform avatar;

    private async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            avatar = other.transform;      

            // Disable player input
            avatar.GetComponent<PlayerInput>().enabled = false;

            await Task.Delay(50);

            // Teleport the avatar to standing point
            avatar.position = standingPoint.position;
            avatar.rotation = standingPoint.rotation;

            // Disable main cam, enable dialog cam
            mainCamera.SetActive(false);
            toActivate.SetActive(true);

            // Display cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Recover()
    {
        avatar.GetComponent<PlayerInput>().enabled = true;

        mainCamera.SetActive(true);
        toActivate.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    } 
}
