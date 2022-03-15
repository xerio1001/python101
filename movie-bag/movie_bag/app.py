from flask import Flask
from database.db import initiliaze_db
from flask_restful import Api
from resources.routes import initialize_routes

app = Flask(__name__)
api = Api(app)

app.config['MONGODB_SETTINGS'] = {
    'host': 'mongodb+srv://m001-student:m001-mongodb-basics@sandbox.o2oak.mongodb.net/Movie-bag?retryWrites=true&w=majority'
}

initiliaze_db(app)
initialize_routes(api)

if __name__ == "__main__":
    app.run(debug=True)