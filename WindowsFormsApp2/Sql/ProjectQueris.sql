CREATE DATABASE GYM_MANAGMENT;
USE GYM_MANAGMENT;
drop database GYM_MANAGMENT;

CREATE TABLE Trainer
(
  UserName VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  Qualifications VARCHAR(50) NOT NULL,
  Specialty_areas VARCHAR(50) NOT NULL,
  VarificationStatus int NOT NULL,
  Address VARCHAR(50) NOT NULL,
  Start_Date DATE NOT NULL,
  Password VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserName),
);


CREATE TABLE Gym_Owner
(
  UserName VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  Address VARCHAR(50) NOT NULL,
  Start_Date DATE NOT NULL,
  Password VARCHAR(50) NOT NULL,
  VarificationStatus int NOT NULL,
  PRIMARY KEY (UserName),
);

CREATE TABLE Gyms
(
  Name VARCHAR(50) NOT NULL,
  Location VARCHAR(50) NOT NULL,
  Timings VARCHAR(50) NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  licenseno VARCHAR(50) NOT NULL,
  PRIMARY KEY (Name),
  FOREIGN KEY (UserName) REFERENCES Gym_Owner(UserName) on delete cascade
);


CREATE TABLE Member
(
  UserName VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  Cnic VARCHAR(50) NOT NULL,
  Start_Date DATE NOT NULL,
  Address VARCHAR(50) NOT NULL,
  Membership_type VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserName)
);

CREATE TABLE Admin
(
  Name VARCHAR(50) NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserName)
);

CREATE TABLE Workout_Plan
(
  WorkoutPlanId INT IDENTITY(1,1) PRIMARY KEY,
  Experience_required VARCHAR(50) NOT NULL,
  nofoexercise int NOT NULL,
  sets int ,
  reps int
);

CREATE TABLE Diet_Plan
(
  DietPlanId  INT IDENTITY(1,1) PRIMARY KEY,
  Type VARCHAR(50) NOT NULL,
  Purpose VARCHAR(50) NOT NULL,
  noofMeals INT ,


);

CREATE TABLE Meal
(
  MealId INT IDENTITY(1,1) PRIMARY KEY,
  MealName VARCHAR(50) NOT NULL,
  Amount_of_Protein INT NOT NULL,
  Carbs INT NOT NULL,
  Fiber INT NOT NULL,
  Fat INT NOT NULL,
  Calories INT NOT NULL,
);


CREATE TABLE Machine
(
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (Name)
);

CREATE TABLE Exercise
(
  ExerciseId INT IDENTITY(1,1) PRIMARY KEY,
  Target_Muscle VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  MachineName VARCHAR(50),
  FOREIGN KEY (MachineName) REFERENCES Machine(Name)
);



CREATE TABLE Feedback
(
  FeedbackId  INT IDENTITY(1,1) PRIMARY KEY,
  Description VARCHAR(500) NOT NULL,
  Rating INT ,
  MemberUserName VARCHAR(50) NOT NULL,
  TrainerUserName VARCHAR(50) NOT NULL,	
  FOREIGN KEY (MemberUserName) REFERENCES Member(UserName),
   FOREIGN KEY (TrainerUserName) REFERENCES Trainer(UserName)
);

CREATE TABLE Workout_Exercise
(
  WorkoutPlanId INT NOT NULL,
  ExerciseId   INT NOT NULL,
  PRIMARY KEY (WorkoutPlanId, ExerciseId),
  FOREIGN KEY (WorkoutPlanId) REFERENCES Workout_Plan(WorkoutPlanId),
  FOREIGN KEY (ExerciseId) REFERENCES Exercise(ExerciseId)
);

CREATE TABLE Diet_Plan_Meal
(
  MealId INT NOT NULL,
  DietPlanId INT NOT NULL,
  FOREIGN KEY (MealId) REFERENCES Meal(MealId),
  FOREIGN KEY (DietPlanId) REFERENCES Diet_Plan(DietPlanId)
);

