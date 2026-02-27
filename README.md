# Class-Example-2

Please download a copy of this Unity project on your machine. I set up all the lab computers with the new Unity 6000.3.6f1 version, so there should not be any issues with incompatibilities.

## Installation:

Since we are all on the same version of Unity now, the set up should be a bit quicker, and hopefully with less warnings.

1. Go to https://github.com/matt-merritt-phs/Class-Example-2
2. Select the green "Code" button, then select "Download ZIP"
3. Open File Explorer, and navigate to Downloads
4. Select "Extract all", and put the files somewhere you will remember
5. Open Unity Hub
6. Under "Projects", select the "Add" button
7. Select "Add project from disk"
8. Find the inner folder from the unzipping process earlier (should be "Class-Example-2-master", with the "Assets" folder and a bunch more inside)

## Scene Setup

Once you have opened the project, we will be working on adding a set of dominos that will fall over.

1. First, add the floor that our shapes will exist on. The floor should be centered at the world origin, and stretched to cover more space.
2. Then add a cube, which will represent one domino.
3. Edit the cube's scale to make it taller, and thinner.
4. Copy the domino and place at least 5 of them in the scene, with each one being positioned in front of the next.
5. Select one domino to be the first that will fall over. Rotate this domino slightly so that it will naturally fall and knock over the next.
6. With the tilted domino selected, add a new component called a Rigidbody. This will handle our Physics.
7. In the heirachy, select all the other dominos, and also add a rigidbody.

Take a screenshot of your project and upload it to Google Classroom.

## Bonus Exploration

If you have extra time, consider the following:

1. Instead of rotating a starting domino, create something to knock the first one over. This could be a ball on a ramp, or a falling block, or something else.
2. Add multiple platforms and verticality. Try to make sure that everything is still visible with the camera.
3. Add objects that are outside the camera lens and experiment with pausing in Play mode. In Play mode, you can swap to the scene view and interact with the GameObjects and Physics in real-time.

If you do anything extra, you can take a screenshot of what you have at the end of this exporation instead for Google Classroom.