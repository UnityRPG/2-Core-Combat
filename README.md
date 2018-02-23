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

+ Attack requirements
+ CHALLENGE
+ Attack and movement distances

(Unique Video Reference: 2_CC_RPG)

### Using Gizmos To Visualise Code ###

+ Introducing the Gizmos class in Unity
+ Import code to visualise movement
+ Adding attackStopMoveRadius
+ Prevent retreat when in radius
+ CHALLENGE.

(Unique Video Reference: 3_CC_RPG)

### Player Health Bar UI ###

+ Review structure of health bar pack
+ Export a custom package
+ Import custom package
+ Create Player class and test
+ CHALLENGE.

(Unique Video Reference: 4_CC_RPG)

### Enemy Floating Health Bar ###

+ Import Enemy Health Bar v.2.unitypackage
+ Explore how the package works
+ Create Enemy.cs and wire-up
+ CHALLENGE.

(Unique Video Reference: 5_CC_RPG )

### Ranged Attack Problem ###

+ Our current ranged attack problem
+ CHALLENGE
+ Diablo versus Torchlight 2 paradigms
+ Our design decision

(Unique Video Reference: 6_CC_RPG)

### Update Your 1 Page GDD ###

+ We discuss remaining sections of 1-Page GDD
+ We discuss Design Pillar
+ We discuss Remarkability
+ We'll look at what Darkest Dungeon does for their design pillar and remarkability
+ CHALLENGE

(Unique Video Reference: 7_CC_RPG)

### Set Your Art Direction ###

+ Your feedback to us
+ We’re starting to juggle priorities - combat needs level, level needs art direction
+ Structure of Art Concept Document
+ CHALLENGE

(Unique Video Reference: 8_CC_RPG)

### Sketch Your Prototype Level ###

+ Designing your level - start with your level’s intention and requirements
+ How we are creating our village level
+ CHALLENGE

(Unique Video Reference: 9_CC_RPG)

### Importing Level Assets ###

+ We’ll import a level asset pack
+ Tidy up and prepare our scene
+ CHALLENGE

(Unique Video Reference: 10_CC_RPG)

### Instructor Hangout 2.1

+ What we have covered so far
+ Answers to common questions
+ What's coming up in the next 10 lectures.

(Unique Video Reference: 10b_CC_RPG)

### Creating Terrain ###

+ Terrain versus module assets approaches
+ Adding terrain and modifying it
+ Blocking out one moment in your level
+ CHALLENGE

(Unique Video Reference: 11_CC_RPG)

### Block Out Your Level ###

+ Getting rough placement for all of your level moments.
+ Dealing with elevation and camera issues.
+ CHALLENGE

(Unique Video Reference: 12_CC_RPG)

### Review And Adjustments ###

+ Asset review and feedback for Mikey
+ Art review - an interesting mistake
+ Altering our level
+ Setup & Standards text file
+ CHALLENGE

(Unique Video Reference: 13_2_RPG)

### Commenting Your Level ###

+ Learnings and tips from blocking out level
+ Adding comments and references in your level
+ CHALLENGE.

(Unique Video Reference: 14_2_RPG)

### Standardising Scene Setup ###

+ Aside: why you need .psd.meta files
+ Scene folder structure and naming
+ Creating a best practices discussion
+ Everything should be a prefab!
+ CHALLENGE

(Unique Video Reference: 15_2_RPG)

### 16b Dimensional Analysis Primer ###

+ What is dimensional analysis?
+ Why would you care?
+ How to use it
+ Some worked examples.

### Help Writing Physics Code ###

+ How importing asset packs affects your project
+ Bringing objects to life with script based rotation
+ How to use unit consistency to help you code
+ CHALLENGE
+ Why we keep root object scales at 1,1,1.

(Unique Video Reference: 16_2_RPG)

### Make Enemies Pathfind To Player ###

+ How to fix disappearing hard shadows
+ Add a navmesh to your terrain(s)
+ Add a Navmesh Agent to our enemy prefab
+ CHALLENGE.

(Unique Video Reference: 17_2_RPG)

### 17b Don't Panic! ###

+ The next video sucks but can’t be edited
+ Ben explains why, and what you can do
+ Please forgive us
+ This type of video won’t be used in future.

### Fully Event Based Raycasting ###

+ The limitations of our current architecture
+ Import new CameraRaycaster.cs
+ Review what’s changed and why
+ Remove our Layer.cs script
+ Preview the editor script
+ CHALLENGE.

(Unique Video Reference: 18_2_RPG)

### Writing Custom Editors ###

+ Why you would want to extend Unity’s editor
+ Review **CameraRaycasterEditor.cs**
+ CHALLENGE - check your understanding.

(Unique Video Reference: 19_2_RPG)

### Player Pathfinding To Enemies ###

+ Control your FOCUS - let’s move on
+ How to modify our player for pathfinding
+ CHALLENGE

(Unique Video Reference: 20_2_RPG)

### Prototyping Goals And Progress ###

+ Recap our goals for prototyping
+ Where are you at with your goals - what is your score out of 10?
+ CHALLENGE.

(Unique Video Reference: 21_2_RPG)

### Refine Your Nav Mesh ###

+ Import latest art assets
+ Review distance, sizes, pacing in your level
+ Clean up Nav Mesh
+ CHALLENGE

(Unique Video Reference: 22_2_RPG )

### Tuning And Exploring ###

+ It’s important to experiment when prototyping
+ CHALLENGE.

(Unique Video Reference: 23_2_RPG)

### Importing Humanoid Animations ###