CREATE TABLE MemberDietPlan
(
  DietPlanId INT NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  PRIMARY KEY (DietPlanId, UserName),
  FOREIGN KEY (DietPlanId) REFERENCES Diet_Plan(DietPlanId),
  FOREIGN KEY (UserName) REFERENCES Member(UserName)
);


CREATE TABLE TrainerDietPlan
(
  DietPlanId INT NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  FOREIGN KEY (DietPlanId) REFERENCES Diet_Plan(DietPlanId),
  FOREIGN KEY (UserName) REFERENCES Trainer(UserName)
);

CREATE TABLE AdminGym
(
  Name VARCHAR(50) NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  PRIMARY KEY (Name, UserName),
  FOREIGN KEY (Name) REFERENCES Gyms(Name),
  FOREIGN KEY (UserName) REFERENCES Admin(UserName)
);

CREATE TABLE Workout_Plan_Purposes_
(
  Purposes_ VARCHAR(50) NOT NULL,
  WorkoutPlanId INT NOT NULL,
  PRIMARY KEY (Purposes_, WorkoutPlanId),
  FOREIGN KEY (WorkoutPlanId) REFERENCES Workout_Plan(WorkoutPlanId)
);

CREATE TABLE Meal_Allergens
(
  Allergens VARCHAR(50) NOT NULL,
  MealId INT NOT NULL,
  PRIMARY KEY (Allergens, MealId),
  FOREIGN KEY (MealId) REFERENCES Meal(MealId)
);


CREATE TABLE TrainerGym
(
  UserName VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserName, Name),
  FOREIGN KEY (UserName) REFERENCES Trainer(UserName),
  FOREIGN KEY (Name) REFERENCES Gyms(Name)
);

CREATE TABLE MemberGym
(
  UserName VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (UserName, Name),
  FOREIGN KEY (UserName) REFERENCES Member(UserName),
  FOREIGN KEY (Name) REFERENCES Gyms(Name)
);



CREATE TABLE Trainer_WorkoutPlan
(
  UserName VARCHAR(50) NOT NULL,
  WorkoutPlanId INT NOT NULL,
  PRIMARY KEY (UserName, WorkoutPlanId),
  FOREIGN KEY (UserName) REFERENCES Trainer(UserName),
  FOREIGN KEY (WorkoutPlanId) REFERENCES Workout_Plan(WorkoutPlanId)
);


CREATE TABLE Member_WorkoutPlan
(
  UserName VARCHAR(50) NOT NULL,
  WorkoutPlanId INT NOT NULL,
  PRIMARY KEY (UserName, WorkoutPlanId),
  FOREIGN KEY (UserName) REFERENCES Member(UserName),
  FOREIGN KEY (WorkoutPlanId) REFERENCES Workout_Plan(WorkoutPlanId)
);



CREATE TABLE Trainer_Experience
(
  Experience VARCHAR(50) NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  FOREIGN KEY (UserName) REFERENCES Trainer(UserName)
);

CREATE TABLE Booking_Session
(
  BookingSessionId  INT IDENTITY(1,1) PRIMARY KEY,
  SessionDate DATE NOT NULL,  -- Separate column for date
  startTime varchar(50),
  endtime varchar(50),
  MemberUserName VARCHAR(50) NOT NULL,
  TrainerUserName VARCHAR(50) NOT NULL,	
  FOREIGN KEY (MemberUserName) REFERENCES Member(UserName),
  FOREIGN KEY (TrainerUserName) REFERENCES Trainer(UserName),
  Status varchar(50)
);




CREATE TABLE AUDIT_TRAIL(
	audit_id INT IDENTITY(1,1) PRIMARY KEY,
	memberUserName varchar(50), 
	trainerUserName varchar(50),
	ownerUserName varchar(50),
	OPERATION VARCHAR (100),
	timestamp datetime 	
	foreign key (memberUserName) references Member(UserName),
	foreign key (trainerUserName) references Trainer(UserName),
	foreign key (ownerUserName) references Gym_Owner(UserName)
);


