from flask import request, Response
from flask_restful import Resource
from database.models.user import Movie, User
from flask_jwt_extended import jwt_required, get_jwt_identity

class MoviesApi(Resource):
    @jwt_required()
    def get(self):
      movies = Movie.objects().to_json()
      return Response(movies, mimetype="application/json", status=200)

    @jwt_required()
    def post(self):
      user_id = get_jwt_identity()
      body = request.get_json()
      movie = Movie(**body).save()
      user = User.objects.get(id=user_id)
      movie = Movie(**body, added_by=user)
      movie.save()
      user.update(push__movies=movie)
      user.save()
  
class MovieApi(Resource):
    @jwt_required()
    def put(self, id):
      user_id = get_jwt_identity()
      movie = Movie.objects.get(id=id, added_by=user_id)
      body = request.get_json()
      Movie.objects.get(id=id).update(**body)
      return '', 200
  
    @jwt_required()
    def delete(self, id):
      user_id = get_jwt_identity()
      movie = Movie.objects.get(id=id, added_by=user_id)
      movie.delete()
      return '', 200

    @jwt_required()
    def get(self, id):
      movies = Movie.objects.get(id=id).to_json()
      return Response(movies, mimetype="application/json", status=200)
