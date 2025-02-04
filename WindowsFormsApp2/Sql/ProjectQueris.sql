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













SELECT * FROM Gym_Owner  ; /**/
SELECT * FROM Member order by UserName;   /**/
SELECT * FROM Admin;  /**/
SELECT * FROM Trainer; /**/
SELECT * FROM Workout_Plan; 	/**/
SELECT * FROM Diet_Plan;	/**/
SELECT * FROM Meal;	 /**/
SELECT * FROM Machine;	/**/
SELECT * FROM Exercise;	/**/
SELECT * FROM Feedback
SELECT * FROM Gyms;	/**/

SELECT * FROM Diet_Plan_Meal;	/**/
SELECT * FROM MemberDietPlan;	 /**/
SELECT * FROM AdminGym;	/**/
SELECT * FROM Workout_Plan_Purposes_;  /**/
SELECT * FROM Trainer_WorkoutPlan; 	 /**/
SELECT * FROM Meal_Allergens;/**/
SELECT * FROM TrainerGym;  /**/
SELECT * FROM Trainer_Experience; /**/

















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


 SELECT VarificationStatus FROM Trainer WHERE 
 UserName = 'ok' and Password = 'ok';

SELECT * FROM TRAINER;
SELECT * FROM TRAINERGYM


select * from Member
select * from gym_owner;
select * from gyms








select *from Gym_Owner


select Workout_Plan.WorkoutPlanId, Workout_Plan.Experience_required, Workout_Plan.nofoexercise, Workout_Plan.sets, Workout_Plan.reps from Workout_Plan inner join Workout_Exercise on Workout_Plan.WorkoutPlanId = Workout_Exercise.WorkoutPlanId inner join Exercise on Workout_Exercise.ExerciseId = Exercise.ExerciseId 