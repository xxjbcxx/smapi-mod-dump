# Wear More Rings

## Description
Adds 4 additional ring slots to your inventory.

## Dependencies
This mod requires the following mods to be installed:

* [SMAPI](https://www.nexusmods.com/stardewvalley/mods/2400)
* [StardewHack](https://www.nexusmods.com/stardewvalley/mods/3213)

## Known bugs
Please report bugs on [GitHub](https://github.com/bcmpinc/StardewHack/issues).

* The mod changes the network protocol. So when playing multiplayer, all players must have this mod installed.
* While rings from the [Giant Crop Ring](https://www.nexusmods.com/stardewvalley/mods/1182) mod can be equipped in the additional slots, their effects won't be applied. Rings from the [MoreRings](https://www.nexusmods.com/stardewvalley/mods/2054) mod, v1.0.3+ should work though.
* The additional ring slots are invisible when the [Bigger Backpack](https://www.nexusmods.com/stardewvalley/mods/1845) mod has been installed. Despite being invisible, they can still be clicked to (un)equip rings.

## Changes
#### 1.0:
* Created this mod. It hasn't been extensively tested and hence might still have some bugs.

#### 1.1:
* Fixed horse animation and dismounting bug.

#### 1.2:
* Added Mod Integration API, [IWearMoreRingsAPI](https://github.com/bcmpinc/StardewHack/blob/master/WearMoreRings/IWearMoreRingsAPI.cs), for mods that add new types of rings.
* Fixed error due to save methods being called on multiplayer clients.
* Fixed issue with unequipping one ring disabling the glow effect of all rings.
* Fixed rings disappearing when shift+clicking them in your inventory.

#### 1.3:
* Fix exception during startup on windows.

#### 1.4:
* Fixed old rings not working & disappearing on save&reload (hopefully).


