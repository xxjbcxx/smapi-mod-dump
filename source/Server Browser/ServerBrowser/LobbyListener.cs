﻿using Galaxy.Api;
using StardewValley;
using StardewValley.SDKs;
using System;
using System.Threading.Tasks;

namespace ServerBrowser
{
	class CreateGoGLobbyListener : Patch
	{
		protected override PatchDescriptor GetPatchDescriptor() => new PatchDescriptor(typeof(GalaxySocket), "tryCreateLobby");
		
		public static void Prefix(ref ServerPrivacy ___privacy, GalaxySocket __instance)
		{
			if (CoopMenuHolder.PublicCheckBox.IsChecked)
			{
				___privacy = ServerPrivacy.Public;
			}

			Console.WriteLine($"TRY CREATE LOBBY GALAXY, PRIVACY = {___privacy.ToString()}");
		}
	}

	class CreatedServerListener : Patch
	{
		protected override PatchDescriptor GetPatchDescriptor() => new PatchDescriptor(typeof(GalaxySocket), "onGalaxyLobbyEnter");

		public static void Postfix(GalaxyID lobbyID, LobbyEnterResult result)
		{
			if (result == LobbyEnterResult.LOBBY_ENTER_RESULT_SUCCESS)
			{
				ModEntry.CurrentCreatedLobby = lobbyID;
				ServerMetaData.InnitServer(lobbyID);
			}
			else
			{
				Console.WriteLine("Failed to create galaxy lobby: "+result);
			}
		}
	}

	class StopServerListener : Patch
	{
		protected override PatchDescriptor GetPatchDescriptor() => new PatchDescriptor(typeof(GalaxyNetServer), "stopServer");

		public static void Postfix()
		{
			ModEntry.CurrentCreatedLobby = null;
		}
	}
}
