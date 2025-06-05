CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Email NVARCHAR(100) NOT NULL UNIQUE CHECK (Email LIKE '%_@__%.__%'),
    PasswordHash NVARCHAR(255) NOT NULL
);
CREATE TABLE Exercises (
    ExerciseID INT PRIMARY KEY IDENTITY(1,1),
    EName NVARCHAR(100) NOT NULL UNIQUE,
    EDescription NVARCHAR(255)
);
CREATE TABLE WorkoutSessions (
    WorkoutID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    StartTime DATETIME2 DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
CREATE TABLE WorkoutLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    WorkoutID INT NOT NULL,
    ExerciseID INT NOT NULL,
    WWeight DECIMAL(5,2) NOT NULL,
    WSets INT NOT NULL,
    RepsPerSet INT NOT NULL,
    FOREIGN KEY (WorkoutID) REFERENCES WorkoutSessions(WorkoutID),
    FOREIGN KEY (ExerciseID) REFERENCES Exercises(ExerciseID)
);


INSERT INTO Users(Username, Email, PasswordHash) VALUES ('test', 'test@test.com', 'test');

INSERT INTO Exercises (EName, EDescription) VALUES
('Barbell BenchPress', 'Chest compound movement using a barbell, lying flat on a bench.'),
('Dumbbell ChestPress', 'Chest press performed with dumbbells for increased range of motion.'),
('Machine ChestPress', 'Chest press using a plate-loaded or cable machine for stability.'),
('Dumbbell Chest Flies', 'Isolation chest exercise performed with dumbbells to stretch pecs.'),
('Machine Chest Flies', 'Chest fly performed with a pec-deck or similar machine.'),
('Deadlift', 'Full-body compound movement lifting a barbell from the floor.'),
('Barbell Rows', 'Back exercise pulling a barbell toward the torso while bent over.'),
('LatPulldowns', 'Vertical pulling motion for back using a cable machine.'),
('MachineRows', 'Seated row machine targeting mid to upper back.'),
('CablePullOvers', 'Back and chest accessory movement pulling a cable overhead to hips.'),
('Dumbbell Bicep Curls', 'Bicep isolation curls using individual dumbbells.'),
('Barbell Bicep Curls', 'Bicep curls using a straight or EZ barbell for both arms.'),
('Cable Tricep Pushdowns', 'Tricep isolation using a rope or bar on a cable machine.'),
('Barbell Skull Crushers', 'Lying tricep extension using a barbell, targeting long head.'),
('Dumbbell Lateral Raises', 'Shoulder isolation raise to the sides using dumbbells.'),
('Dumbbell ShoulderPress', 'Overhead press using dumbbells, targets shoulders.'),
('Barbell ShoulderPress', 'Barbell overhead press for delts and triceps.'),
('Barbell Squats', 'Compound leg exercise with barbell on shoulders, full-body tension.'),
('LegPress', 'Machine-based leg press pushing platform with feet.'),
('LegExtentions', 'Quad isolation exercise using a seated leg extension machine.'),
('Sitting LegCurls', 'Hamstring isolation using a seated curl machine.'),
('Standing Calf Raises', 'Calf raise performed standing, often with a machine or barbell.'),
('Sitting Calf Raises', 'Calf raise while seated, typically with a dedicated machine.');

SELECT 
    WorkoutID,
    StartTime AS WorkoutDate
FROM WorkoutSessions
WHERE UserID = 1 and StartTime LIKE '%2025-06-05%'
ORDER BY StartTime DESC;
