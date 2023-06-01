﻿public class SceneConfiguration2 : SceneConfiguration
{
    void Awake()
    {
        _objectGamePositions = new[]
        {
            new ObjectGamePosition("enemies/Brick3", 1, 3, 4), 
            new ObjectGamePosition("enemies/Brick3", 3, 3, 4),
            new ObjectGamePosition("enemies/Brick3", 4, 3, 4), 
            new ObjectGamePosition("enemies/Brick3", 7, 3, 4), 
            new ObjectGamePosition("enemies/Brick3", 8, 3, 4), 
            new ObjectGamePosition("enemies/Brick3", 10, 3, 4), 
            
            new ObjectGamePosition("enemies/Brick3", 1, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 2, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 4, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 5, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 6, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 7, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 9, 4, 4), 
            new ObjectGamePosition("enemies/Brick3", 10, 4, 4), 
            
            new ObjectGamePosition("enemies/Brick3", 2, 5, 4), 
            new ObjectGamePosition("enemies/Brick3", 9, 5, 4), 
            
            new ObjectGamePosition("enemies/Brick2", 2, 6, 4),
            new ObjectGamePosition("enemies/Brick2", 3, 6, 4),
            new ObjectGamePosition("enemies/Brick2", 4, 6, 4),
            new ObjectGamePosition("enemies/Brick2", 7, 6, 4),
            new ObjectGamePosition("enemies/Brick2", 8, 6, 4),
            new ObjectGamePosition("enemies/Brick2", 9, 6, 4),
            
            new ObjectGamePosition("enemies/Brick3", 3, 7, 4),
            new ObjectGamePosition("enemies/Brick3", 4, 7, 4),
            new ObjectGamePosition("enemies/Brick3", 5, 7, 4),
            new ObjectGamePosition("enemies/Brick3", 6, 7, 4),
            new ObjectGamePosition("enemies/Brick3", 7, 7, 4),
            new ObjectGamePosition("enemies/Brick3", 8, 7, 4),
            
            new ObjectGamePosition("extras/Magic Ball Particle", 11, 5, 1),
            
            new ObjectGamePosition("extras/Score Ball Particle", 0, 5, 1),
            
            new ObjectGamePosition("extras/Score Ball Particle", 1, 7, 1),
            new ObjectGamePosition("extras/Score Ball Particle", 10, 7, 1),
            
            new ObjectGamePosition("extras/Score Ball Particle", 2, 9, 1),
            new ObjectGamePosition("extras/Score Ball Particle", 9, 9, 1),
        };
    }
}