-- Trigger for Trainer table
CREATE TRIGGER trg_Trainer_Insert
ON Trainer
AFTER INSERT
AS
BEGIN
	declare @TrainerId INT;
	SELECT @TrainerId = inserted.UserName from inserted;
    INSERT INTO AUDIT_TRAIL (OPERATION, trainerUserName, timestamp)
    VALUES ('Insert into Trainer',@TrainerId,  GETDATE())
END;

CREATE TRIGGER trg_Trainer_Update
ON Trainer
AFTER UPDATE
AS
BEGIN
	declare @TrainerId INT;
	SELECT @TrainerId = inserted.UserName from inserted;
    INSERT INTO AUDIT_TRAIL (OPERATION, trainerUserName, timestamp)
    VALUES ('Update on Trainer', @TrainerId, GETDATE())
END;

CREATE TRIGGER trg_Trainer_Delete
ON Trainer
AFTER DELETE
AS
BEGIN
	declare @TrainerId INT;
	SELECT @TrainerId = deleted.UserName from deleted;
    INSERT INTO AUDIT_TRAIL (OPERATION, trainerUserName, timestamp)
    VALUES ('Delete from Trainer',@TrainerId, GETDATE())
END;

-- Trigger for Gym_Owner table
CREATE TRIGGER trg_Gym_Owner_Insert
ON Gym_Owner
AFTER INSERT
AS
BEGIN
declare @OwnerID INT;
	SELECT @OwnerID = inserted.UserName from inserted;
    INSERT INTO AUDIT_TRAIL (OPERATION, ownerUserName, timestamp)
    VALUES ('Insert into Gym_Owner',@OwnerID, GETDATE())
END;

CREATE TRIGGER trg_Gym_Owner_Update
ON Gym_Owner
AFTER UPDATE
AS
BEGIN
    
declare @OwnerID INT;
	SELECT @OwnerID = inserted.UserName from inserted;
    INSERT INTO AUDIT_TRAIL (OPERATION, ownerUserName, timestamp)
    VALUES ('Update on Gym_Owner',@OwnerID, GETDATE())
END;

CREATE TRIGGER trg_Gym_Owner_Delete
ON Gym_Owner
AFTER DELETE
AS
BEGIN

declare @OwnerID INT;
	SELECT @OwnerID = deleted.UserName from deleted;
    INSERT INTO AUDIT_TRAIL (OPERATION, ownerUserName, timestamp)
    VALUES ('Delete from Gym_Owner',@OwnerID, GETDATE())
END;

-- Triggers for Gyms table
CREATE TRIGGER trg_Gyms_Insert
ON Gyms
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Gyms', GETDATE())
END;

CREATE TRIGGER trg_Gyms_Update
ON Gyms
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Gyms', GETDATE())
END;

CREATE TRIGGER trg_Gyms_Delete
ON Gyms
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Gyms', GETDATE())
END;

-- Triggers for Member table
CREATE TRIGGER trg_Member_Insert
ON Member
AFTER INSERT
AS
BEGIN
Declare @memberID int;
	SELECT @memberID = inserted.UserName from inserted
    INSERT INTO AUDIT_TRAIL (OPERATION, memberUserName, timestamp)
    VALUES ('Insert into Member', @memberID, GETDATE())
END;

CREATE TRIGGER trg_Member_Update
ON Member
AFTER UPDATE
AS
BEGIN
    
Declare @memberID int;
	SELECT @memberID = inserted.UserName from inserted
    INSERT INTO AUDIT_TRAIL (OPERATION, memberUserName, timestamp)
	VALUES ('Update on Member', @memberID, GETDATE())
END;

CREATE TRIGGER trg_Member_Delete
ON Member
AFTER DELETE
AS
BEGIN
    
Declare @memberID int;
	SELECT @memberID = deleted.UserName from deleted
    INSERT INTO AUDIT_TRAIL (OPERATION, memberUserName, timestamp)
	VALUES ('Delete from Member', @memberID, GETDATE())
END;

-- Triggers for Admin table
CREATE TRIGGER trg_Admin_Insert
ON Admin
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Admin', GETDATE())
END;

CREATE TRIGGER trg_Admin_Update
ON Admin
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Admin', GETDATE())
END;

CREATE TRIGGER trg_Admin_Delete
ON Admin
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Admin', GETDATE())
END;

