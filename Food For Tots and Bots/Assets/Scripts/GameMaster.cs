using Unity.Netcode;
using UnityEngine;
using static Unity.Netcode.NetworkManager;

public class GameMaster : MonoBehaviour
{
    public NetworkManager NetworkManager;
	private bool started;
	private bool showingLabels;
	private void Update()
	{
		if (started && !showingLabels)
		{
			showingLabels = true;
			StatusLabels();
		}
	}
	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(10, 10, 300, 300));
		if (!NetworkManager.IsClient && !NetworkManager.IsServer)
		{
			StartButtons();
		}
		else
		{
			StatusLabels();

			SubmitNewPosition();
		}

		GUILayout.EndArea();
	}

	private void StartButtons()
	{
		if (GUILayout.Button("Host"))
		{
			Debug.Log("Host should have started");
			NetworkManager.ConnectionApprovalCallback = AutoApproveClient;
			started = NetworkManager.StartHost();
		}
		if (GUILayout.Button("Client")) NetworkManager.StartClient();
		if (GUILayout.Button("Server")) NetworkManager.StartServer();
	}
	private void AutoApproveClient(ConnectionApprovalRequest request, ConnectionApprovalResponse response)
	{
		// Your approval logic determines the following values
		response.Approved = true;
		response.CreatePlayerObject = true;
		response.Pending = false;
	}
	private void StatusLabels()
	{
		var mode = NetworkManager.IsHost ?
			"Host" : NetworkManager.IsServer ? "Server" : "Client";

		GUILayout.Label("Transport: " +
			NetworkManager.NetworkConfig.NetworkTransport.GetType().Name);
		GUILayout.Label("Mode: " + mode);
	}

	private void SubmitNewPosition()
	{
		if (GUILayout.Button(NetworkManager.IsServer ? "Move" : "Request Position Change"))
		{
			if (NetworkManager.IsServer && !NetworkManager.IsClient)
			{
				foreach (ulong uid in NetworkManager.ConnectedClientsIds)
					NetworkManager.SpawnManager.GetPlayerNetworkObject(uid).GetComponent<PottedPlantController>().Move();
			}
			else
			{
				var playerObject = NetworkManager.SpawnManager.GetLocalPlayerObject();
				var player = playerObject.GetComponent<PottedPlantController>();
				player.Move();
			}
		}
	}
}

