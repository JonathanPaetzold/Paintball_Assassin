using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Prototype.NetworkLobby {	
	public class ColorHook : LobbyHook  {
 		public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager,
			GameObject lobbyPlayer, GameObject gamePlayer) {
			LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer> ();
			PlayerColor player = gamePlayer.GetComponent<PlayerColor> ();
			player.color = lobby.playerColor;

		}

	}

}