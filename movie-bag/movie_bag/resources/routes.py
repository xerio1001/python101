from .movie import MoviesApi, MovieApi
from .user import UserApi, UsersApi

def initialize_routes(api):
    api.add_resource(MoviesApi, '/movies')
    api.add_resource(MovieApi, '/movies/<id>')
    api.add_resource(UsersApi, '/users')
    api.add_resource(UserApi, '/users/<id>')
