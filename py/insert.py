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

with open("games.json", "r", encoding='utf-8') as read_file:
    data = json.load(read_file)

# convert json object to string
    json_string = json.dumps(data) 
    try:        
        cursor = conn.cursor()
        cursor.execute('EXEC prcInsertGames @json = ?', json_string)
        print('inserted data')    

    except pyodbc.Error as err:
        print('Error !!!!! %s' % err)
    except:
        print('something else failed miserably')

    conn.close()
    print('closed db connection')