-- Triggers for Workout_Plan table
CREATE TRIGGER trg_Workout_Plan_Insert
ON Workout_Plan
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Workout_Plan', GETDATE())
END;

CREATE TRIGGER trg_Workout_Plan_Update
ON Workout_Plan
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Workout_Plan', GETDATE())
END;

CREATE TRIGGER trg_Workout_Plan_Delete
ON Workout_Plan
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Workout_Plan', GETDATE())
END;

-- Triggers for Diet_Plan table
CREATE TRIGGER trg_Diet_Plan_Insert
ON Diet_Plan
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Diet_Plan', GETDATE())
END;

CREATE TRIGGER trg_Diet_Plan_Update
ON Diet_Plan
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Diet_Plan', GETDATE())
END;

CREATE TRIGGER trg_Diet_Plan_Delete
ON Diet_Plan
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Diet_Plan', GETDATE())
END;

-- Triggers for Meal table
CREATE TRIGGER trg_Meal_Insert
ON Meal
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Meal', GETDATE())
END;

CREATE TRIGGER trg_Meal_Update
ON Meal
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Meal', GETDATE())
END;

CREATE TRIGGER trg_Meal_Delete
ON Meal
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Meal', GETDATE())
END;

-- Triggers for Machine table
CREATE TRIGGER trg_Machine_Insert
ON Machine
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Machine', GETDATE())
END;

CREATE TRIGGER trg_Machine_Update
ON Machine
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Machine', GETDATE())
END;

CREATE TRIGGER trg_Machine_Delete
ON Machine
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Machine', GETDATE())
END;

-- Triggers for Exercise table
CREATE TRIGGER trg_Exercise_Insert
ON Exercise
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Exercise', GETDATE())
END;

CREATE TRIGGER trg_Exercise_Update
ON Exercise
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Exercise', GETDATE())
END;

CREATE TRIGGER trg_Exercise_Delete
ON Exercise
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Exercise', GETDATE())
END;

-- Triggers for Feedback table
CREATE TRIGGER trg_Feedback_Insert
ON Feedback
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Feedback', GETDATE())
END;

CREATE TRIGGER trg_Feedback_Update
ON Feedback
AFTER UPDATE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Update on Feedback', GETDATE())
END;

CREATE TRIGGER trg_Feedback_Delete
ON Feedback
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Feedback', GETDATE())
END;

-- Triggers for Workout_Exercise table
CREATE TRIGGER trg_Workout_Exercise_Insert
ON Workout_Exercise
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Workout_Exercise', GETDATE())
END;

CREATE TRIGGER trg_Workout_Exercise_Delete
ON Workout_Exercise
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Workout_Exercise', GETDATE())
END;

-- Triggers for Diet_Plan_Meal table
CREATE TRIGGER trg_Diet_Plan_Meal_Insert
ON Diet_Plan_Meal
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Diet_Plan_Meal', GETDATE())
END;

CREATE TRIGGER trg_Diet_Plan_Meal_Delete
ON Diet_Plan_Meal
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Diet_Plan_Meal', GETDATE())
END;

-- Triggers for MemberDietPlan table
CREATE TRIGGER trg_MemberDietPlan_Insert
ON MemberDietPlan
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into MemberDietPlan', GETDATE())
END;

CREATE TRIGGER trg_MemberDietPlan_Delete
ON MemberDietPlan
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from MemberDietPlan', GETDATE())
END;

-- Triggers for TrainerDietPlan table
CREATE TRIGGER trg_TrainerDietPlan_Insert
ON TrainerDietPlan
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into TrainerDietPlan', GETDATE())
END;

CREATE TRIGGER trg_TrainerDietPlan_Delete
ON TrainerDietPlan
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from TrainerDietPlan', GETDATE())
END;

-- Triggers for AdminGym table
CREATE TRIGGER trg_AdminGym_Insert
ON AdminGym
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into AdminGym', GETDATE())
END;

CREATE TRIGGER trg_AdminGym_Delete
ON AdminGym
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from AdminGym', GETDATE())
END;

