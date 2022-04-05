from .stock import MoviesApi, MovieApi
from .auth import SignupApi, LoginApi, LoginUi, SignupUi
from .user import UserApi, UsersApi

def initialize_routes(api):
    api.add_resource(MoviesApi, '/movies')
    api.add_resource(MovieApi, '/movies/<id>')
    api.add_resource(UsersApi, '/user')
    api.add_resource(UserApi, '/user/<id>')

    api.add_resource(SignupApi, '/api/auth/signup')
    api.add_resource(LoginApi, '/api/auth/login')
    api.add_resource(SignupUi, '/api/auth/signupUi')
    api.add_resource(LoginUi, '/api/auth/loginUi')
