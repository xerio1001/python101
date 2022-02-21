import os
from dotenv import load_dotenv
load_dotenv()

token = os.environ.get("API_KEY")
uri = os.environ.get("DB_URI")
port = os.environ.get("DB_PORT")
user = os.environ.get("DB_USER")
password = os.environ.get("DB_PASSWORD")
msg = os.environ.get("HELLO_MSG")

print(token)
print(uri)
print(port)
print(user)
print(password)
print(msg)
