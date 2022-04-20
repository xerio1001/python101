from flask import Flask
from flask_bcrypt import Bcrypt
from flask_jwt_extended import JWTManager
from flask_mail import Mail
from database.db import initiliaze_db
from flask_restful import Api
from resources.errors import errors
from main import simple_page
from dotenv import load_dotenv
import os
load_dotenv()

dbUser = os.environ['DB_NAME']
dbPassword = os.environ['DB_PASSWORD']
dbUri = os.environ['DB_URI']
dbBaseName = os.environ['DB_BASE_NAME']
jwt_key = os.environ['JWT_SECRET_KEY']

mServer = os.environ['MAIL_SERVER']
mPort = os.environ['MAIL_PORT']
mUsername = os.environ['MAIL_USERNAME']
mPassword = os.environ['MAIL_PASSWORD']

app = Flask(__name__)

app.config['JWT_SECRET_KEY'] = jwt_key

app.config['MAIL_SERVER'] = mServer
app.config['MAIL_PORT'] = mPort
app.config['MAIL_USERNAME'] = mUsername
app.config['MAIL_PASSWORD'] = mPassword

mail = Mail(app)
# imports requiring app and mail
from resources.routes import initialize_routes

api = Api(app, errors=errors)
bcrypt = Bcrypt(app)
jwt = JWTManager(app)

app.config['MONGODB_SETTINGS'] = {
    #'host': f'mongodb+srv://m001-student:m001-mongodb-basics@sandbox.o2oak.mongodb.net/Movie-bag?retryWrites=true&w=majority'
    'host': f'mongodb+srv://{dbUser}:{dbPassword}@{dbUri}/{dbBaseName}?retryWrites=true&w=majority'
}

initiliaze_db(app)
initialize_routes(api)

app.register_blueprint(simple_page, url_prefix="/ui") 
