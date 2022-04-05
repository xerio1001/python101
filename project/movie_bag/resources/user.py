from flask import request, Response
from database.models.user import User
from flask_restful import Resource

class UsersApi(Resource):
  def get(self):
    users = User.objects().to_json()
    return Response(users, mimetype="application/json", status=200)

  def post(self):
    body = request.get_json()
    movie = User(**body).save()
    id = movie.id
    return {'id': str(id)}, 200
 
class UserApi(Resource):
  def put(self, id):
    body = request.get_json()
    User.objects.get(id=id).update(**body)
    return '', 200
 
  def delete(self, id):
    movie = User.objects.get(id=id).delete()
    return '', 200

  def get(self, id):
    users = User.objects.get(id=id).to_json()
    return Response(users, mimetype="application/json", status=200)
