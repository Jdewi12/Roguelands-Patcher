# Roguelands Patcher
Uses Octodiff to automatically install a patch for Roguelands.

**To install**
1. Go to [releases](https://github.com/Jdewi12/Roguelands-Patcher/releases) and click on `Roguelands.Patcher.zip` under the latest release to download it
2. Extract the contents of the zip file
3. Go to the location you extracted the files to and run `Roguelands Patcher.exe`
4. In the window that opens, press `Select File` and select your Roguelands.exe (if you installed via steam, this is usually in `Program Files (x86)\Steam\steamapps\common\Roguelands`
5. Click `Patch` and if everything worked correctly it should output `Successfully patched.` 
6. Close the patcher and now when you run Roguelands it will be modified with my changes.

**To uninstall**
When I stop being lazy I will make this an option in the patcher, but for now:
1. Navigate to your Roguelands installation folder (if you installed via steam, this is usually in `Program Files (x86)\Steam\steamapps\common\Roguelands`
2. Go to the `Roguelands_Data` folder, and then the `Managed` folder
3. Delete `Assembly-CSharp.dll`
4. Rename `Original_Assembly-CSharp.dll` to `Assembly-CSharp.dll` (case sensitive)
5. Now when you run Roguelands it should be the original version.

**Changelog** (WIP, probably missing a lot):

**Latest Changes**:
- Made it so 50 World Fragments can be turned into a glob of aether at the Emblem Forge, and globs can now be used much faster (~10 times per second)
- Made it so attacks, items, and skills can be used at the maximum speed by holding the key down
- Reworked the hp regen formula. Time between regen ticks = Max(1000 / (VIT + 66.67 + 5 * RegenMods) - 0.025 * RegenMods + 0.1 , 0.1). This means there's no longer a cap of one tick per 1.25 seconds, making a vitality + hp regen build more viable.
- Made volume for sound and music scale to 20, for people like me who found volume on 1 still too loud sometimes.
- Made the gear exp chalice now also give player exp.


**Older Changes**:
- Made gear exp from killing/harvesting scale with challenge level, rather than getting a flat bonus
- Changed explorer to "Explorers value discover more than anything. Explorers regen 2 stamina per tick instead of 1."
- Levelup effects like Antihero, Scientist, Baby Sliver, etc. that used to have randomness are now consistent and alternating
- Removed the randomness from item/chip costs on Old Earth
- Made the size of Healing Ward and Angelic Augur scale with FTH. Base size is 80% old size, and each fth point adds 1% to size. e.g. 220 fth is triple the size.
- Made enemies start targeting the nearest player when they take damage, regardless of range. Stops people from killing offscreen enemies easily.
- Changed carbine cost to 5 stamina, to match Gruu talisman
- Make enemy hp scale in multiplayer (makes singleplayer a bit easier)
- Scaled high hp numbers down (only really noticeable on enemies with over 2.5mil hp. A 6 million health boss in singleplayer would have around 3.6 million health, but with 4 players it would have around 7.6 million health
- Slightly make globs of aether scale with level, so they are slightly useful
- Slight bonus exp from high health enemies (only really noticeable on bosses)
- Probably makes the game too easy, but changed stamina into a resource that works like mana, and made dashes etc. free. DEX and STR chips now consume stamina, and TEC chips consume half stamina and half mana (rounded up, so 5 cost grenades cost 3 of each). It feels a bit op since players end on 100 mana and 100 stamina. Also changed all stamina potions to scale like mana potions.
- Fixed Eye Gadget to give DEX instead of TEC and made Oculus Goggles give the bonus TEC on level up
- Removed the zoom effect and black bars from combat mode
- Made combat chips stored globally except the hotbar, and ironman characters still have their own chip inventory. 
- Nerfed Elixir since it was a health pack III + mana pack III + stamina pack III, for the price of one. Changed from 12 health, 30 mana, 100 (30 with previous changes) stamina to 10 health, 25 mana, and 25 stamina.
- Possibly fixed a bug where Exodus didn't drop armor
- Added some random spawns from other levels to demon's rift, to make its difficulty similar to cathedral
- Fixed Hyperbeam and Scheg's Bow in multiplayer
- Fixed Angelic Augur and Prism in multiplayer
- Changed exp curve
- Probably a lot more I forgot about

&nbsp;

When compiling from source, make sure Octodiff.exe, Auto-Octodiff.exe (or whatever the patcher is named), and the patch file are all in the same folder. The patch file needs to just be named "patch". You can replace the patch with any other patch created with Octodiff.
