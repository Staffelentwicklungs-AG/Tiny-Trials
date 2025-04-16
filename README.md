# Tiny-Trials<br/>
<br/>
This game prototype was developed as part of a weekly student project within a game development training program. Each student group explores a different core mechanic inspired by modern AAA games but scaled down to fit a beginner-friendly scope using the Unity Engine (2D or 3D).<br/>
<br/>
The goal is to help students learn essential development workflows such as:<br/>
  -Scripting<br/>
  -Scene building<br/>
  -Asset integration<br/>
  -UI and UX basics<br/>
  -Simple game logic<br/>
<br/>
Each prototype features a unique gameplay twist (USP) and focuses on one specific mechanic or idea.<br/>
Inspired by: Dark Souls / Elden Ring<br/>
Genre: 3D Top-Down Action<br/>
USP: One single, challenging boss fight on a small arena. The focus is on dodging, timing, and reading enemy attack patterns.<br/>


Main focus: Combat system, health UI, animation.<br/>



1. Game Overview

Title: Tiny-Trials
Genre: 3D Top-Down Action
Perspective: Top-down, fixed or semi-dynamic camera
Platform: PC (Windows)
Engine: Unity (URP, beginner-friendly workflow)

Core Inspiration:



    Scaled for accessibility and short development time

2. High Concept

"One arena. One boss. One intense trial of 'skill'."

Tiny-Trials is a short, focused combat experience where players face a single boss enemy in a tight arena. The gameplay loop centers on learning the enemy’s attack patterns, dodging with timing and landing attacks during windows of opportunity.
3. Unique Selling Point (USP)

    One Boss, One Fight: The game is built entirely around a single, climactic boss encounter.

    Ragdoll 'jank' Player-Character and Boss.

    https://youtu.be/IwoHMr7RvkI?si=lckXC2s_HaDiMnXa

    Physics that catapult you around and make you feel impact and pain.

    Focus on Fun and Skill: No powerups, no grinding—just skill, jank, reading animations, and reacting.

    Minimal UI: A clean and focused presentation where all feedback comes from gameplay, animation, and visual cues.

4. Core Gameplay Loop

    Player spawns at arena edge.(wobles)

    Boss awakens, begins attack cycles.

    Player dodges, learns telegraphs, lands attacks.

    Player dies → respawn instantly.

    Player wins → simple win screen / stat summary.

5. Player Mechanics

    Movement: 8-directional WASD movement

    Attack: Light melee (single button, short windup)

    Dodge: Slow long roll with invincibility window (i-frames)

    Parry: High-Risk High-Reward

    Health: Simple 

6. Boss Design

Name: TBD (e.g., The Trialbound, Iron Warden)
Phases:

    Phase 1: Basic swings, charge, and stomp

    Phase 2 (at 50% HP): Faster combos, AoE attack, visual cue change (glow, aura, etc.)

Attacks Include:

    Wide arc swing (can be dodged sideways)

    Forward charge (telegraphed windup)

    Ground slam (AoE, dodge-timed)

7. UI & UX

    Health Bars: Player (top-left), Boss (top-center)

    Hit Feedback: Screen shake, flash, sound cue

    Death Screen: “You Died” style, fade to black

    Victory Screen: Simple “Victory” text with optional stats (time, deaths)

8. Art & Animation

    Art Style: Stylized low-poly

    Player & Boss Models: Humanoid (free Unity Asset Store or Mixamo)

    Animation: Use Unity Animator with attack and dodge transitions

    Environment: tbd

9. Sound Design

    Ambient: Low background rumble or wind

    Boss Music: tbd

    SFX:

        Attack swings

        Dodge impact

        Hit impact

        Boss growls

        Stomp impact



