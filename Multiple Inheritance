class Movement:
    # member function
    def move_left(self):
        print('Moving Left')
    def move_right(self):
        print('Moving Right')
    def move_back(self):
        print('Moving Back')
    def move_forward(self):
        print('Move Forward')
class Eat:
    energyLevel = 10 # enery record
    # member functions
    def eat_object(self):
        self.energyLevel += 1
        print('Object Eaten')
        print('Energy Increased ' + str(self.energyLevel))

class Mario(Movement, Eat):
    # multiple inheriting from 2 classes of movement and eat
    pass # requires due to make the class empty without any piece of code 

mario = Mario() # instance variable for the character 
mario.move_forward()
mario.move_right()
mario.move_back()
mario.eat_object()
mario.move_forward()
mario.eat_object()
