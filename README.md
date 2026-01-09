[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Preferred name: Nansong Sun (he/him)

I started MG1 without a clear written plan. When I first tried to implement planting, I wrote the logic in the Player script, but nothing appeared in the scene because I didn’t actually have a Plant prefab to reference. At office hours, the professor helped me create a plant prefab (in the Prefabs folder), and after that I could assign it to the Player (Script) -> Plant Prefab field in the Inspector. Once _plantPrefab was properly assigned, Player.PlantSeed() started working as intended by calling Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity).

After planting worked, my next major issue was the UI. The template UI uses four Text objects on the Canvas: two labels and two number fields. In the Hierarchy they are Text_SeedsPlanted, Text_SeedsPlantedNum, Text_SeedsRemaining, and Text_SeedsRemainingNum. At first, my UI text duplicated after pressing Play because I was updating the number fields with the full label text (e.g., setting _plantedText.text = "Seeds Planted: " + seedsPlanted). This caused the label to appear twice.

I fixed it by keeping the labels as separate GameObjects and only updating the numeric TMP texts in PlantCountUI.UpdateSeeds(int seedsLeft, int seedsPlanted). I attached PlantCountUI to the Canvas and linked its references to the two number objects (Text_SeedsPlantedNum and Text_SeedsRemainingNum). Then UpdateSeeds() only sets the numbers using seedsPlanted.ToString() and seedsLeft.ToString(), which stopped the duplicated UI.

Once these references were correctly wired, the project matched the MG1 requirements: the Player moves with WASD/arrow keys in Player.Update(), pressing Space calls PlantSeed(), the scene starts with no plants (only plant(Clone) objects created at runtime), and the UI counters update correctly.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
