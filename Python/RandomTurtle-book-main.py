#This program was designed by Adam Cox on 7/4/2019 it has two turtles race on screen.
import random
import turtle

def cords(x,y): #Needs to run multiple times as they might collide at various points
    a,b=x.pos()
    c,d=y.pos()
    style = ("Arial", 15)
    equal=False
    if(a==c) and (c==d):
        x.write("Draw, due to collision of turtles.",font=style)
        print(a,b,c,d)
        equal=True
    return equal

def isInScreen(win,turt):#This keeps track of if the turtles are on the screen.
    leftBound = -win.window_width() / 2
    rightBound = win.window_width() / 2
    topBound = win.window_height() / 2
    bottomBound = -win.window_height() / 2
    turtleX = turt.xcor()
    turtleY = turt.ycor()
    stillIn = True
    if turtleX > rightBound or turtleX < leftBound:
        stillIn = False
    if turtleY > topBound or turtleY < bottomBound:
        stillIn = False
    return stillIn


def coin(x):#This flips the coin to determine the direction of the turtles movement.
    coin = random.randrange(0, 2)
    if coin == 0:
        x.left(90)
    else:
        x.right(90)
    x.forward(50)


def setup(x,y): #Allow the writing to be a bit easier to setup.
    x.shape('turtle')
    x.speed(10)
    x.penup()
    x.forward(y)
    x.pendown()

def finish(x,y):
    print("The winner is turtle number:", y)
    style = ("Arial", 15)
    x.penup()
    x.goto(0, 0)
    x.pendown()
    x.hideturtle()
    x.write("The winner is turtle number:"+y, font=style)


def main():
    wn = turtle.Screen()

    # Define your turtles here
    june = turtle.Turtle()
    setup(june, 0)
    july = turtle.Turtle()
    july.pencolor("blue")
    setup(july, 50)
    while isInScreen(wn,june) and isInScreen(wn,july): #Runs as long as one turtle is on screen
        dice= random.randrange(0, 20) #rolls a dice that is from 0-19
        if cords(june, july):# This has to run 3 times as turtles might collide at various points.
            break
        if dice != 9:
            coin(june) #1st coin flip and move black turtle
        if cords(june, july): #Collision check 2
            break
        if dice != 5:
            coin(july) #2nd coin flip and move blue turtle
        if cords(june, july): #Collision check 3
            break
    if not isInScreen(wn, july):
        finish(july, "two") #reports when
    elif not isInScreen(wn, june):
        finish(june, "one")
    else: #For the rare tie.
        print("Error running software.")
    wn.exitonclick()
main()
