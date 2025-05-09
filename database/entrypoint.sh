#!/bin/bash
# Launch MSSQL and send to background
/opt/mssql/bin/sqlservr &

# Wait 30 seconds for it to be available
sleep 30s

echo "/scripts:"
ls -l /scripts

# Run every script in /scripts
for foo in /scripts/*.sql
do
    echo "Executing script: $foo"
    /opt/mssql-tools18/bin/sqlcmd -S sql_server -U sa -P $MSSQL_SA_PASSWORD -d master -C -i $foo
done

echo "All scripts exetuted"

sleep infinity