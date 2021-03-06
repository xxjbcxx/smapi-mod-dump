# Movement Speed

## Description
Changes the player's movement speed using a flat multiplier. 
As such it stacks properly with other speed modifiers, such as horses, coffee and being slimed.
It also reduces the charging time of the hoe and watering can.
The movement speed and charging times can be configured in the mod's `config.json`, see below.

## Config
*Note: run Stardew Valley once with this mod enabled to generate the `config.json` file.*

* `MovementSpeedMultiplier`: The movement speed is multiplied by this amount. The default is 1.5, meaning 50% faster movement. Set this to 1 to disable the increase in movement speed. 
* `ToolChargeDelay`: Time required for charging the hoe or watering can in ms. Normally this is 600ms. The default is 600/1.5 = 400, meaning 50% faster charging. Set this to 600 to disable faster tool charging.

## Dependencies
This mod requires the following mods to be installed:

* [SMAPI](https://www.nexusmods.com/stardewvalley/mods/2400)
* [StardewHack](https://www.nexusmods.com/stardewvalley/mods/3213)

## Known bugs
Please report bugs on [GitHub](https://github.com/bcmpinc/StardewHack/issues).

## Changes
#### 0.4:
* Fixed incompatibility with Mouse Move Mode mod.
* Setting `MovementSpeedMultiplier: 1` or `ToolChargeDelay: 600` will disable the associated patch.

#### 1.0:
* Added dependency on StardewHack.