+ Humanoid character import settings
+ How to replace a character’s mesh
+ CHALLENGE.

(Unique Video Reference: 24_CC_RPG)

### Using Interfaces In C# ###

+ What an interface is in C#, and why they’re useful
+ Where and when to use them, e.g. **IDamageable**
+ Building a simple example scene.

(Unique Video Reference: 25_CC_RPG)

### Calling Methods Via Interfaces ###

+ How to find game objects by interface
+ How to call a method via an interface
+ Getting damage working on player and enemy
+ CHALLENGE.

(Unique Video Reference: 26_CC_RPG)

### Enemy Move And Attack Spheres ###

+ How to find game objects by interface
+ How to call a method via an interface
+ Getting damage working on player and enemy
+ CHALLENGE.

(Unique Video Reference: 27_CC_RPG)

### Spawning Enemy Projectiles ###

+ A quick recap of unit vectors, speed and velocity
+ Setup projectile prefab & attach to enemy
+ CHALLENGE

(Unique Video Reference: 28_CC_RPG)

### InvokeRepeating() vs StartCoroutine() ###

+ How InvokeRepeating() is string referenced
+ StartCoroutine() is type safe, but more complex
+ A very quick overview of co-routines
+ Test enemies damaging player
+ CHALLENGE

(Unique Video Reference: 29_CC_RPG)

### Player Melee Damage ###

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

(Unique Video Reference: 33_CC_RPG)

### Healing Companion Prototype ###

+ Using the tools we have
+ Creating a healer
+ CHALLENGE

(Unique Video Reference: 34_CC_RPG)

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

### Rising Complexity, Refactoring ###

+ How complexity may scale in a project
+ The bigger picture of smelly code
+ Review TODOs to feel in control

(Unique Video Reference: 37_CC_RPG)

### Using The Trail Renderer Component ###

+ Why our projectiles are hard to see
+ Strategies for improving visibility
+ Using Trail Renderers to help see projectiles
+ CHALLENGE

(Unique Video Reference: 38_CC_RPG)

### Preventing Projectile Pass-Through ###

+ Options for stopping projectiles passing through
+ Using Continuous Dynamic collision detection
+ Fix characters crouching on impact issue
+ Projectiles self-organise and destroy themselves

(Unique Video Reference: 39_CC_RPG)

### Fix Wobbly Characters ###

+ Our Current Movement Bugs
+ Tuning To Find A Fix
+ CHALLENGE

(Unique Video Reference: 40_CC_RPG)

### Preparing Our Assets Folder ###

+ The problem with importing assets
+ Our various needs with our assets
+ Rearranging our assets folder
+ CHALLENGE

(Unique Video Reference: 41_CC_RPG)

### Set Dressing Our Level ###

+ What we mean by set dressing
+ Import textures and assets
+ Make the ground look good
+ CHALLENGE

(Unique Video Reference: 42_CC_RPG)

### Adding Water ###

+ Import water from standard assets
+ CHALLENGE
+ Place water

(Unique Video Reference: 43_CC_RPG)

### Movement Bug And Water ###

+ The bug we’re seeing that started after we added water
+ My solution to the bug
+ A conversation about making decisions on how much time to invest in fixing bugs
+ CHALLENGE

(Unique Video Reference: 44_CC_RPG)

### Adding Trees ###

+ Import trees from standard assets, asset store or our asset pack
+ Setting up our tree painting
+ CHALLENGE
+ Trees in our level

(Unique Video Reference: 45_CC_RPG)

### Asset Showcase Scene ###

+ Creating and explaining the Asset Showcase Scene
+ CHALLENGE

(Unique Video Reference: 46_CC_RPG)

### Get Your Dev Hat Back On ###

+ How NOT to automate new scene setup (yet)
+ Showcase scene detail res. & scene file clash
+ Update / import latest art assets. Blue trees?
+ Discuss movement bug / deferring (80% rule)
+ Rename **NotifyObser**v**ers** and fix console errors
+ How to highlight member variables in VS.

(Unique Video Reference: 47_CC_RPG)

### Introducing Scriptable Objects ###

+ The difference between data and state
+ Why we use Scriptable Objects for data
+ Using [CreateAssetMenu(menuName=”Name”)]
+ Programmatically placing a weapon in hand.

(Unique Video Reference: 48_CC_RPG)

### Adjustable Weapon Grip ###

+ Create a weapon grip transform prefab
+ Associate the weapon grip with the weapon*
+ Ensure weapon spawns with correct grip
_* Later you could have multiple grips per weapon._
_
(Unique Video Reference: 49_CC_RPG)_

### Problems With Prefabs ###

+ Recover Rick’s value from player instance
+ Use a MonoBehaviour to tag weapon hand.

(Unique Video Reference: 50_CC_RPG)

### Import Mechanim Animation Pack ###

+ Clear all console warnings
+ Simplify Ethan’s Animator Controller
+ Import free animation pack
+ Setup Attack animation trigger.

(Unique Video Reference: 52_CC_RPG)

### Projectiles Discriminate ###

+ Why enemies currently hurt one-another
+ CHALLENGE
+ Split class into SO and MonoBehaviour
+ Add facility for sound.

(Unique Video Reference: 52_CC_RPG)

### Section 2 Wrap Up ###

+ What you’ve learnt
+ What’s coming up next.

(Unique Video Reference: 53_CC_RPG)

---
Find out more about our [Unity RPG Creator Course Series](https://www.udemy.com/unityrpg/?couponCode=GitHubDiscount).
