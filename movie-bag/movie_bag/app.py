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

mUsername = os.environ['MAIL_USERNAME']
dbUser = os.environ['DB_NAME']
dbPassword = os.environ['DB_PASSWORD']
dbUri = os.environ['DB_URI']
dbBaseName = os.environ['DB_BASE_NAME']
jwt_key = os.environ['JWT_SECRET_KEY']

app = Flask(__name__)

app.config['JWT_SECRET_KEY'] = jwt_key

app.config['MAIL_SERVER'] = os.environ['MAIL_SERVER']
app.config['MAIL_PORT'] = os.environ['MAIL_PORT']
app.config['MAIL_USERNAME'] = os.environ['MAIL_USERNAME']
app.config['MAIL_PASSWORD'] = os.environ['MAIL_PASSWORD']



mail = Mail(app)
# imports requiring app and mail
from resources.routes import initialize_routes

api = Api(app, errors=errors)
bcrypt = Bcrypt(app)
jwt = JWTManager(app)

app.config['MONGODB_SETTINGS'] = {
    'host': f'mongodb+srv://{dbUser}:{dbPassword}@{dbUri}/{dbBaseName}?retryWrites=true&w=majority'
}

initiliaze_db(app)
initialize_routes(api)

app.register_blueprint(simple_page, url_prefix="/ui") 
