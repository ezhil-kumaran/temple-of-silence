# Temple of Silence 🏛️🌲

**Temple of Silence** is a short, ambient 2D platformer created in Unity. Players traverse a mystical forest and make their way to a tranquil temple. The game emphasizes atmosphere, minimalism, and immersion.

🎮 [Play on Itch.io](https://ezhil-kumaran.itch.io/temple-of-silence)  
📁 [Source Code on GitHub](https://github.com/ezhil-kumaran/temple-of-silence)

---

## 📦 Project Overview

- **Engine**: Unity (2D)
- **Language**: C#
- **Gameplay**: Light platforming, environmental storytelling
- **Assets**: Mix of custom and free-use assets
![Screenshot 2025-03-09 162617](https://github.com/user-attachments/assets/c1cf957e-2124-4b7a-a505-5cc6818fef1f)


---

## 🧠 Script Breakdown

### 🎵 `MusicFade.cs`
Gradually increases background music volume at the start to create a smooth, ambient fade-in effect.

---

### 🏹 `Projectile.cs`
Controls the behavior of projectiles (like traps). Moves them horizontally and destroys them upon collision.

---

### 🔫 `Projectilespawner.cs`
Spawns projectiles at regular intervals from predefined positions—useful for timed obstacles or enemy attacks.

---

### 💀 `enemydamage.cs`
Detects collisions between the player and enemies or hazards, reducing the player's health and triggering a respawn if needed.

---

### ❤️ `health.cs`
Manages player health. Tracks health state, displays visual hearts/lives, and handles death events.

---

### 🧭 `menu.cs`
Handles main menu functionality, including starting the game or quitting the application.

---

### 🧱 `movingblock.cs`
Controls platforms that move back and forth. Can be used for timing-based platforming challenges.

---

### 🧍‍♂️ `player_movement.cs`
Implements basic 2D player movement: running, jumping, and ground detection. Central to all player control.

---

### ♻️ `respawn.cs`
Handles player respawning after death or health depletion. Moves the player back to a spawn point.

---

## ⌨️ Controls

| Action   | Key        |
|----------|------------|
| Move     | Arrow keys |
| Jump     | Spacebar   |

---


## 🗣️ Feedback

Feel free to leave feedback or bug reports on [Itch.io](https://ezhil-kumaran.itch.io/temple-of-silence/comments).

---


