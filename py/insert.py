import json
import pyodbc
conn_str = (
    r"Driver={ODBC Driver 18 for SQL Server};"
    r"Server=(localdb)\MSSQLLocalDb;"
    r"Database=NBA;"
    r"Trusted_Connection=yes;"
    )
conn = pyodbc.connect(conn_str)
 
cursor = conn.cursor()

def insertJsonWithProcedure(fileName, procName):
    with open('json/' + fileName, "r", encoding='utf-8') as read_file:
        data = json.load(read_file)
        json_string = json.dumps(data)      # convert json object to string     
        cursor.execute('EXEC ' + procName + ' @json = ?', json_string)
        conn.commit()
        print('inserted ' + fileName)

#insertJsonWithProcedure('players.json', 'prcInsertPlayers')
#insertJsonWithProcedure('teams.json', 'prcInsertTeams')
#insertJsonWithProcedure('games.json', 'prcInsertGames')
insertJsonWithProcedure('teamplayergames.json', 'prcInsertGameTeamPlayers')

conn.close()