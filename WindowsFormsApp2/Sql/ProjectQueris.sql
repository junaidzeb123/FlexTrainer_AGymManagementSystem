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
  Goal_of_the_workout VARCHAR(50) NOT NULL,
  Experience_level_required VARCHAR(50) NOT NULL,
  WorkoutPlanId INT NOT NULL,
  Day VARCHAR(50) NOT NULL,
  PRIMARY KEY (WorkoutPlanId)
);

CREATE TABLE Diet_Plan
(
  DietPlanId INT NOT NULL,
  Type VARCHAR(50) NOT NULL,
  Purpose VARCHAR(50) NOT NULL,
  PRIMARY KEY (DietPlanId)
);

CREATE TABLE Meal
(
  Amount_of_Protein INT NOT NULL,
  Carbs INT NOT NULL,
  Fiber INT NOT NULL,
  Fat INT NOT NULL,
  Calories INT NOT NULL,
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (Name)
);

CREATE TABLE Machine
(
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (Name)
);

CREATE TABLE Exercise
(
  Target_Muscle VARCHAR(50) NOT NULL,
  Name VARCHAR(50) NOT NULL,
  MachineName VARCHAR(50),
  PRIMARY KEY (Name),
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
  Name VARCHAR(50) NOT NULL,
  PRIMARY KEY (WorkoutPlanId, Name),
  FOREIGN KEY (WorkoutPlanId) REFERENCES Workout_Plan(WorkoutPlanId),
  FOREIGN KEY (Name) REFERENCES Exercise(Name)
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
SELECT * FROM Workout_Exercise; 
SELECT * FROM Diet_Plan_Meal;
SELECT * FROM MemberDietPlan;
SELECT * FROM AdminGym;
SELECT * FROM Workout_Plan_Purposes_;
SELECT * FROM Meal_Allergens;
SELECT * FROM TrainerGym; /**/
SELECT * FROM Trainer_WorkoutPlan; 
SELECT * FROM Trainer_BookingSession; 
SELECT * FROM Trainer_Experience; /**/


insert into Gym_Owner values('muneeb','muneeb','@ga','atd',CONVERT(date,'2024-01-11'),  'muneeb',0);
insert into Gyms values('a','atd','8-9','muneeb','123');

SELECT * FROM Trainer_Experience;
SELECT * FROM TrainerGym;

SELECT * FROM Gyms;
SELECT * FROM Trainer;
SELECT * FROM Member;
SELECT * FROM MemberGym;
SELECT * FROM Gym_Owner


delete from  TrainerGym;
delete from Trainer_Experience;
delete from  Trainer;





insert into Trainer values('a' , 'juna zeb' , '@afe' ,'qualifinca', 'specilty area', 'address' , CONVERT(date,'1-JUN-2022') , 'password' )