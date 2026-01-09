[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Preferred name: Nansong Sun (he/him)
I literally didnt have a plan after I tried to code for MG1.. with some help I wrote some code that could have made it work in imaginary situation..
Then I found I literally coded nothing because there was no prefab. Maybe I changed it myself when I had no conciousness:(
I attended officehour and professor helped me to slice one prefab and thats when everything started to flow
After a long time fighting with the code the player object started to move and plant appropriately, then  I found another challenge:
The UI became four pieces after I hit play button, and it hides itself carefully when in the scene( everything looked ok before playing)
I fixed it by changing the updateseeds method from things like this _plantedText.text = "Seeds Planted: " + seedsPlanted;
_remainingText.text = "Seeds remaining: " + seedsLeft;
to like this   if (_plantedText != null) _plantedText.text = seedsPlanted.ToString();
    if (_remainingText != null) _remainingText.text = seedsLeft.ToString();

Then everything was on its move. its a small project but a big success for me....



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
