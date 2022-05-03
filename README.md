# nba-db-app
nba stat app for CIS 560 project


1. localdb should be running following these steps https://k-state.instructure.com/courses/118230/pages/sql-server-access/
2. CREATE DATABASE NBA GO
3. run sql/Tables.sql, sql/Data.sql, sql/Procedures/Procedures.sql
4. unzip py/json/data19-22.zip (unless you already have the json files)
5. install db driver https://go.microsoft.com/fwlink/?linkid=2186919
6. pip install pyodbc
7. run insert.py from the directory nba-stat-app

This should get all of the tables and database connections set up for you to run the program from the UserInterface solution. Run from
said solution and you should be good to go.
