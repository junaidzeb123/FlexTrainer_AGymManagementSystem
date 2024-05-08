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
  FOREIGN KEY (UserName) REFERENCES Gym_Owner(UserName)
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
  PRIMARY KEY (DietPlanId)
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
  PRIMARY KEY (Name)
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

CREATE TABLE Booking_Session
(
  BookingSessionId INT NOT NULL,
  Date DATE NOT NULL,
  Time VARCHAR(50) NOT NULL,
  PRIMARY KEY (BookingSessionId)
);

CREATE TABLE Feedback
(
  FeedbackId INT NOT NULL,
  Description VARCHAR(50) NOT NULL,
  MemberUserName VARCHAR(50) NOT NULL,
  TrainerUserName VARCHAR(50) NOT NULL,	
  PRIMARY KEY (FeedbackId),
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
  Name VARCHAR(50) NOT NULL,
  DietPlanId INT NOT NULL,
  PRIMARY KEY (Name, DietPlanId),
  FOREIGN KEY (Name) REFERENCES Meal(Name),
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
  PRIMARY KEY (DietPlanId, UserName),
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
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (Allergens, Name),
  FOREIGN KEY (Name) REFERENCES Meal(Name)
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


CREATE TABLE Trainer_BookingSession
(
  BookingSessionId INT NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  PRIMARY KEY (BookingSessionId, UserName),
  FOREIGN KEY (BookingSessionId) REFERENCES Booking_Session(BookingSessionId),
  FOREIGN KEY (UserName) REFERENCES Trainer(UserName)
);

CREATE TABLE Trainer_Experience
(
  Experience VARCHAR(50) NOT NULL,
  UserName VARCHAR(50) NOT NULL,
  FOREIGN KEY (UserName) REFERENCES Trainer(UserName)
);

SELECT * FROM Workout_Plan NATURAL JOIN Workout_Plan_Purposes_;

/**/
CREATE TABLE AUDIT_TRAIL(
	audit_id INT IDENTITY(1,1) PRIMARY KEY,
	OPERATION VARCHAR (100),
	timestamp datetime 	
);

SELECT * FROM Member;   /**/
SELECT * FROM Gym_Owner;  /**/
SELECT * FROM Admin;  /**/
SELECT * FROM Trainer; /**/
SELECT * FROM Workout_Plan; 
SELECT * FROM Diet_Plan;
SELECT * FROM Meal;
SELECT * FROM Machine;
SELECT * FROM Exercise;
SELECT * FROM Booking_Session;
SELECT * FROM Feedback; 
SELECT * FROM Gyms;	/**/
SELECT * FROM Diet_Plan_Meal;
SELECT * FROM MemberDietPlan;
SELECT * FROM AdminGym;
SELECT * FROM Workout_Plan_Purposes_;
SELECT * FROM Trainer_WorkoutPlan; 
SELECT * FROM Meal_Allergens;
SELECT * FROM TrainerGym; /**/
SELECT * FROM Trainer_BookingSession; 
SELECT * FROM Trainer_Experience; /**/


SELECT * FROM Diet_Plan;
SELECT * FROM Meal;
SELECT * FROM Diet_Plan_Meal;
SELECT * FROM TrainerDietPlan
SELECT * FROM Meal_Allergens;
SELECT * FROM MemberDietPlan;





-- Inserting dummy data into Trainer table
INSERT INTO Trainer (UserName, Name, Email, Qualifications, Specialty_areas, VarificationStatus, Address, Start_Date, Password) 
VALUES ('trainer1', 'John Doe', 'john@example.com', 'Certified Personal Trainer', 'Weightlifting, Cardio', 1, '123 Main Street', '2023-01-15', 'password123');

-- Inserting dummy data into Gym_Owner table
INSERT INTO Gym_Owner (UserName, Name, Email, Address, Start_Date, Password, VarificationStatus) 
VALUES ('owner1', 'Fitness Center Owner', 'owner@example.com', '456 Elm Street', '2022-12-01', 'ownerpass', 1);

-- Inserting dummy data into Gyms table
INSERT INTO Gyms (Name, Location, Timings, UserName, licenseno) 
VALUES ('Fitness Zone', '789 Oak Avenue', '9:00 AM - 9:00 PM', 'owner1', 'GYM123456');

-- Inserting dummy data into Member table
INSERT INTO Member (UserName, Name, Email, Cnic, Start_Date, Address, Membership_type, Password) 
VALUES ('member1', 'Alice Smith', 'alice@example.com', '1234567890123', '2023-02-20', '321 Pine Street', 'Premium', 'memberpass');

-- Inserting dummy data into Admin table
INSERT INTO Admin (Name, UserName, Password) 
VALUES ('Admin User', 'admin1', 'adminpass');

-- Inserting dummy data into Workout_Plan table
INSERT INTO Workout_Plan (Experience_required, nofoexercise, sets, reps) 
VALUES ('Intermediate', 5, 3, 10);

-- Inserting dummy data into Diet_Plan table
INSERT INTO Diet_Plan (DietPlanId, Type, Purpose) 
VALUES (1, 'Keto', 'Weight Loss');

-- Inserting dummy data into Meal table
INSERT INTO Meal (Amount_of_Protein, Carbs, Fiber, Fat, Calories, Name) 
VALUES (30, 20, 10, 15, 350, 'Grilled Chicken Salad');

-- Inserting dummy data into Machine table
INSERT INTO Machine (Name) 
VALUES ('Treadmill');

-- Inserting dummy data into Exercise table
INSERT INTO Exercise (Target_Muscle, Name, MachineName) 
VALUES ('Legs', 'Squats', 'Treadmill');

-- Inserting dummy data into Booking_Session table
INSERT INTO Booking_Session (BookingSessionId, Date, Time) 
VALUES (1, '2024-05-10', '10:00 AM');

-- Inserting dummy data into Feedback table
INSERT INTO Feedback (FeedbackId, Description, MemberUserName, TrainerUserName) 
VALUES (1, 'Great training session!', 'member1', 'trainer1');

-- Inserting dummy data into Workout_Exercise table
INSERT INTO Workout_Exercise (WorkoutPlanId, ExerciseId) 
VALUES (1, 1);

-- Inserting dummy data into Diet_Plan_Meal table
INSERT INTO Diet_Plan_Meal (Name, DietPlanId) 
VALUES ('Grilled Chicken Salad', 1);

-- Inserting dummy data into MemberDietPlan table
INSERT INTO MemberDietPlan (DietPlanId, UserName) 
VALUES (1, 'member1');

-- Inserting dummy data into AdminGym table
INSERT INTO AdminGym (Name, UserName) 
VALUES ('Fitness Zone', 'admin1');

-- Inserting dummy data into Workout_Plan_Purposes_ table
INSERT INTO Workout_Plan_Purposes_ (Purposes_, WorkoutPlanId) 
VALUES ('Strength Training', 1);

-- Inserting dummy data into Meal_Allergens table
INSERT INTO Meal_Allergens (Allergens, Name) 
VALUES ('Gluten', 'Grilled Chicken Salad');

-- Inserting dummy data into TrainerGym table
INSERT INTO TrainerGym (UserName, Name) 
VALUES ('trainer1', 'Fitness Zone');

-- Inserting dummy data into MemberGym table
INSERT INTO MemberGym (UserName, Name) 
VALUES ('member1', 'Fitness Zone');

-- Inserting dummy data into Trainer_WorkoutPlan table
INSERT INTO Trainer_WorkoutPlan (UserName, WorkoutPlanId) 
VALUES ('trainer1', 1);

-- Inserting dummy data into Member_WorkoutPlan table
INSERT INTO Member_WorkoutPlan (UserName, WorkoutPlanId) 
VALUES ('member1', 1);

-- Inserting dummy data into Trainer_BookingSession table
INSERT INTO Trainer_BookingSession (BookingSessionId, UserName) 
VALUES (1, 'trainer1');

-- Inserting dummy data into Trainer_Experience table
INSERT INTO Trainer_Experience (Experience, UserName) 
VALUES ('5 years', 'trainer1');

-- Inserting dummy data into AUDIT_TRAIL table
INSERT INTO AUDIT_TRAIL (OPERATION, timestamp) 
VALUES ('Insertion', GETDATE());
