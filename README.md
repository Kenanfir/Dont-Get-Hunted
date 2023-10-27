# Dont-Get-Hunted

Dont-Get-Hunted is a simple 2D top-down multiplayer horror game where players can choose to be either humans or monsters in a labyrinth. The game's objective is straightforward: monsters must collect orbs to gain power and eliminate the human players before it's too late, while humans aim to find and eliminate the monsters as quickly as possible. The project utilizes Unity as its game engine and Photon for multiplayer functionality.

## Key Features

- Multiplayer gameplay.
- Labyrinth map.
- Orbs that grant power to monsters.
- Humans vs. Monsters gameplay.

## Screenshots

![Demo](/Demo.jpg?raw=true) <br />
![Human](/Assets/Sprite/Human/Human.png?raw=true)
![Monster](/Assets/Sprite/Monster_Left.png?raw=true)

## Installation Instructions

At this stage, a build of the game is not available. To stay updated on the project's progress and receive notifications about releases, please consider watching this repository. Meanwhile, you can explore the project by following these steps:

1. Clone this repository.
2. Open the project in Unity Hub.
3. Ensure you're using Unity engine version 2021.3.31f1 LTS.
4. Open the project to access its assets and source code.

## Usage Instructions

- The game starts at the main menu and connects to Photon using the `Assets\Script\Manager\ConnectToServer.cs` script.
- You will be prompted to create a new room or join an existing room.
- After entering a room, you'll choose to play as a human or a monster.
- Your selection will immediately transition you into the gameplay.

### Controls

- Use the WASD keys to move.
- The objective for humans is to kill the monster, while the monsters aim to kill the humans.
- Touching a human or a monster results in an attack that can kill the other player, subject to specific conditions:
  - If the monster hasn't collected a total of 5 orbs, the human can kill the monster.
  - If the monster has already collected 5 orbs, it can kill the human.

## Technologies Used

- Unity
- Photon

## Contributors

- [Kenanfir](https://github.com/Kenanfir) - Game Designer and Programmer
- [charisAli](https://github.com/charisAli) - 2D Artist

## Contact Information

- Email: [realkenanfir@gmail.com](mailto:realkenanfir@gmail.com)
- GitHub Issues: [Project Issues](https://github.com/Kenanfir/Dont-Get-Hunted/issues) (for reporting issues and questions)
- GitHub Discussion: [Discussion](https://github.com/Kenanfir/Dont-Get-Hunted/discussions) (for discussions about anything related to the project)

## Project Roadmap

Currently, there are no specific plans for further progress on this project. Stay tuned for updates.

## Version History

- Prototype (Current)
