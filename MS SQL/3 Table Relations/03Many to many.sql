CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	NAME VARCHAR(50) NOT NULL,
)

INSERT INTO Students
VALUES
('Mila'),                                      
('Toni'),
('Ron ')

CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY IDENTITY(101,1),
	NAME VARCHAR(50) NOT NULL,
)

INSERT INTO Exams
VALUES
('SpringMVC'),                                      
('Neo4j'),
('Oracle 11g')

CREATE TABLE StudentsExams
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),

	CONSTRAINT Pk_Students_Exams PRIMARY KEY(StudentID, ExamID)
)
