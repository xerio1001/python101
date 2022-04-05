from flask import request, Response
from flask_restful import Resource
from database.models.user import Stock, User
from flask_jwt_extended import jwt_required, get_jwt_identity
from mongoengine.errors import FieldDoesNotExist, \
NotUniqueError, DoesNotExist, ValidationError, InvalidQueryError
from resources.errors import *

class StockApi(Resource):
    def get(self):
      stocks = Stock.objects().to_json()
      return Response(stocks, mimetype="application/json", status=200)

    @jwt_required()
    def post(self):
      try:
        user_id = get_jwt_identity()
        body = request.get_json()
        user = User.objects.get(id=user_id)
        stock = Stock(**body, added_by=user)
        stock.save()
        user.update(push__stocks=stock)
        user.save()
        id = stock.id
        return {'id': str(id)}, 200
      except (FieldDoesNotExist, ValidationError):
        raise SchemaValidationError
      except NotUniqueError:
        raise StockAlreadyExistsError
      except Exception:
        raise InternalServerError
  
class StockByIdApi(Resource):
    @jwt_required()
    def put(self, id):
      try:
        user_id = get_jwt_identity()
        stock = Stock.objects.get(id=id, added_by=user_id)
        body = request.get_json()
        stock.update(**body)
        return '', 200
      except InvalidQueryError:
        raise SchemaValidationError
      except DoesNotExist:
        raise UpdatingStockError
      except Exception:
        raise InternalServerError
  
    @jwt_required()
    def delete(self, id):
      try:
        user_id = get_jwt_identity()
        stock = Stock.objects.get(id=id, added_by=user_id)
        stock.delete()
        return '', 200
      except DoesNotExist:
        raise DeletingStockError
      except Exception:
        raise InternalServerError
    
    def get(self, id):
      try:
        stocks = Stock.objects.get(id=id).to_json()
        return Response(stocks, mimetype="application/json", status=200)
      except DoesNotExist:
        raise StockNotExistsError
      except Exception:
        raise InternalServerError
