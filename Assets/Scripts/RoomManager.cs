using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject player;

    [Space]
    public Transform spawnPoint;

    private void Start()
    {
        Debug.Log("Connecting...");
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        Debug.Log("Connected to  Server");  

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();     
        PhotonNetwork.JoinOrCreateRoom("TestRoom", null, null);

        Debug.Log("we're a connected and in a room now");

        GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.position,  Quaternion.identity);
    }   
}



