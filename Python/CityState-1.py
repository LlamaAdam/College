# This was made by Adam Cox on 7/18/2019
# It spaces the cities correctly when the old list wasnt working
# Now it also uses an external file to work


def fixer(x): #finds the biggest named city
    count=0
    longest=0
    while count<len(x):
        area=x[count].split(',')
        city=area[0]
        if len(city) > longest:     #This records the longest name
            longest=len(city)
        count += 1
    return longest

def spacer(x,y):
    count = 0
    while count < len(x):               #Split the city, removes the space, keeps and records the zip
        area = x[count].split(',')
        city = area[0]
        garble = area[1].strip()
        state = garble[0:2]
        zip = garble[-5:]
        space=(y+4)-len(city)
        print(space)
        state =state.rjust(space)
        x[count]=city +state+"  "+zip
        count += 1




def main():
    citylist=[line.rstrip() for line in open('CityStateData.txt')]
    print(citylist)
    # Print the table
    longest=fixer(citylist)     #records longest city name
    spacer(citylist,longest)    #use list and longest name
    for c in citylist:
        print(c)

main()
