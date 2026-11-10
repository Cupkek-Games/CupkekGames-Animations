# CupkekGames Animations

Animation engine interfaces (locomotion, combat, time control). Pluralized to avoid UnityEngine.Animation collision.

Extracted from HeroManager (Phase A, 2026-04-30).

## Changes

- **0.3.0:** `IAnimationStateController` reads its catalog: `Kinds` (what it can play) and `TryGetClip(kind, out clip)` (the clip a kind plays, to time something by it or to tell which variant a character uses). Implementers add both.
