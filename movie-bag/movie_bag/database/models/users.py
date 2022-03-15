from movie_bag.database.db import db

class Users(db.Document):
    name = db.StringField(required=True, unique=True)
    gender = db.StringField(required=False)
    age = db.IntField(required=True)
    email = db.StringField(required=True)
