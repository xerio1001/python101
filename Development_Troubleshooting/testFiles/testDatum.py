"""# Python3 code to demonstrate 
# attributes of now() 
    
# importing datetime module for now() 
import datetime 
    
# using now() to get current time 
current_time = datetime.datetime.now() 
    
# Printing attributes of now(). 
print ("The attributes of now() are : ") 
    
print ("Year : ", end = "") 
print (current_time.year) 
    
print ("Month : ", end = "") 
print (current_time.month) 
    
print ("Day : ", end = "") 
print (current_time.day) 
"""
from datetime import date
 
def age(birthdate):
    today = date.today()
    age = today.year - birthdate.year - ((today.month, today.day) < (birthdate.month, birthdate.day))
    return age

print(age(date(2000, 1, 1)))
