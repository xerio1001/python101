from flask_restful import HTTPException

class InternalServerError(HTTPException):
    pass


class SchemaValidationError(HTTPException):
    pass


class StockAlreadyExistsError(HTTPException):
    pass


class UpdatingStockError(HTTPException):
    pass


class DeletingStockError(HTTPException):
    pass


class StockNotExistsError(HTTPException):
    pass


class EmailAlreadyExistsError(HTTPException):
    pass


class UnauthorizedError(HTTPException):
    pass


errors = {
    "InternalServerError": {
        "message": "Something went wrong",
        "status": 500
    },
     "SchemaValidationError": {
         "message": "Request is missing required fields",
         "status": 400
     },
     "StockAlreadyExistsError": {
         "message": "Stock with given name already exists",
         "status": 400
     },
     "UpdatingStockError": {
         "message": "Updating stock added by other is forbidden",
         "status": 403
     },
     "DeletingStockError": {
         "message": "Deleting stock added by other is forbidden",
         "status": 403
     },
     "StockNotExistsError": {
         "message": "Stock with given id doesn't exists",
         "status": 400
     },
     "EmailAlreadyExistsError": {
         "message": "User with given email address already exists",
         "status": 400
     },
     "UnauthorizedError": {
         "message": "Invalid username or password",
         "status": 401
     }
}
