--Part 1

Id  -   int AI Primary Key
Name -  longtext
EmployerId  -   int

--Part 2

SELECT Name FROM Employers WHERE Location = "St. Louis";

--Part 3

SELECT name, description
FROM techjobs.skills
INNER JOIN techjobs.jobskills
ON techjobs.skills.Id = techjobs.jobskills.skillid
ORDER BY name ASC;
