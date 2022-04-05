from project.database.db import db

class Stock(db.Document):
    name = db.StringField(required=True)
    price = db.IntField(required=True)
    amountInStock = db.IntField(required=True)

    amountPerOrder = db.IntField(required=True)
    supplier = db.StringField(required=True)
    