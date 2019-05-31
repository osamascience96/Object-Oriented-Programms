# Parent Class
class Parent:
    # member fuction 
    def print_last_name(self):
        print('Ahmed')
# Child Class
class Child(Parent):
    # member function 
    def print_first_name(self):
        print('Osama')

# instance variable for child class
osama = Child()
osama.print_first_name()
osama.print_last_name()
