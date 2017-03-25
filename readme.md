## Unity RPG Course - Section 2 - Core Combat
Section 2 our upcoming RPG course, see our course list [here](https://www.udemy.com/u/bentristem/). The full course is part of [this ](https://www.udemy.com/draft/1110626/?instructorPreviewMode=guest&password=earlyaccess) kickstarter campaign which was over 200% funded.

You're welcome to download, fork or do whatever else legal with all the files!

## How To Build / Compile
This is a Unity project. If you're familiar with source control, then "clone this repo". Otherwise download the contents, and navigate to `Assets > Levels` then open any `.unity` file.

This branch is the course branch, each commit corresponds to a lecture in the course. The current state is our latest progress.

## Lecture List
Here are the lectures of the course for this section...

### Section 2 Introduction ###

+ We’ll cover core combat in this section
+ We will focus on the simplest code solutions
+ You will also learn some play tuning…
+ … and create your first level

(Unique Video Reference: 1_CC_RPG)

### Attacking The Enemies Design ###

In this video...  
+ Attack requirements
+ CHALLENGE
+ Attack and movement distances

(Unique Video Reference: 2_CC_RPG)

### Using Gizmos To Visualise Code ###

In This Video…  
+ Introducing the Gizmos class in Unity
+ Import code to visualise movement
+ Adding attackStopMoveRadius
+ Prevent retreat when in radius
+ CHALLENGE.

(Unique Video Reference: 3_CC_RPG)

### Player Health Bar UI ###

In This Video…
+ Review structure of health bar pack
+ Export a custom package
+ Import custom package
+ Create Player class and test
+ CHALLENGE.

(Unique Video Reference: 4_CC_RPG)

### Enemy Floating Health Bar ###

In This Video…
+ Import Enemy Health Bar v.2.unitypackage
+ Explore how the package works
+ Create Enemy.cs and wire-up
+ CHALLENGE.

(Unique Video Reference: 5_CC_RPG )

### Ranged Attack Problem ###

In This Video…
+ Our current ranged attack problem
+ CHALLENGE
+ Diablo versus Torchlight 2 paradigms
+ Our design decision

(Unique Video Reference: 6_CC_RPG)

### Update Your 1 Page GDD ###

In this video...  
+ We discuss remaining sections of 1-Page GDD
+ We discuss Design Pillar
+ We discuss Remarkability
+ We'll look at what Darkest Dungeon does for their design pillar and remarkability
+ CHALLENGE

(Unique Video Reference: 7_CC_RPG)

### Set Your Art Direction ###

In this video...
+ Your feedback to us
+ We’re starting to juggle priorities - combat needs level, level needs art direction
+ Structure of Art Concept Document
+ CHALLENGE

(Unique Video Reference: 8_CC_RPG)

### Sketch Your Prototype Level ###

In this video...  
+ Designing your level - start with your level’s intention and requirements
+ How we are creating our village level
+ CHALLENGE

(Unique Video Reference: 9_2_RPG)

### Importing Level Assets ###

In this video...
+ We’ll import a level asset pack
+ Tidy up and prepare our scene
+ CHALLENGE

(Unique Video Reference: 10_2_RPG)

### Creating Terrain ###

In this video...
+ Terrain versus module assets approaches
+ Adding terrain and modifying it
+ Blocking out one moment in your level
+ CHALLENGE

(Unique Video Reference: 11_CC_RPG)

### Block Out Your Level ###

In this video...
+ Getting rough placement for all of your level moments.
+ Dealing with elevation and camera issues.
+ CHALLENGE

(Unique Video Reference: 12_CC_RPG)

### Review And Adjustments ###

In This Video…
+ Asset review and feedback for Mikey
+ Art review - an interesting mistake
+ Altering our level
+ Setup & Standards text file
+ CHALLENGE

(Unique Video Reference: 13_2_RPG)

### Commenting Your Level ###

In This Video…
+ Learnings and tips from blocking out level
+ Adding comments and references in your level
+ CHALLENGE.

(Unique Video Reference: 14_2_RPG)

### Standardising Scene Setup ###

In This Video…
+ Aside: why you need .psd.meta files
+ Scene folder structure and naming
+ Creating a best practices discussion
+ Everything should be a prefab!
+ CHALLENGE

(Unique Video Reference: 15_2_RPG)

### Help Writing Physics Code ###

In This Video…  
+ How importing asset packs affects your project
+ Bringing objects to life with script based rotation
+ How to use unit consistency to help you code
+ CHALLENGE
+ Why we keep root object scales at 1,1,1.

(Unique Video Reference: 16_2_RPG)

### Make Enemies Pathfind To Player ###

In This Video…
+ How to fix disappearing hard shadows
+ Add a navmesh to your terrain(s)
+ Add a Navmesh Agent to our enemy prefab
+ CHALLENGE.

(Unique Video Reference: 17_2_RPG)

### Fully Event Based Raycasting ###

In This Video…
+ The limitations of our current architecture
+ Import new CameraRaycaster.cs
+ Review what’s changed and why
+ Remove our Layer.cs script
+ Preview the editor script
+ CHALLENGE.

(Unique Video Reference: 18_2_RPG)

### Writing Custom Editors ###

In This Video…
+ Why you would want to extend Unity’s editor
+ Review **CameraRaycasterEditor.cs**
+ CHALLENGE - check your understanding.

(Unique Video Reference: 19_2_RPG)

### Player Pathfinding To Enemies ###

In this video...
+ Control your FOCUS - let’s move on
+ How to modify our player for pathfinding
+ CHALLENGE

(Unique Video Reference: 20_2_RPG)

### Prototyping Goals And Progress ###

In this video...
+ Recap our goals for prototyping
+ Where are you at with your goals - what is your score out of 10?
+ CHALLENGE.

(Unique Video Reference: 21_2_RPG)

### Refine Your Nav Mesh ###

In this video:  
+ Import latest art assets
+ Review distance, sizes, pacing in your level
+ Clean up Nav Mesh
+ CHALLENGE

(Unique Video Reference: 22_2_RPG )

### Tuning And Exploring ###

In This Video…
+ It’s important to experiment when prototyping
+ CHALLENGE.

(Unique Video Reference: 23_2_RPG)

### Importing Humanoid Animations ###

In This Video…
+ Humanoid character import settings
+ How to replace a character’s mesh
+ CHALLENGE.

(Unique Video Reference: 24_CC_RPG)

### Using Interfaces In C# ###

In This Video…
+ What an interface is in C#, and why they’re useful
+ Where and when to use them, e.g. **IDamageable**
+ Building a simple example scene.

(Unique Video Reference: 25_CC_RPG)

### Calling Methods Via Interfaces ###

In This Video…
+ How to find game objects by interface
+ How to call a method via an interface
+ Getting damage working on player and enemy
+ CHALLENGE.

(Unique Video Reference: 26_CC_RPG)

### Enemy Move And Attack Spheres ###

In this video...
+ How to find game objects by interface
+ How to call a method via an interface
+ Getting damage working on player and enemy
+ CHALLENGE.

(Unique Video Reference: 27_CC_RPG)

### Spawning Enemy Projectiles ###

In this video...
+ A quick recap of unit vectors, speed and velocity
+ Setup projectile prefab & attach to enemy
+ CHALLENGE

(Unique Video Reference: 28_CC_RPG)

### InvokeRepeating() vs StartCoroutine() ###

In this video...
+ How InvokeRepeating() is string referenced
+ StartCoroutine() is type safe, but more complex
+ A very quick overview of co-routines
+ Test enemies damaging player
+ CHALLENGE

(Unique Video Reference: 29_CC_RPG)

### Player Melee Damage ###

In this video...
+ Make enemies hit player in chest
+ Import dirty old hoe
+ Attach weapon to player’s hand
+ Make player target a single enemy
+ CHALLENGE

(Unique Video Reference: 30_CC_RPG)

### Creating Enemy Archetypes ###

+ Tidy up level, renaming and position weapon
+ Design 3 Archetypes - Archer, Minion, Bruiser
+ CHALLENGE

(Unique Video Reference: 31_CC_RPG)

### Health And Damage Philosophy ###

+ Check our WBS
+ Health and damage continuums
+ CHALLENGE

(Unique Video Reference: 32_CC_RPG)

### Start Your Stat Spreadsheet ###

+ Start your Stat Spreadsheet with some starting points
+ Update Player and Enemy stats in level
+ CHALLENGE

### Healing Companion Prototype ###

+ Using the tools we have
+ Creating a healer
+ CHALLENGE

### Level Story Theme And Flow ###

+ Give story flavour to your level flow
+ Create new enemies types
+ CHALLENGE

(Unique Video Reference: 35_CC_RPG)

### Playable Level With Combat ###

+ No two moments in your level should be the same
+ Place enemies and healing to make good combat flow
+ Test and tweak your level
+ CHALLENGE

(Unique Video Reference: 36_CC_RPG)


... more lectures coming soon!

---
Thanks for visiting, and enjoy your stay

Ben & The Team

[GameDev.tv](https://community.gamedev.tv)
