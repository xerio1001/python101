from flask import Flask
from flask_bcrypt import Bcrypt
from flask_jwt_extended import JWTManager
from database.db import initiliaze_db
from flask_restful import Api
from resources.routes import initialize_routes
from resources.errors import errors
from main import simple_page

# import os
# from dotenv import load_dotenv
# load_dotenv()

app = Flask(__name__)
app.config['JWT_SECRET_KEY'] = "t1NP63m4wnBg6nyHYKfmc2TpCOGI4nss"
api = Api(app, errors=errors)
bcrypt = Bcrypt(app)
jwt = JWTManager(app)

app.config['MONGODB_SETTINGS'] = {
    'host': 'mongodb+srv://m001-student:m001-mongodb-basics@sandbox.o2oak.mongodb.net/Movie-bag?retryWrites=true&w=majority'
}

initiliaze_db(app)
initialize_routes(api)

app.register_blueprint(simple_page, url_prefix="/ui") 

if __name__ == "__main__":
    app.run(debug=True)