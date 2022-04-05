from .stock import StockApi, StockByIdApi
from .auth import SignupApi, LoginApi
from .user import UserApi, UsersApi

def initialize_routes(api):
    api.add_resource(StockApi, '/movies')
    api.add_resource(StockByIdApi, '/movies/<id>')
    api.add_resource(UsersApi, '/user')
    api.add_resource(UserApi, '/user/<id>')

    api.add_resource(SignupApi, '/api/auth/signup')
    api.add_resource(LoginApi, '/api/auth/login')
