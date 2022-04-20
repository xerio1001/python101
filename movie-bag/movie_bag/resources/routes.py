from .movie import MoviesApi, MovieApi
from .auth import SignupApi, LoginApi, LoginUi, SignupUi
from .user import UserApi, UsersApi
from .reset_password import ForgotPassword, ResetPassword

def initialize_routes(api):
    api.add_resource(MoviesApi, '/movies')
    api.add_resource(MovieApi, '/movies/<id>')

    api.add_resource(UsersApi, '/user')
    api.add_resource(UserApi, '/user/<id>')

    api.add_resource(SignupApi, '/api/auth/signup')
    api.add_resource(LoginApi, '/api/auth/login')

    api.add_resource(SignupUi, '/api/auth/signupUi')
    api.add_resource(LoginUi, '/api/auth/loginUi')

    api.add_resource(ForgotPassword, '/api/auth/forgot')
    api.add_resource(ResetPassword, '/api/auth/reset')
