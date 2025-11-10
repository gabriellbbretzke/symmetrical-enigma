#docker run --name sql_server_container -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=@@123RETtyu' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest

FROM mcr.microsoft.com/mssql/server:2022-latest

ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=@@123RETtyu

# Optional: Copy a SQL script into the container's working directory. This script could set up initial databases or users.
# COPY setup.sql /usr/src/app/setup.sql

# Optional: Run a command during the build process, for example, install the SQL Server tools
#RUN apt-get update && apt-get install -y msodbcsql18 mssql-tools18 && rm -rf /var/lib/apt/lists/*

# Optional: Set the entry point to run the setup script after SQL Server starts
# Note: The official image handles starting SQL Server automatically. You might need a custom entrypoint script to run setup.sql *after* the server is up.
# For simplicity in a basic Dockerfile, we often just rely on the 'docker run' command to start the default entrypoint.

# Command to run it:
# docker build -t sql-server .