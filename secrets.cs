// Presigned URL
string presignedUrl = "https://your-bucket-name.s3.amazonaws.com/your-object-key?AWSAccessKeyId=AKIAIOSFODNN7EXAMPLE&Expires=1609459200&Signature=EXAMPLE";

// Configuration for connecting to Azure Database for MySQL
// Note: Ensure that this file is not exposed publicly and is used only for testing secret scanning.
string mysqlConnection = "hostname=mwehr-databasetest.mysql.database.azure.com;port=3306;username=mwehrenberg;password=Pass123!;ssl-mode=require";

string postGresqlConnection = "export PGHOST=mwehr-postgrestest.postgres.database.azure.com;export PGUSER=mwehrenberg;export PGPORT=5432;export PGDATABASE=postgres;export PGPASSWORD=Pass123!";

string sqlServerConnection = "Server=tcp:mwehr-sqlservertest.database.windows.net,1433;Initial Catalog=mwehr-sqlserverdb;Persist Security Info=False;User ID=CloudSA0011b426;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

string awsRdsSecret = "\"username\":\"postgres\",\"password\":\"!*R_p>*j.8#5s(|w+aLFZkIRx$A|\"";

