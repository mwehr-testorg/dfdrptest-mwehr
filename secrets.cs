// Presigned URL
string presignedUrl = "https://your-bucket-name.s3.amazonaws.com/your-object-key?AWSAccessKeyId=AKIAIOSFODNN7EXAMPLE&Expires=1609459200&Signature=EXAMPLE";

// Configuration for connecting to Azure Database for MySQL
// Note: Ensure that this file is not exposed publicly and is used only for testing secret scanning.
string dbConnectionString = "hostname=mwehr-databasetest.mysql.database.azure.com;port=3306;username=mwehrenberg;password=pass!;ssl-mode=require";

string token = "ef2poflbwqwaugv7c5n5wqy4tmvlsarnxdlsypjk7njnak2fqvqa";

string githubOauthsec = "a2fa62dd33d8666e66deaf070ba1c2cf32af94f0";

string postGresqlConnection = "export PGHOST=mwehr-postgrestest.postgres.database.azure.com;export PGUSER=mwehrenberg;export PGPORT=5432;export PGDATABASE=postgres;export PGPASSWORD=Thisdoesntmatter123!";