-- Triggers for Workout_Plan_Purposes_ table
CREATE TRIGGER trg_Workout_Plan_Purposes_Insert
ON Workout_Plan_Purposes_
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Workout_Plan_Purposes_', GETDATE())
END;

CREATE TRIGGER trg_Workout_Plan_Purposes_Delete
ON Workout_Plan_Purposes_
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Workout_Plan_Purposes_', GETDATE())
END;

-- Triggers for Meal_Allergens table
CREATE TRIGGER trg_Meal_Allergens_Insert
ON Meal_Allergens
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Meal_Allergens', GETDATE())
END;

CREATE TRIGGER trg_Meal_Allergens_Delete
ON Meal_Allergens
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Meal_Allergens', GETDATE())
END;

-- Triggers for TrainerGym table
CREATE TRIGGER trg_TrainerGym_Insert
ON TrainerGym
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into TrainerGym', GETDATE())
END;

CREATE TRIGGER trg_TrainerGym_Delete
ON TrainerGym
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from TrainerGym', GETDATE())
END;

-- Triggers for MemberGym table
CREATE TRIGGER trg_MemberGym_Insert
ON MemberGym
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into MemberGym', GETDATE())
END;

CREATE TRIGGER trg_MemberGym_Delete
ON MemberGym
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from MemberGym', GETDATE())
END;

-- Triggers for Trainer_WorkoutPlan table
CREATE TRIGGER trg_Trainer_WorkoutPlan_Insert
ON Trainer_WorkoutPlan
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Trainer_WorkoutPlan', GETDATE())
END;

CREATE TRIGGER trg_Trainer_WorkoutPlan_Delete
ON Trainer_WorkoutPlan
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Trainer_WorkoutPlan', GETDATE())
END;

-- Triggers for Member_WorkoutPlan table
CREATE TRIGGER trg_Member_WorkoutPlan_Insert
ON Member_WorkoutPlan
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Member_WorkoutPlan', GETDATE())
END;

CREATE TRIGGER trg_Member_WorkoutPlan_Delete
ON Member_WorkoutPlan
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Member_WorkoutPlan', GETDATE())
END;

-- Triggers for Trainer_Experience table
CREATE TRIGGER trg_Trainer_Experience_Insert
ON Trainer_Experience
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Trainer_Experience', GETDATE())
END;

CREATE TRIGGER trg_Trainer_Experience_Delete
ON Trainer_Experience
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Trainer_Experience', GETDATE())
END;

-- Triggers for Booking_Session table
CREATE TRIGGER trg_Booking_Session_Insert
ON Booking_Session
AFTER INSERT
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Insert into Booking_Session', GETDATE())
END;

CREATE TRIGGER trg_Booking_Session_Delete
ON Booking_Session
AFTER DELETE
AS
BEGIN
    INSERT INTO AUDIT_TRAIL (OPERATION, timestamp)
    VALUES ('Delete from Booking_Session', GETDATE())
END;














SELECT * FROM Member;   /**/
SELECT * FROM Admin;  /**/
SELECT * FROM Trainer; /**/
SELECT * FROM Workout_Plan; 	/**/
SELECT * FROM Diet_Plan;	/**/
SELECT * FROM Meal;	/**/
SELECT * FROM Machine;	/**/
SELECT * FROM Exercise;	/**/
SELECT * FROM Feedback; 	/**/
SELECT * FROM Gyms;	/**/
SELECT * FROM Diet_Plan_Meal;	/**/
SELECT * FROM MemberDietPlan;	/**/
SELECT * FROM AdminGym;	/**/
SELECT * FROM Workout_Plan_Purposes_;	/**/
SELECT * FROM Trainer_WorkoutPlan; 	/**/
SELECT * FROM Meal_Allergens;
SELECT * FROM TrainerGym; /**/
SELECT * FROM Trainer_Experience; /**/





SELECT * FROM TRAINER;
SELECT * FROM TRAINERGYM


select * from Member
select * from gym_owner;
select * from gyms


DELETE from gyms  where Name = 'abc'


 

SELECT * FROM Gym_Owner;
SELECT * FROM Gyms;



