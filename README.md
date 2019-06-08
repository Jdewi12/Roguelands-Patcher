# Roguelands Patcher
Uses Octodiff to automatically install a patch for Roguelands.

&nbsp;

Changelog (WIP, probably missing a lot):
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
